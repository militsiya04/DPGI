using System;
using System.Linq;
using System.Windows;
using Lab5.EF;
using Microsoft.EntityFrameworkCore;

namespace Lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductGuideContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new ProductGuideContext();
            dataGrid1.ItemsSource = _context.Products.ToList();
            dataGrid2.ItemsSource = _context.UnitsOfMeasurements.ToList();
            FormattedData();
            SelectMinMaxPrices();
        }

        private void FormattedData()
        {
            try
            {
                var productsInfo = (from p in _context.Products
                    join u in _context.UnitsOfMeasurements on p.UnitCode equals u.UnitCode
                    select new
                    {
                        ProductInfo = "Товар з артикулом " + p.Article + ", " + p.Quantity + " " + u.UnitName +
                                      ", ціна " + p.Price
                    }).ToList();
                dataGridProductsInfo.ItemsSource = productsInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час виконання запиту: " + ex.Message);
            }
        }

        private void PriceMore_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = _context.Products
                    .FromSqlRaw($"SELECT * FROM Products WHERE Price >= {priceMoreTextBox.Text}")
                    .ToList();
                dataGridPriceMore.ItemsSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час виконання запиту: " + ex.Message);
            }
        }
        
        private void SelectMinMaxPrices()
        {
            try
            {
                var result = _context.Products
                    .Join(_context.UnitsOfMeasurements, 
                        p => p.UnitCode, 
                        u => u.UnitCode, 
                        (p, u) => new { Product = p, Unit = u })
                    .GroupBy(pu => pu.Unit.UnitName)
                    .Select(group => new
                    {
                        UnitName = group.Key,
                        MaxPrice = group.Max(pu => pu.Product.Price),
                        MinPrice = group.Min(pu => pu.Product.Price)
                    })
                    .ToList();

                dataGridMinMax.ItemsSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час виконання запиту: " + ex.Message);
            }
        }
        
    }
    
}
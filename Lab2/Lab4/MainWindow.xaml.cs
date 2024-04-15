using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using Lab4.Data;

namespace Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void Load()
        {
            AdoAssistant myTable = new AdoAssistant();
            list.Focus();
            list.DataContext = myTable.TableLoad(); 
            list.SelectedIndex = 0;

        }

        private void MainWindow_OnClosing(object? sender, CancelEventArgs e)
        {
            Close();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex != -1)
            {
                MessageBox.Show("Press 'Add' button");
                return;
            }

            if (String.IsNullOrEmpty(ArticleTextBox.Text) || String.IsNullOrEmpty(NameTextBox.Text) || String.IsNullOrEmpty(UnitOfMeasureTextBox.Text) || String.IsNullOrEmpty(QuantityTextBox.Text) || String.IsNullOrEmpty(PriceTextBox.Text))
            {
                MessageBox.Show("Enter all rows");
                return;
            }
            AdoAssistant myAssistant = new AdoAssistant();
            if (Int32.TryParse(QuantityTextBox.Text, out int temp1) && float.TryParse(PriceTextBox.Text.Replace('.',','), out float temp2))
            {
                myAssistant.AddRecord(ArticleTextBox.Text,NameTextBox.Text,UnitOfMeasureTextBox.Text, Int32.Parse(QuantityTextBox.Text) ,float.Parse(PriceTextBox.Text.Replace('.',',')) );
            }
            else
            {
                MessageBox.Show("Enter the correct value");
                return;
            }
            Load();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть продукт який необхідно змінити");
                return;
            }
            
            if (String.IsNullOrEmpty(ArticleTextBox.Text) || String.IsNullOrEmpty(NameTextBox.Text) || String.IsNullOrEmpty(UnitOfMeasureTextBox.Text) || String.IsNullOrEmpty(QuantityTextBox.Text) || String.IsNullOrEmpty(PriceTextBox.Text))
            {
                MessageBox.Show("Enter all rows");
                return;
            }
            AdoAssistant myAssistant = new AdoAssistant();
            if (Int32.TryParse(QuantityTextBox.Text, out int temp1) && float.TryParse(PriceTextBox.Text.Replace('.',','), out float temp2))
            {
                myAssistant.UpdateRecord(ArticleTextBox.Text,NameTextBox.Text,UnitOfMeasureTextBox.Text, Int32.Parse(QuantityTextBox.Text) ,float.Parse(PriceTextBox.Text.Replace('.',',')) );
            }
            else
            {
                MessageBox.Show("Enter the correct value");
                return;
            }
            Load();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть продукт який необхідно видалити");
                return;
            }
            AdoAssistant myAssistant = new AdoAssistant();
            myAssistant.DeleteRecord(ArticleTextBox.Text);
            Load();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            list.SelectedIndex = -1;
        }
    }
}
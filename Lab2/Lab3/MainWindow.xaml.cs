using System.Windows;
using System.Windows.Media;

namespace Lab3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private double _lastNumber, _result;
    private SelectedOperator _selectedOperator;

    public MainWindow()
    {
        InitializeComponent();

        AcButton.Click += AcButton_Click;
        NegativeButton.Click += NegativeButton_Click;
        PercentageButton.Click += PercentageButton_Click;
        EqualButton.Click += EqualButton_Click;
    }

    private void EqualButton_Click(object sender, RoutedEventArgs e)
    {
        if (!double.TryParse(ResultLabel.Content.ToString()?.Replace('.', ','), out var newNumber)) return;
        _result = _selectedOperator switch
        {
            SelectedOperator.Addition => SimpleMath.Add(_lastNumber, newNumber),
            SelectedOperator.Substraction => SimpleMath.Substraction(_lastNumber, newNumber),
            SelectedOperator.Multiplication => SimpleMath.Multiply(_lastNumber, newNumber),
            SelectedOperator.Division => SimpleMath.Divide(_lastNumber, newNumber),
            _ => _result
        };

        ResultLabel.Content = _result.ToString().Replace(',', '.');
    }

    private void PercentageButton_Click(object sender, RoutedEventArgs e)
    {
        if (!double.TryParse(ResultLabel.Content.ToString()?.Replace('.', ','), out _lastNumber)) return;
        _lastNumber /= 100;
        ResultLabel.Content = _lastNumber.ToString().Replace(',', '.');
    }

    private void NegativeButton_Click(object sender, RoutedEventArgs e)
    {
        if (!double.TryParse(ResultLabel.Content.ToString()?.Replace('.', ','), out _lastNumber)) return;
        _lastNumber *= -1;
        ResultLabel.Content = _lastNumber.ToString().Replace(',', '.');
    }

    private void AcButton_Click(object sender, RoutedEventArgs e)
    {
        ResultLabel.Content = "0";
    }

    private void OperationButton_Click(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(ResultLabel.Content.ToString()?.Replace('.', ','), out _lastNumber))
        {
            ResultLabel.Content = "0";
        }

        if (Equals(sender, MultiplicationButton))
            _selectedOperator = SelectedOperator.Multiplication;
        else if (Equals(sender, DivisionButton))
            _selectedOperator = SelectedOperator.Division;
        else if (Equals(sender, PlusButton))
            _selectedOperator = SelectedOperator.Addition;
        else if (Equals(sender, MinusButton))
            _selectedOperator = SelectedOperator.Substraction;
    }

    private void pointButton_Click(object sender, RoutedEventArgs e)
    {
        if (!ResultLabel.Content.ToString()!.Contains("."))
        {
            ResultLabel.Content = $"{ResultLabel.Content.ToString()?.Replace(',', '.')}.";
        }
    }

    private void NumberButton_Click(object sender, RoutedEventArgs e)
    {
        var selectedValue = 0;

        if (Equals(sender, ZeroButton))
            selectedValue = 0;
        else if (Equals(sender, OneButton))
            selectedValue = 1;
        else if (Equals(sender, TwoButton))
            selectedValue = 2;
        else if (Equals(sender, ThreeButton))
            selectedValue = 3;
        else if (Equals(sender, FourButton))
            selectedValue = 4;
        else if (Equals(sender, FiveButton))
            selectedValue = 5;
        else if (Equals(sender, SixButton))
            selectedValue = 6;
        else if (Equals(sender, SevenButton))
            selectedValue = 7;
        else if (Equals(sender, EightButton))
            selectedValue = 8;
        else if (Equals(sender, NineButton))
            selectedValue = 9;

        ResultLabel.Content = ResultLabel.Content.ToString() == "0"
            ? $"{selectedValue}"
            : $"{ResultLabel.Content.ToString().Replace(',', '.')}{selectedValue}";
    }


    private void LightTheme_Click(object sender, RoutedEventArgs e)
    {
        MainGrid.Background = new SolidColorBrush(Colors.White);
        ResultLabel.Foreground = new SolidColorBrush(Colors.Black);
        Background = new SolidColorBrush(Colors.White);
    }

    private void DarkTheme_Click(object sender, RoutedEventArgs e)
    {
        MainGrid.Background = new SolidColorBrush(Colors.Black);
        ResultLabel.Foreground = new SolidColorBrush(Colors.White);
        Background = new SolidColorBrush(Colors.Black);
    }
}
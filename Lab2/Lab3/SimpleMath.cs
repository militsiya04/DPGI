﻿using System.Windows;

namespace Lab3;

public static class SimpleMath
{
    public static double Add(double n1, double n2)
    {
        return n1 + n2;
    }
    
    public static double Substraction(double n1, double n2)
    {
        return n1 - n2;
    }
    
    public static double Multiply(double n1, double n2)
    {
        return n1 * n2;
    }
    
    public static double Divide(double n1, double n2)
    {
        if (n2 != 0) return n1 / n2;
        MessageBox.Show("Division by 0 is not supported", "Wrong operation", MessageBoxButton.OK,
            MessageBoxImage.Error);
        return 0;
    
    }
}
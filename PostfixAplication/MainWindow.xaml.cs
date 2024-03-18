using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PostfixAplication;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonClear(object sender, RoutedEventArgs e)
    {
        Combination.Text = string.Empty;
        Outputing.Text = string.Empty;
    }

    private void ButtonEnter(object sender, RoutedEventArgs e)
    {
        string combination = Combination.Text;

        if (!IsValid(combination))
        {
            MessageBox.Show("Invalid combination. ");
            return;
        }

        try
        {
            double result = PostfixCalc(combination);
            Outputing.Text = result.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error occurred: " + ex.Message);
        }
    }

    private static double PostfixCalc(string combination)
    {
        Stack<double> stack = new Stack<double>();
        
        combination = combination.Replace(" ", "");

        foreach (char @operator in combination)
        {
            if (char.IsDigit(@operator))
            {
                stack.Push((@operator - '0'));
            }
            else if (IsOperator(@operator))
            {
                double numTwo = stack.Pop();
                double numOne = stack.Pop();

                switch (@operator)
                {
                    case '+':
                        stack.Push(numOne + numTwo);
                        break;
                    case '-':
                        stack.Push(numOne - numTwo);
                        break;
                    case '*':
                        stack.Push(numOne * numTwo);
                        break;
                    case '/':
                        stack.Push(numOne / numTwo);
                        break;
                }
            }
        }
        return stack.Pop();
    }

    private static bool IsOperator(char @operator)
    {
        return @operator == '+' || @operator == '-' || @operator == '*' || @operator == '/';
    }

    public static bool IsValid(string combination)
    {
        if (string.IsNullOrEmpty(combination))
            return false;

        bool isFirstCharNumber = char.IsDigit(combination[0]);
        if (!isFirstCharNumber)
            return false;

        foreach (char check in combination)
        {
            if (!char.IsDigit(check) && !IsOperator(check) && !char.IsWhiteSpace(check))
            {
                return false;
            }
        }
        return true;
    }
}

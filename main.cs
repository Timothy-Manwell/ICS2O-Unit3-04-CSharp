// Created by: Timothy Manwell
// Created on: Oct 2022
//
// This program converts Fahrenheit to Celsius32
using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double fahrenheit;
        double celsius;

        Console.WriteLine("This program converts Fahrenheit to Celsius");
        Console.Write("\nEnter temperature in Fahrenheit: ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());
        celsius = ((fahrenheit - 32) * 5) / 9;
        Console.WriteLine("\n" + fahrenheit + "℉ is "  + celsius.ToString("0.0") + "℃.");
    }
}
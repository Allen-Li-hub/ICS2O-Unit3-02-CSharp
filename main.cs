// Created by: Allen
// Created on: Oct 2022
//
// This program calculates Volume of a Pyramid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int lengthOfPyramid;
        int widthOfPyramid;
        int heightOfPyramid;
        int volumeOfPyramid;

        Console.WriteLine("This program calculates the area of a triangle.");
        Console.WriteLine("");

        Console.Write("Enter the length (cm): ");
        lengthOfPyramid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the width (cm): ");
        widthOfPyramid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        heightOfPyramid = Convert.ToInt32(Console.ReadLine());

        volumeOfPyramid = (lengthOfPyramid * widthOfPyramid * heightOfPyramid) / 3;

        Console.WriteLine("");
        Console.WriteLine("The volume is: " + volumeOfPyramid + " cm³. ");

        Console.WriteLine("\nDone.");
    }
}

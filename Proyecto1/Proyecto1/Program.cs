﻿using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
       
        
        double pi = 3.14159;

        double r = Math.Round(double.Parse(Console.ReadLine()),2);
        Console.WriteLine(String.Format( "{0:0.00}", r));
        double Area = (pi * (r * r));
        Console.WriteLine("A=" + Math.Round(Area,4));
        
        // correcion
        //Ejercicio Radio
        double radio, area, pi2 = 3.14159;

        radio = double.Parse(Console.ReadLine());

        area = (radio * radio) * pi2;

        area = Math.Round(area, 4, MidpointRounding.AwayFromZero);

        Console.WriteLine("A=" + area.ToString("0.0000"));
        //Ejercicio Promedio
        double NOTA1, NOTA2, MEDIA;
        NOTA1 = Convert.ToDouble(Console.ReadLine());
        NOTA2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("MEDIA = " + ((NOTA1 * 3.5 + NOTA2 * 7.5) / (3.5 + 7.5)).ToString("0.00000"));
        //Ejercicio Promedio 2
        double N1, N2, N3;
        N1 = Convert.ToDouble(Console.ReadLine());
        N2 = Convert.ToDouble(Console.ReadLine());
        N3= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("MEDIA = " + ((N1 * 2 + N2 * 3+ N3*5) / (10)).ToString("0.0"));
        //ejercicio Diferencia
        int A, B, C, D,DIFERENCIA;
        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());
        DIFERENCIA=((A*B)-(C*D));
        Console.WriteLine("DIFERENCA = " + DIFERENCIA);
        //Ejericio Salario
        Console.WriteLine("Ejercicio Salario ");
        int numEm, Horas = 0;
        double Sal = 0;
        numEm = int.Parse(Console.ReadLine());
        Horas = int.Parse(Console.ReadLine());
        Sal = double.Parse(Console.ReadLine());
        Console.WriteLine("NUMBER = " + numEm + "\n" + "SALARY = U$ " + ((Horas * Sal)).ToString("0.00"));

    }
}
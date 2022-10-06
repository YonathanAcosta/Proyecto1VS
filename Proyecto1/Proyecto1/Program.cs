using System;
using System.Globalization;

internal class Program
{
    private const string Separator = " ";

    private static void Main(string[] args)
    {

        /*
        // correcion
        //Ejercicio Radio
        Console.WriteLine("Ejercicio Radio ");
        double radio, area, pi2 = 3.14159;

        radio = double.Parse(Console.ReadLine());

        area = (radio * radio) * pi2;

        area = Math.Round(area, 4, MidpointRounding.AwayFromZero);

        Console.WriteLine("A=" + area.ToString("0.0000"));
        //Ejercicio Promedio
        Console.WriteLine("Ejercicio prom ");
        double NOTA1, NOTA2, MEDIA;
        NOTA1 = Convert.ToDouble(Console.ReadLine());
        NOTA2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("MEDIA = " + ((NOTA1 * 3.5 + NOTA2 * 7.5) / (3.5 + 7.5)).ToString("0.00000"));
        //Ejercicio Promedio 2
        Console.WriteLine("Ejercicio Promedio ");
        double N1, N2, N3;
        N1 = Convert.ToDouble(Console.ReadLine());
        N2 = Convert.ToDouble(Console.ReadLine());
        N3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("MEDIA = " + ((N1 * 2 + N2 * 3 + N3 * 5) / (10)).ToString("0.0"));
        //ejercicio Diferencia
        Console.WriteLine("Ejercicio Diferencia ");
        int A, B, C, D, DIFERENCIA;
        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());
        DIFERENCIA = ((A * B) - (C * D));
        Console.WriteLine("DIFERENCA = " + DIFERENCIA);
        //Ejericio Salario
        Console.WriteLine("Ejercicio Salario ");
        int numEm, Horas = 0;
        double Sal = 0;
        numEm = int.Parse(Console.ReadLine());
        Horas = int.Parse(Console.ReadLine());
        Sal = double.Parse(Console.ReadLine());
        Console.WriteLine("NUMBER = " + numEm + "\n" + "SALARY = U$ " + ((Horas * Sal)).ToString("0.00"));
        //Ejercicio Salario Con Bonus
        Console.WriteLine("Ejercicio Salario Con Bonus");
        string nombre = "";
        double salario, valorVen = 0;
        nombre = Console.ReadLine();
        salario = double.Parse(Console.ReadLine());
        valorVen = double.Parse(Console.ReadLine());
        Console.WriteLine("TOTAL = R$ " + (salario + (valorVen * 0.15)).ToString("0.00"));
        
         // ejercicio Calculo
        Console.WriteLine("Ejercicio Calculo");
        int codp1, codp2, can1, can2; double valor1, valor2, total; 

        String[] cadena1 = Console.ReadLine().Split(' ');
        codp1 = int.Parse(cadena1[0]);
        can1 = int.Parse(cadena1[1]);
        valor1 = double.Parse(cadena1[2]);

        String [] cadena2 = Console.ReadLine().Split(' ');
        codp2 = int.Parse(cadena2[0]);
        can2 = int.Parse(cadena2[1]);
        valor2 = double.Parse(cadena2[2]);
    
        double total1 = can1 * valor1;
        double total2 = can2 * valor2;

        total = total1 + total2;


        

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("0.00"));
         
         
         Console.WriteLine("Ejercicio Esfera ");
        double pi = 3.14159;
        int r = int.Parse(Console.ReadLine());
        double div = 4.0 / 3;
        double resul = div * (pi * (Math.Pow(r, 3)));
        Console.WriteLine("VOLUME = " + resul.ToString("0.000"));

         
          //ejercicio ESFERA
        double a, b, c, pi, triangulo, circulo, trapezio, cuadrado, rectangulo;
        pi = 3.14159;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
        triangulo = (a * c) / 2.0;
        circulo = (pi * (c * c));
        trapezio = (((a + b) * (c)) / 2);
        cuadrado = (b * b);
        rectangulo = (a * b);
        Console.WriteLine("TRIANGULO: " + triangulo.ToString("0.000"));
        Console.WriteLine("CIRCULO: " + circulo.ToString("0.000"));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("0.000"));
        Console.WriteLine("QUADRADO: " + cuadrado.ToString("0.000"));
        Console.WriteLine("RETANGULO: " + rectangulo.ToString("0.000"));
  
         //Ejercicio Mayor y menor
        int valor1,valor2, valor3, valorT, valorM;

        string[] cadena1 = Console.ReadLine().Split(' ');
        valor1 = int.Parse(cadena1[0]);
        valor2 = int.Parse(cadena1[1]);
        valor3 = int.Parse(cadena1[2]);
        valorT = (((valor1+ valor2)+ Math.Abs(valor1-valor2))/2);
        valorM = (((valorT + valor3) + Math.Abs(valorT - valor3)) / 2);


        Console.WriteLine(valorM+" eh o maior");



         */
        //ejercicio 
        int x = 0;
        double y,gasto = 0;
        x=int.Parse(Console.ReadLine());
        y=double.Parse(Console.ReadLine());
        gasto=(x/y);

        Console.WriteLine(gasto.ToString("0.000 ")+" km/l");


      










    }
}
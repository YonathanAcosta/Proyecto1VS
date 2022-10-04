internal class Program
{
    private static void Main(string[] args)
    {
        //AREA DE UN CIRCULO
        double r = double.Parse(Console.ReadLine());
        double pi = 3.1416;
        double A = pi * (r*r);
        Console.WriteLine("A={0}", A);
        //SUMA
        int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        int SOMA = a + b;
        Console.WriteLine("SOMA = {0}", SOMA);
        //Producto
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int prod = m * n;
        Console.WriteLine("PROD = {0}", prod);
        //Promedio 
        float nota1 = float.Parse(Console.ReadLine());
        float nota2 = float.Parse(Console.ReadLine());
        while ((nota1<0||nota1>10)&&(nota2 < 0 || nota2 > 10))
        {
            Console.WriteLine("Error en las notas");
            nota1 = float.Parse(Console.ReadLine());
             nota2 = float.Parse(Console.ReadLine());
        }
        float MEDIA = ((nota1 + nota2) / 2);
        Console.WriteLine("MEDIA = {0}", MEDIA);
    }
}

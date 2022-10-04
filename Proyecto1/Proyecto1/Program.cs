internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite el numero de notas");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("El numero es: "+num1);
        //Prueba del promedio
        int[] numeros=new int[num1] ;
        for(int i = 0; i < num1; i++){
            Console.WriteLine("Escriba la nota " + (i + 1));
            numeros[i] = int.Parse(Console.ReadLine());
        }
        int num = 0;
        for(int i = 0; i < numeros.Length; i++){
            num+=numeros[i];
        }
        int res = num / numeros.Length;
        Console.WriteLine("El promedio de notas es:"+res);
        
    }
}
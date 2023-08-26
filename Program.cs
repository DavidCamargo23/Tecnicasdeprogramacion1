namespace Tecnicasdeprogramacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //Ejercicio 1
            Console.WriteLine("Digite un numero");
            string dato = Console.ReadLine();
            int num = Int32.Parse(dato);
            int num2 = num + 1;
            Console.WriteLine("el numero es: " + num2);

        }
    }
}
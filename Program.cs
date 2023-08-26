namespace Tecnicasdeprogramacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1:Diseñar un algoritmo que pida un número por teclado y luego imprima el número siguiente al ingresado.
            Console.WriteLine("Digite un numero");
            string dato = Console.ReadLine();
            int num = Int32.Parse(dato);
            int num2 = num + 1;
            Console.WriteLine("El numero es: " + num2);
            Console.WriteLine("//////////////////////////////////////////////");
            //Ejercicio 2: Diseñar un algoritmo que genere un número aleatorio del 0 al 200,lo muestre y luego calcule y muestre el mismo número aumentado en un 30 %.
            Console.WriteLine("Generando un número al azar entre 0 a 200.");
            Random random = new Random();
            int numAleatorio = random.Next(0, 201);
            Console.WriteLine("El numero es aleatorio es: " + numAleatorio);
            double treintapor = 0.3 * numAleatorio;
            Console.WriteLine("El 30% del numero es aleatorio es: " + treintapor);
            Console.WriteLine("//////////////////////////////////////////////");
            //Ejercicio 3: Diseñar un algoritmo que imprima el área y el perímetro de un rectángulo ingresando su base y altura.
            Console.WriteLine("Datos para la calcular el area y el perimetro de un rectangulo.");
            Console.WriteLine("Digite la base:");
            string base1 = Console.ReadLine();
            int baseCu = Int32.Parse(base1);
            Console.WriteLine("Digite la altura:");
            string alt1 = Console.ReadLine();
            int altCu = Int32.Parse(alt1);
            int areaCu = baseCu * altCu;
            int perimetroCu = (2 * baseCu) + (2 * altCu);
            Console.WriteLine("El area de cuadrado es: " + areaCu + " y El perimetro es:"+ perimetroCu);
            Console.WriteLine("//////////////////////////////////////////////");
        }
    }
}
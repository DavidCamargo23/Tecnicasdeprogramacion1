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
            Console.WriteLine("/////////////////////////////////////////////////////////////");
         //Ejercicio 2: Diseñar un algoritmo que genere un número aleatorio del 0 al 200,lo muestre y luego calcule y muestre el mismo número aumentado en un 30 %.
            Console.WriteLine("Generando un número al azar entre 0 a 200.");
            Random random = new Random();
            int numAleatorio = random.Next(0, 201);
            Console.WriteLine("El numero es aleatorio es: " + numAleatorio);
            double treintapor = 0.3 * numAleatorio;
            Console.WriteLine("El 30% del numero es aleatorio es: " + treintapor);
            Console.WriteLine("/////////////////////////////////////////////////////////////");
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
            Console.WriteLine("El area de rectangulo es: " + areaCu + " y El perimetro es:"+ perimetroCu);
            Console.WriteLine("/////////////////////////////////////////////////////////////");
         //Ejercicio 4: Realice un algoritmo que calcule el volumen de un cilindro a partir de los valores de su radio y altura.
            Console.WriteLine("Datos para la calcular el volumen de un cilindro.");
            Console.WriteLine("Digite la altura:");
            string alt2 = Console.ReadLine();
            int altCi = Int32.Parse(alt2);
            Console.WriteLine("Digite el radio:");
            string rad1 = Console.ReadLine();
            int radCi = Int32.Parse(rad1);
            double volumenCi = Math.PI*(Math.Pow(radCi,2)) * altCi;
            Console.WriteLine("El volumen del cilindro es: " + volumenCi);
            Console.WriteLine("/////////////////////////////////////////////////////////////");
         //Ejercicio 5: Crear un algoritmo que convierta y muestre un valor ingresado en centímetros a yardas, metros, pies y pulgadas.
            Console.WriteLine("Conversor de unidades.");
            Console.WriteLine("Digite los centimetros a convertir:");
            string centimetroUsu = Console.ReadLine();
            double centimetros1 = Int32.Parse(centimetroUsu);
            double yardas = centimetros1 * 0.010936133;
            double metros = centimetros1 * 0.01;
            double pies = centimetros1 * 0.0328083989501;
            double pulgasdas = centimetros1 * 0.393700787402;
            Console.WriteLine("El valor en yardas es: " + yardas);
            Console.WriteLine("El valor en metros es: " + metros);
            Console.WriteLine("El valor en pies es: " + pies);
            Console.WriteLine("El valor en pulgadas es: " + pulgasdas);
            Console.WriteLine("/////////////////////////////////////////////////////////////");
         //Ejercicio 6: Diseñar un algoritmo que convierta y muestre la temperatura en Fahrenheit ingresando la temperatura en Celsius.
            Console.WriteLine("Conversor de celsius a Fahrenheit.");
            Console.WriteLine("Digite los grados celsius a convertir:");
            string celsiusUsu = Console.ReadLine();
            double celsius1 = Int32.Parse(celsiusUsu);
            double fahren1 = ((celsius1 * 9)/5)+32; //(0 °C × 9/5) + 32 = 32 °F
            Console.WriteLine("El valor en grados Fahrenheit es: " + fahren1);
            Console.WriteLine("/////////////////////////////////////////////////////////////");
          //Ejercicio 7: Diseñar un algoritmo que calcule el volumen de un cilindro dados su radio y altura(primero el programa deberá verificar si son positivas).
            Console.WriteLine("Datos para la calcular el volumen de un cilindro.");
            Console.WriteLine("Digite la altura:");
            string alt3 = Console.ReadLine();
            int altCi1 = Int32.Parse(alt3);
            if (altCi1 < 0)
            { 
             Console.WriteLine("El número digitado no es Positivo");
             Console.WriteLine("Digite nuevamente la altura:");
             string alt3 = Console.ReadLine();
             int altCi1 = Int32.Parse(alt3);
                altCi1 = altCi2;
                
            }
            else
            Console.WriteLine("Digite el radio:");
            string rad2 = Console.ReadLine();
            int radCi1 = Int32.Parse(rad2);
            if (radCi1 < 0)
            {
                Console.WriteLine("El número digitado no es Positivo");
                Console.WriteLine("Digite nuevamente el radio:");
                string rad2 = Console.ReadLine();
                int radCi1 = Int32.Parse(rad2);
                radCi1 = radCi2;
            }
            else
            double volumenCi1= Math.PI * (Math.Pow(radCi1, 2)) * altCi1;
            Console.WriteLine("El volumen del cilindro es: " + volumenCi1);
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            //Crear un algoritmo que calcule si dos números son divisibles.Para ello, se piden un primer número y un segundo número, entonces mostrar
            //un cartel que diga “es divisible” si el segundo número es divisible al primero.
           // Console.WriteLine("Datos para la calcular el volumen de un cilindro.");
           // Console.WriteLine("Digite la altura:");
            //Diseñar un algoritmo para calcular el porcentaje de hombres y de mujeres que hay en un grupo, dados los totales de hombres y de mujeres.

        }
    }
}

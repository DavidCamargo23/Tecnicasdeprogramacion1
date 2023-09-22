 using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Tecnicasdeprogramacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa una opción:");
            Console.WriteLine("1: Diseñar un algoritmo que pida un número por teclado y luego imprima el número siguiente al ingresado.");
            Console.WriteLine("2: Generar un número aleatorio del 0 al 200, mostrarlo y luego calcular y mostrar el mismo número aumentado en un 30 %.");
            Console.WriteLine("3: Calcular el área y el perímetro de un rectángulo ingresando su base y altura.");
            Console.WriteLine("4: Calcular el volumen de un cilindro a partir de los valores de su radio y altura.");
            Console.WriteLine("5: Convertir un valor ingresado en centímetros a yardas, metros, pies y pulgadas.");
            Console.WriteLine("6: Convertir la temperatura en Fahrenheit ingresando la temperatura en Celsius.");
            Console.WriteLine("7: Calcular el volumen de un cilindro dados su radio y altura (verificando si son positivas).");
            Console.WriteLine("8: Crear un algoritmo que calcule si dos números son divisibles.");
            Console.WriteLine("9: Diseñar un algoritmo para calcular el porcentaje de hombres y de mujeres que hay en un grupo, dados los totales de hombres y de mujeres.");
            Console.WriteLine("10: Diseñar un algoritmo que indique con carteles si el número ingresado es negativo, positivo o nulo.");
            Console.WriteLine("11: Ingresar tres números y mostrar el mayor(asuma que todos son distintos entre sí)");
            Console.WriteLine("12: Realice un algoritmo para mostrar un cartel que indique si un triángulo es «escaleno», «equilátero» o «isósceles» ingresando sus lados");
            Console.WriteLine("13: Salir");

            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    SumaNumero();
                    break;
                case 2:
                    NumeroRamdon();
                    break;

                case 3:
                    AreaRectangulo();
                    break;

                case 4:
                    AltCilindro();
                    break;

                case 5:
                    ConvertirCm();
                    break;

                case 6:
                    ConvertirTemp(); 
                    break;

                case 7:
                    AltCilindro1();
                    break;

                case 8:
                    Divisible();
                    break;
                    
                case 9:
                    HombreMujer(); 
                    break;
                    
                case 10:
                    IndicarSigno();
                    break;
                    
                case 11:
                    EncontrarMayor();
                break;
                    
                case 12:
                    ClasificarTriangulo();
                break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        }
        public static void SumaNumero() {
            Console.WriteLine("Digite un número:");
            int dato = int.Parse(Console.ReadLine());
            int siguienteNumero = dato + 1;
            Console.WriteLine("El número siguiente es: " + siguienteNumero);
        }
        public static void NumeroRamdon()
        {
            Random random = new Random();
            int numAleatorio = random.Next(0, 201);
            Console.WriteLine("Número aleatorio generado: " + numAleatorio);
            double treintaPorciento = 0.3 * numAleatorio;
            double nuevoNumero = numAleatorio + treintaPorciento;
            Console.WriteLine("Número aumentado en un 30%: " + nuevoNumero);
        }
        public static void AreaRectangulo()
        {
            Console.WriteLine("Por favor, ingresa la base del rectángulo:");
            int baseRectangulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingresa la altura del rectángulo:");
            int alturaRectangulo = int.Parse(Console.ReadLine());
            int areaRectangulo = baseRectangulo * alturaRectangulo;
            int perimetroRectangulo = 2 * (baseRectangulo + alturaRectangulo);
            Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
            Console.WriteLine("El perímetro del rectángulo es: " + perimetroRectangulo);
        }
        public static void AltCilindro()
        {
            Console.WriteLine("Por favor, ingresa la altura del cilindro:");
            int alturaCilindro = int.Parse(Console.ReadLine());
            if (alturaCilindro < 0)
            {
                Console.WriteLine("La altura no puede ser negativa.");
                return;
            }

            Console.WriteLine("Por favor, ingresa el radio del cilindro:");
            int radioCilindro = int.Parse(Console.ReadLine());
            if (radioCilindro < 0)
            {
                Console.WriteLine("El radio no puede ser negativo.");
                return;
            }

            double volumenCilindro = Math.PI * Math.Pow(radioCilindro, 2) * alturaCilindro;
            Console.WriteLine("El volumen del cilindro es: " + volumenCilindro); ;
        }
        public static string ConvertirCm()
        {
            Console.WriteLine("Por favor, ingresa la longitud en centímetros:");
            double longitudCm = double.Parse(Console.ReadLine());
            double yardas = longitudCm / 91.44;
            double metros = longitudCm / 100;
            double pies = longitudCm / 30.48;
            double pulgadas = longitudCm / 2.54;

            Console.WriteLine("Longitud en yardas: " + yardas);
            Console.WriteLine("Longitud en metros: " + metros);
            Console.WriteLine("Longitud en pies: " + pies);
            Console.WriteLine("Longitud en pulgadas: " + pulgadas);
            return;
        }
        public static void ConvertirTemp()
        {
            Console.WriteLine("Por favor, ingresa la temperatura en grados Celsius:");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);
        }
        public static void AltCilindro1()
        {
            Console.WriteLine("Por favor, ingresa la altura del cilindro:");
            int alturaCilindro7 = int.Parse(Console.ReadLine());
            if (alturaCilindro7 < 0)
            {
                Console.WriteLine("La altura no puede ser negativa.");
                return;
            }
            Console.WriteLine("Por favor, ingresa el radio del cilindro:");
            int radioCilindro7 = int.Parse(Console.ReadLine());
            if (radioCilindro7 < 0)
            {
                Console.WriteLine("El radio no puede ser negativo.");
                return;
            }

            double volumenCilindro7 = Math.PI * Math.Pow(radioCilindro7, 2) * alturaCilindro7;
            Console.WriteLine("El volumen del cilindro es: " + volumenCilindro7);
            return;
        }
        public static void Divisible()
        {
            Console.WriteLine("Ingrese el primer número:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
            else if (numero1 % numero2 == 0)
            {
                Console.WriteLine($"{numero1} es divisible por {numero2}");
            }
            else
            {
                Console.WriteLine($"{numero1} no es divisible por {numero2}");
            }
        }
        public static void HombreMujer()
        {
            Console.WriteLine("Ingrese el número total de hombres en el grupo:");
            int hombres = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número total de mujeres en el grupo:");
            int mujeres = int.Parse(Console.ReadLine());

            int totalPersonas = hombres + mujeres;

            if (totalPersonas > 0)
            {
                double porcentajeHombres = (double)hombres / totalPersonas * 100;
                double porcentajeMujeres = (double)mujeres / totalPersonas * 100;

                Console.WriteLine($"En el grupo, el {porcentajeHombres}% son hombres y el {porcentajeMujeres}% son mujeres.");
            }
            else
            {
                Console.WriteLine("No se puede calcular el porcentaje sin datos válidos.");
            }
            return;

        }
        public static void IndicarSigno()
        {
            Console.WriteLine("Por favor, ingresa un número:");
            int numero = int.Parse(Console.ReadLine());
        
            if (numero > 0)
            {
                Console.WriteLine("El número ingresado es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número ingresado es negativo.");
            }
            else
            {
                Console.WriteLine("El número ingresado es nulo.");
            }
        }

        public static void EncontrarMayor()
            {
                Console.WriteLine("Por favor, ingresa el primer número:");
                int numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor, ingresa el segundo número:");
                int numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor, ingresa el tercer número:");
                int numero3 = int.Parse(Console.ReadLine());
            
                int mayor = Math.Max(Math.Max(numero1, numero2), numero3);
                Console.WriteLine($"El mayor de los tres números es: {mayor}");
            }

        public static void ClasificarTriangulo()
        {
            Console.WriteLine("Por favor, ingresa el primer lado del triángulo:");
            double lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingresa el segundo lado del triángulo:");
            double lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingresa el tercer lado del triángulo:");
            double lado3 = double.Parse(Console.ReadLine());
        
            if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
            else if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
        }

    }
}





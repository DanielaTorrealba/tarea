using System;

namespace teleprgm2
{
    class Animal
    {
        
        private string nombre;
        private int edad;
        private int peso;
       

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value <= 0)
                {
               
                    Console.WriteLine("Edad inválida, por favor ingrese un número positivo");
                }
                else { edad = value; }
            }
        }

        public int Peso
        {
            get { return peso; }
            set
            {
                if (value <= 0)
                {
                   
                    Console.WriteLine("Peso inválido, por favor ingrese un valor positivo");
                }
                else { peso = value; }
            }
        }

     
    }
    class Perro : Animal
    {

        private string tipoalimento;
        private string raza;

        public string Tipoalimento
        {
            get { return tipoalimento; }
            set { tipoalimento = value; }
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }


        class Program

        {
            static void Main(string[] args)
            {
                Perro p = new Perro();

                Console.WriteLine("Ingrese nombre del perro: ");
                p.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del perro: ");
                p.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el peso del perro: ");
                p.Peso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese raza del perro: ");
                p.Raza = Console.ReadLine();
                Console.WriteLine("Ingrese tipo de alimento: ");
                p.Tipoalimento = Console.ReadLine();

                //Datos de salida

                Console.WriteLine("\n Datos Finales \n");
                Console.WriteLine("Nombre: {0}", p.Nombre);
                Console.WriteLine("Edad: {0}", p.Edad);
                Console.WriteLine("Peso: {0}", p.Peso);
                Console.WriteLine("Raza: {0}", p.Raza);
                Console.WriteLine("Tipo de Alimento: {0}", p.Tipoalimento);
            }
        }
    }
}


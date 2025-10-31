using ConsoleApp1;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleApp1
{
    public class Program
    {

        class Restaurante
        {
            private string[] mexicano = ["tacos", "carnes", "quesadillas"];
            private string[] italiano = ["vino", "pastas", "pizzas"];
            private string[] argentino = ["milanesa", "fernet", "asado"];

            public void getMexicano()
            {
                foreach (var item in mexicano)
                {
                    Console.WriteLine(item);

                }

            }
            public void getItaliano()
            {
                foreach (var item in italiano)
                {
                    Console.WriteLine(item);

                }

            }
            public void getArgentino()
            {
                foreach (var item in argentino)
                {
                    Console.WriteLine(item);

                }


            }
            public void setArgentino(string nuevoNombre)
            {
                argentino = argentino.Append(nuevoNombre).ToArray();
            }
        }


        static void Main(string[] args)
        {
            Restaurante benja1 = new Restaurante();

            Console.Write("Ingrese que menu quiere ver =");
            string Menu = Console.ReadLine();
            switch (Menu)
            {
                case "argentino":
                    benja1.setArgentino("suprema");
                    benja1.getArgentino();
                    break;
                case "italiano":
                    benja1.getItaliano();
                    break;
                case "mexicano":
                    benja1.getMexicano();
                    break;
                default:
                    Console.Write("Menu no encontrado");
                    break;
            }
        }
    }
}




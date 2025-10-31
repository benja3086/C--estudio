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

        //public static void Main(string[] args)
        //{
        //    string admin = "andres";
        //    string comun = "eunice";
        //    string vendedor = "benjamin";


        //    Admins admins1 = new Admins();
        //    Comun comun1 = new Comun();
        //    var vendedor1 = new Vendedor();


        //    Console.Write("Ingrese su nombre =");
        //    string Nombre = Console.ReadLine();

        //    string Name = Nombre;
        //    switch (Name)
        //    {
        //        case "andres":
        //            Console.Write(benja1.GetNombre + "\n");
        //            Console.Write(admins1.Email + "\n");
        //            Console.Write(admins1.Nombre + "\n");
        //            Console.Write(admins1.Tipodeusuario);
        //            Console.Write(admins1.Permisos);

        //            break;
        //        case "eunice":
        //            Console.Write(comun1.Email + "\n");
        //            Console.Write(comun1.Nombre + "\n");
        //            Console.Write(comun1.Tipodeusuario);
        //            Console.Write(comun1.Permisos);

        //            break;
        //        case "benjamin":
        //            Console.Write(vendedor1.Email + "\n");
        //            Console.Write(vendedor1.Nombre + "\n");
        //            Console.Write(vendedor1.Tipodeusuario);
        //            Console.Write("quieres ver los permisos? =");
        //            string benja3 = Console.ReadLine();
        //            if (benja3 == "si")
        //            {
        //                Console.Write(vendedor1.Permisos);
        //            }
        //            else
        //            {
        //                Console.Write("okey chao");
        //            }
        //            break;
        //        default:
        //            Console.Write("Usuario no encontrado");
        //            break;

        //    }
        // }


        //static void Main(string[] args)
        //{
        //    //Singleton benja1 = new Singleton();
        //    //Comun comun = new Comun();
        //    //comun.apellido="Quinteros";
        //    //benja1.setUsuario(comun);
        //    //Console.WriteLine(benja1.getUsuario()[0].apellido);
        //}
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




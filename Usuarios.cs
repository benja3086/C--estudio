using System;

public class Class1
{
    public Class1()
    {
        public static void Main(string[] args)
    {
        string admin = "andres";
        string comun = "eunice";
        string vendedor = "benjamin";


        Admins admins1 = new Admins();
        Comun comun1 = new Comun();
        var vendedor1 = new Vendedor();


        Console.Write("Ingrese su nombre =");
        string Nombre = Console.ReadLine();

        string Name = Nombre;
        switch (Name)
        {
            case "andres":
                Console.Write(benja1.GetNombre + "\n");
                Console.Write(admins1.Email + "\n");
                Console.Write(admins1.Nombre + "\n");
                Console.Write(admins1.Tipodeusuario);
                Console.Write(admins1.Permisos);

                break;
            case "eunice":
                Console.Write(comun1.Email + "\n");
                Console.Write(comun1.Nombre + "\n");
                Console.Write(comun1.Tipodeusuario);
                Console.Write(comun1.Permisos);

                break;
            case "benjamin":
                Console.Write(vendedor1.Email + "\n");
                Console.Write(vendedor1.Nombre + "\n");
                Console.Write(vendedor1.Tipodeusuario);
                Console.Write("quieres ver los permisos? =");
                string benja3 = Console.ReadLine();
                if (benja3 == "si")
                {
                    Console.Write(vendedor1.Permisos);
                }
                else
                {
                    Console.Write("okey chao");
                }
                break;
            default:
                Console.Write("Usuario no encontrado");
                break;

        }
    }


    static void Main(string[] args)
    {
        Singleton benja1 = new Singleton();
        Comun comun = new Comun();
        comun.apellido = "Quinteros";
        benja1.setUsuario(comun);
        Console.WriteLine(benja1.getUsuario()[0].apellido);
    }+
    }
}

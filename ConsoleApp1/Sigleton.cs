using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    class Singleton
    {

        private static Singleton _instance;
        private Comun[] nombre = [];


        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
        public void setUsuario(Comun nuevoNombre)
        {
            nombre = nombre.Append(nuevoNombre).ToArray();
        }
        public Comun[] getUsuario()
        {
            return nombre;
        }
    }
    public class Comun
    {
        public string nombre1 = "";
        public string apellido = "";
        public int edad = 0;


    }
    //public void deleteNombre()
    //{
    //    Nombre = "";
    //}


}


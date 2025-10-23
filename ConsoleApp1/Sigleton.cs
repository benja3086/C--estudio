namespace ConsoleApp1
{
    public class Singleton
    {

        private static Singleton _instance = null;
        private Array Admin = "Benja","andres";
        private Array Comun = Benja,andres;
        -
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public string getNombre()
        {
            return this.Nombre;
        }
        public void setNombre(string nuevoNombre, bool admin)
        {
            Nombre = nuevoNombre;
            
        }
        public void deleteNombre()
        {
            Nombre = "";
        }


    }
}

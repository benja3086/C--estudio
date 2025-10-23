using ConsoleApp1.Interfaces;
namespace ConsoleApp1.Models
{
    public class Vendedor : IUsuarios
    {
        public string Tipodeusuario { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Permisos { get; set; }

        public Vendedor()
        {
            this.Email = "benjamin123";
            this.Nombre = "benjamin";
            this.Tipodeusuario = "Usted es un Vendedor\n";
            this.Permisos = "Puedes cambiar el precio de los productos" + "\n"+ "Puedes borrar productos\n" + "Puedes agregar un producto";
                


        }
    }
}

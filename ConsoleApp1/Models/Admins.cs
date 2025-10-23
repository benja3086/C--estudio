using ConsoleApp1.Interfaces;
namespace ConsoleApp1.Models
{
    public class Admins: IUsuarios
    {
        public string Tipodeusuario { get; set; }
        public string Email { get; set; }

        public string Nombre { get; set; }
        public string Permisos { get; set; }

        public Admins()
        {
            this.Email = "andres123";
            this.Nombre = "andres";
            this.Tipodeusuario = "Usted es un admin\n";
            this.Permisos = "Tenes todos los permisos chad\n" + "Puedes cambiar el precio a los productos\n" + "Puedes borrar Productos\n" + "Puedes despedir a gente";
        }
    }
}

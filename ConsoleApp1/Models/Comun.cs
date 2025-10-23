using ConsoleApp1.Interfaces;
namespace ConsoleApp1.Models
{
    public class Comun : IUsuarios
    {
        public string Tipodeusuario {get; set;}
        public string Email { get; set; }

        public string Nombre { get; set; }
        public string Permisos { get; set; }

        public Comun()
        {
            this.Email = "Eunice123";
            this.Nombre = "Eunice";
            this.Tipodeusuario = "Usted es un usuario comprador\n";
            this.Permisos = "No tienes ningun permiso tontito";



        }
    }
}

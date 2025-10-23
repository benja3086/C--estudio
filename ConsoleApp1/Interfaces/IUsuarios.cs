using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    public interface IUsuarios
    {
        string Tipodeusuario { get; set; }
        string Email { get; set; }
        string Nombre { get; set; }

        string Permisos{ get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaUsuario
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; } //true = Ativo | false = Inativo
    }
}

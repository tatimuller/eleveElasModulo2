using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Membro
    {
        public string nome { get; set; }
        private long id { get; set; }

        internal void emprestarLivro()
        {

        }
        private string getInfoMembros()
        {
            return "Informações detalhadas";
        }

    }
}

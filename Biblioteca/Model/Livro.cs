using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Livro
    {
        public string Logradouro { get; set; }
        private string Autor { get; set; }
        protected string ISBN { get; set; }

        public String obterResumoLivro() {
            return "Resumo";
        }
    }
}

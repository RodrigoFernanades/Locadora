using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cadastro
{
    public class Atua
    {
        public string Papel { get; set; }
        public int AtorID { get; set; }
        public int FilmeID { get; set; }

        public Ator Ator { get; set; }
        public Filme Filme { get; set; }
    }
}

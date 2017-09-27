using Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tabela
{
    public class Genero
    {
        public int GeneroID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Filme> Filme { get; set; }
    }
}

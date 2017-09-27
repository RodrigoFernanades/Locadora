using Model.Tabela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cadastro
{
   public class Filme
    {
        public int FilmeID { get; set; }
        public string Nome { get; set; }

        public int CategoriaID { get; set; }
        public int GeneroID { get; set; }

        public Categoria Categoria { get; set; }
        public Genero Genero { get; set; }
        public virtual ICollection<Atua> Atua { get; set; }
    }
}

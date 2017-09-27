using Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tabela
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Filme> Filme { get; set; }
    }
}

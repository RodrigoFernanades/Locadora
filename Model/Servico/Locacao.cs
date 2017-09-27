using Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Servico
{
    public class Locacao
    {
        public int LocacaoID { get; set; }
        public DateTime DtLocacao { get; set; }
        public DateTime DtDevolucao { get; set; }
        public int FilmeID { get; set; }
        public int SocioID { get; set; }

        public virtual ICollection<Filme> Filme { get; set; }
        public Socio Socio { get; set; }
    }
}

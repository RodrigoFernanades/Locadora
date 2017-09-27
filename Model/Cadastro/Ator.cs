using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cadastro
{
   public class Ator
   {
        public string Nome { get; set; }
        
        public virtual ICollection<Atua> Atua{ get; set; }
   }
}

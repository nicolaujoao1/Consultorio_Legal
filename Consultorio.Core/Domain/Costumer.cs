using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Core.Domain
{
    public class Costumer:EntityBase
    {
       
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        //public Sexo Sexo { get; set; }
        //public ICollection<Telefone> Telefones { get; set; }
        //public string? Documento { get; set; }
        

        //public Endereco Endereco { get; set; }
    }
}

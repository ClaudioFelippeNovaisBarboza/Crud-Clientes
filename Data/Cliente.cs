using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Crud_Clientes.Data
{
    public class Cliente
    {
        public int Id { get; set; }

        public int id { get; set; }
        public string nome { get; set; }
        public int rg { get; set; }
        public long cpf { get; set; }
        public string sexo { get; set; }
        public DateTime nascimento { get; set; }
        public string nacionalidade { get; set; }
        public decimal altura { get; set; }
        public DateTime dataCadastro { get; set; }
        public string ativo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ferramenta : Produto
    {
        public const string INSERT = "INSERT INTO TB_FERRAMENTA (descricao, tipo, marca, preco) VALUES ('{0}', '{1}', '{2}', '{3}')";
        public const string GETALL = "SELECT id, descricao, tipo, marca, preco FROM TB_FERRAMENTA";
    }
}

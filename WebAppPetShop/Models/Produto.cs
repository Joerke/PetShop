using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPetShop.Models
{
    public class Produto
    {
        public int ProdutosId { get; set; }
        public Categoria Categoria { get; set; }
        public Pedido Pedidos { get; set; }
        public List<Produto> Produtos { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPetShop.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}
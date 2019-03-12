using System;
using System.Collections.Generic;
using MenuDigital.Domain;

namespace MenuDigital.Repository
{
    public class Repositorio : IRepository
    {
        public List<Item> GetItens() 
        {
            return new List<Item>() {
                new Item(){
                    Imagem = 2,
                    Preco = 230,
                    Nome = "Arroz",
                    Quantidade = 2
                }
              };
         }
    }
}

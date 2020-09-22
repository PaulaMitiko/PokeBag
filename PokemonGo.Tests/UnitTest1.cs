using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;

namespace PokemonGo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var util = new Utilitarios<Cidade>();
            var cidade = new Cidade() 
            {
                NomeCidade = "teste",
                Pais = "teste",
                QtdePokemons = 0
            };
            Assert.AreEqual(Message.SuccessAdd,util.AddCidade(cidade));
        }
    }
}

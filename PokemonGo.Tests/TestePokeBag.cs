using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;

namespace PokemonGo.Tests
{
    [TestClass]
    public class TestePokeBag
    {
        [TestMethod]
        public void Testar_Add()
        {
            var util = new Utilitarios<PokeDex>();
            var pokemon = new PokeDex()
            {
                Id = 3000,
                Name = "Teste",
                Type1 = "Bug",
                Type2 = "Grass",
                CandyForEvolution = 12,
                BuddyCandyKm = 3,
                CPMax = 1100,
                CPLvl35 = 850,
                QtdePokemon = 0
            };
            Assert.IsFalse(util.AddPokeDex(pokemon));
        }
    }
}

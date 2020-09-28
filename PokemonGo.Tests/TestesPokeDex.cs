using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;

namespace PokemonGo.Tests
{/*
    [TestClass]
    public class TestesPokeDex
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
        [TestMethod]
        public void Testar_Add_Repetido()
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
            Assert.IsTrue(util.AddPokeDex(pokemon));
        }
        [TestMethod]
        public void Testar_Add_Id0()
        {
            var util = new Utilitarios<PokeDex>();
            var pokemon = new PokeDex()
            {
                Id = 0,
                Name = "Teste",
                Type1 = "Bug",
                Type2 = "Grass",
                CandyForEvolution = 12,
                BuddyCandyKm = 3,
                CPMax = 1100,
                CPLvl35 = 850,
                QtdePokemon = 0
            };
            Assert.IsTrue(util.AddPokeDex(pokemon));
        }
        [TestMethod]
        public void Testar_Printar_Dex_Um()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.AreEqual(1, util.PrintPokeDex(3000).Count);
        }
        [TestMethod]
        public void Testar_Printar_Dex_Um_Falha()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.AreEqual(0, util.PrintPokeDex(3001).Count);
        }
        [TestMethod]
        public void Testar_Printar_Dex()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.AreNotEqual(0, util.PrintAllPokeDex());
        }
        [TestMethod]
        public void Testar_Printar_Dex_Tipo1_Sucesso()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.AreNotEqual(0, util.PrintPokeDexType("Bug").Count);
        }
        [TestMethod]
        public void Testar_Printar_Dex_Tipo2_Sucesso()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.AreNotEqual(0, util.PrintPokeDexType("Grass").Count);
        }
        [TestMethod]
        public void Testar_Printar_Dex_Tipo_Falha()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.AreEqual(0, util.PrintPokeDexType("Biruleibe").Count);
        }
        [TestMethod]
        public void Testar_Alterar_Egg()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.IsFalse(util.AlterarPokeDex(3000, 0, 0, 2));
        }
       [TestMethod]
        public void Testar_Alterar_CP()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.IsFalse(util.AlterarPokeDex(3000, 1101, 850, 0));
        }
        [TestMethod]
        public void Testar_Alterar_Falha()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.IsTrue(util.AlterarPokeDex(3000, 0, 0, 2));
        }
        [TestMethod]
        public void Testar_Alterar_Contagem()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.IsFalse(util.AlterarContagemPokemon(3000, 1));
        }
        [TestMethod]
        public void Testar_Alterar_Contagem_Falha()
        {
            var util = new Utilitarios<PokeDex>();
            Assert.IsTrue(util.AlterarContagemPokemon(3001, 3));
        }
    }*/
}

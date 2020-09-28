using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;
using System;
using System.Collections.Generic;

namespace PokemonGo.Tests
{
    [TestClass]
    public class TestePokeBag
    {
        [TestMethod]
        public void Testar_Add_Sucesso()
        {
            var util = new Utilitarios<PokeDex>();
            var pokemon = new PokemonBag()
            {
                IdPokemonType = 1,
                CombatPoints = 100,
                HealthPoints = 50,
                Attack = 10,
                Defense = 10,
                Stamina = 5,
                IdCidade = 8,
                DataCaptura = DateTime.Today,
                Shiny = false,
                Evento = "",
                Sombroso = "",
                DisponivelTroca = false,
                FastAttack = "Teste",
                ChargeAttack = "Eeste",
                Transferir = false
            };
            Assert.IsFalse(util.AddPokeBag(pokemon));
        }

        [TestMethod]
        public void Testar_Add_Falha()
        {
            var util = new Utilitarios<PokeDex>();
            var pokemon = new PokemonBag()
            {
                IdPokemonType = 3000,
                CombatPoints = 100,
                HealthPoints = 50,
                Attack = 10,
                Defense = 10,
                Stamina = 5,
                IdCidade = 1,
                DataCaptura = DateTime.Today,
                Shiny = false,
                Evento = "",
                Sombroso = "",
                DisponivelTroca = false,
                FastAttack = "Teste",
                ChargeAttack = "Eeste",
                Transferir = false
            };
            Assert.IsTrue(util.AddPokeBag(pokemon));
        }

        [TestMethod]
        public void Testar_PrintString_Sucesso()
        {
            var util = new Utilitarios<PokemonBagJoinDex>();
            Assert.AreNotEqual(0, util.PrintPokeBag("Bulbasaur").Count);
        }

        [TestMethod]
        public void Testar_PrintString_Falha()
        {
            var util = new Utilitarios<PokemonBagJoinDex>();
            Assert.AreEqual(0, util.PrintPokeBag("Biruleibe").Count);
        }

        [TestMethod]
        public void Testar_PrintInt_Sucesso()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.AreNotEqual(0, util.PrintPokeBag(1).Count);
        }

        [TestMethod]
        public void Testar_PrintInt_Falha()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.AreEqual(0, util.PrintPokeBag(3000).Count);
        }

        [TestMethod]
        public void Testar_PrintAll_Sucesso()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.AreNotEqual(0, util.PrintAllPokeBag().Count);
        }

        [TestMethod]
        public void Testar_PrintAllString_Sucesso()
        {
            var util = new Utilitarios<PokemonBagJoinDex>();
            Assert.AreNotEqual(0, util.PrintAllPokeBagJoin().Count);
        }

        [TestMethod]
        public void Testar_PrintCidade_Sucesso()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.AreNotEqual(0, util.PrintPokeBagCidade(8).Count);
        }

        [TestMethod]
        public void Testar_PrintCidade_Falha()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.AreEqual(0, util.PrintPokeBagCidade(1).Count);
        }

        [TestMethod]
        public void Testar_AlterarStats_Sucesso()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.IsFalse(util.AlterarPokeBag(50, 101, 51));
        }

        [TestMethod]
        public void Testar_AlterarStats_Falha1()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.IsTrue(util.AlterarPokeBag(50, 100, 50));
        }

        [TestMethod]
        public void Testar_AlterarStats_Falha2()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.IsTrue(util.AlterarPokeBag(1, 100, 50));
        }
        
        [TestMethod]
        public void Testar_PrintTransferir_Falha()
        {
            var util = new Utilitarios<PokemonBagJoinDex>();
            Assert.AreEqual(0, util.PrintPokeBagTransf().Count);
        }

        [TestMethod]
        public void Testar_AlterarTransferir_Sucesso()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.IsFalse(util.AlterarPokeBagTransferir(50, true));
        }

        [TestMethod]
        public void Testar_AlterarTransferir_Falha()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.IsTrue(util.AlterarPokeBagTransferir(1, true));
        }

        [TestMethod]
        public void Testar_PrintTransferir_Sucesso()
        {
            var util = new Utilitarios<PokemonBagJoinDex>();
            Assert.AreNotEqual(0, util.PrintPokeBagTransf().Count);
        }

        [TestMethod]
        public void Testar_PrintTrocar_Sucesso()
        {
            var util = new Utilitarios<PokemonBagJoinDex>();
            Assert.AreEqual(0, util.PrintPokeBagTroca().Count);
        }
        
        [TestMethod]
        public void Testar_Transferir_Sucesso()
        {
            var util = new Utilitarios<PokemonBag>();
            List<PokemonBag> aux = util.TransferirPokeBag(50);
            Assert.AreEqual(50, aux[0].Id);
        }

        [TestMethod]
        public void Testar_Transferir_Falha()
        {
            var util = new Utilitarios<PokemonBag>();
            Assert.AreEqual(0, util.TransferirPokeBag(48).Count);
        }
    }
}

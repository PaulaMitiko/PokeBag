using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonGo.Context.Models;
using PokemonGo.Context.Utilitarios;

namespace PokemonGo.Tests
{
    [TestClass]
    public class TestesCidade
    {
        [TestMethod]
        public void Testar_Add()
        {
            var util = new Utilitarios<Cidade>();
            var cidade = new Cidade() 
            {
                NomeCidade = "teste",
                Pais = "teste",
                QtdePokemons = 0
            };
            Assert.IsFalse(util.AddCidade(cidade));
        }
        [TestMethod]
        public void Testar_Add_Repetido()
        {
            var util = new Utilitarios<Cidade>();
            var cidade = new Cidade()
            {
                NomeCidade = "teste",
                Pais = "teste",
                QtdePokemons = 0
            };
            Assert.IsTrue(util.AddCidade(cidade));
        }

        [TestMethod]
        public void Testar_Pintar_Todos() 
        {
            var util = new Utilitarios<Cidade>();
            Assert.IsNotNull(util.PrintAllCidade());
        }

        [TestMethod]
        public void Testar_Pintar_Um_Sucesso() 
        {
            var util = new Utilitarios<Cidade>();
            Assert.AreNotEqual(0, util.PrintCidadeEspecifica(8));
        }

        [TestMethod]
        public void Testar_Pintar_Um_Falha() 
        {
            var util = new Utilitarios<Cidade>();
            Assert.AreEqual(0, util.PrintCidadeEspecifica(7).Count);
        }

        [TestMethod]
        public void Testar_Alterar_Sucesso()
        {
            var util = new Utilitarios<Cidade>();
            Assert.IsFalse(util.AlterarCidade(19, 1));
        }

        [TestMethod]
        public void Testar_Alterar_Falha()
        {
            var util = new Utilitarios<Cidade>();
            Assert.IsTrue(util.AlterarCidade(1, 1));
        }

        [TestMethod]
        public void Testar_Excluir_Sucesso() 
        {
            var util = new Utilitarios<Cidade>();
            Assert.IsFalse(util.ExcluirCidade(19));
        }

        [TestMethod]
        public void Testar_Excluir_Falha() 
        {
            var util = new Utilitarios<Cidade>();
            Assert.IsTrue(util.ExcluirCidade(1));
        }
    }
}

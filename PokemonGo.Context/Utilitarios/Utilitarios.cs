using PokemonGo.Context.Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace PokemonGo.Context.Utilitarios
{
    public class Utilitarios<T>
    {
        private PokemonGoContext meusPokemons;
        
        //########################//
        //ADICIONAR ITENS AO BANCO//
        //########################//

        public bool AddPokeBag(PokemonBag pokemon)
        {//Inserir um novo pokémon no banco - pokemonCapturado
            meusPokemons = new PokemonGoContext();
            using (meusPokemons) 
            {
                try
                {
                    meusPokemons.PokemonBag.Add(pokemon);
                    meusPokemons.SaveChanges();
                    return false;
                }
                catch 
                {
                    return true;
                }
            }
        }
        public bool AddPokeDex(PokeDex newType)
        {//Inserir nova espécie de pokémon no banco caso não seja repetido - pokemonNovo
            meusPokemons = new PokemonGoContext();
            using (meusPokemons)
            {
                var especieDuplicada = meusPokemons.PokeDex.FirstOrDefault(q => q.Id == newType.Id);
                if (newType.Id == 0) return true;
                else if (especieDuplicada is null)
                {
                    meusPokemons.PokeDex.Add(newType);
                    meusPokemons.SaveChanges();
                    return false;
                }
                else return true;
            }
        }
        public bool AddCidade(Cidade newCidade)
        {//Inserir nova cidade no banco caso não seja repetido - cadastrarCidade
            meusPokemons = new PokemonGoContext();
            using (meusPokemons)
            {
                var cidadeDuplicada = meusPokemons.Cidade.FirstOrDefault(q => q.NomeCidade == newCidade.NomeCidade);
                if (cidadeDuplicada is null)
                {
                    meusPokemons.Cidade.Add(newCidade);
                    meusPokemons.SaveChanges();
                    return false;
                }
                else return true;
            }
        }


        //##################//
        //PRINTAR ESPECÍFICO//
        //##################//
        public List<PokemonBag> PrintPokeBag(int especiePokemon)
        {//Listar todos os pokémons capturados de uma espécie - pokemonsDaBag
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokemonBag.Where(x => x.IdPokemonType.Equals(especiePokemon)).ToList();
            }
        }
        public List<PokemonBagJoinDex> PrintPokeBag(string especiePokemon)
        {//Listar todos os pokémons capturados de uma espécie - pokemonsDaBagstring
            meusPokemons = new PokemonGoContext();
            
            using (meusPokemons)
            {
                List<PokemonBagJoinDex> BagJoinDex = new List<PokemonBagJoinDex>();
                var Lists = (from PokeBag in meusPokemons.PokemonBag
                             join Dex in meusPokemons.PokeDex on PokeBag.IdPokemonType equals Dex.Id
                             join Cidade in meusPokemons.Cidade on PokeBag.IdCidade equals Cidade.Id
                             select new
                             {
                                 PokeBag.Id,
                                 Dex.Name,
                                 PokeBag.CombatPoints,
                                 PokeBag.HealthPoints,
                                 PokeBag.Attack,
                                 PokeBag.Defense,
                                 PokeBag.Stamina,
                                 Cidade.NomeCidade,
                                 PokeBag.DataCaptura,
                                 PokeBag.Shiny,
                                 PokeBag.Evento,
                                 PokeBag.Sombroso,
                                 PokeBag.DisponivelTroca,
                                 PokeBag.FastAttack,
                                 PokeBag.ChargeAttack,
                                 PokeBag.Transferir
                             }).ToList();
                foreach (var item in Lists) 
                {
                    PokemonBagJoinDex aux = new PokemonBagJoinDex();
                    if (item.Name == especiePokemon) 
                    {
                        aux.Id = item.Id;
                        aux.PokemonType = item.Name;
                        aux.CombatPoints = item.CombatPoints;
                        aux.HealthPoints = item.HealthPoints;
                        aux.Attack = item.Attack;
                        aux.Defense = item.Defense;
                        aux.Stamina = item.Stamina;
                        aux.NomeCidade = item.NomeCidade;
                        aux.DataCaptura = item.DataCaptura;
                        aux.Shiny = item.Shiny;
                        aux.Evento = item.Evento;
                        aux.Sombroso = item.Sombroso;
                        aux.DisponivelTroca = item.DisponivelTroca;
                        aux.FastAttack = item.FastAttack;
                        aux.ChargeAttack = item.ChargeAttack;
                        aux.Transferir = item.Transferir;

                        BagJoinDex.Add(aux);
                    }
                }
                return BagJoinDex;
            }
        }
        public List<PokemonBagJoinDex> PrintPokeBagTransf()
        {//Listar todos os pokémons que são para transferir - sugestaoTransferir
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                List<PokemonBagJoinDex> BagJoinDex = new List<PokemonBagJoinDex>();
                var Lists = (from PokeBag in meusPokemons.PokemonBag
                             join Dex in meusPokemons.PokeDex on PokeBag.IdPokemonType equals Dex.Id
                             join Cidade in meusPokemons.Cidade on PokeBag.IdCidade equals Cidade.Id
                             select new
                             {
                                 PokeBag.Id,
                                 Dex.Name,
                                 PokeBag.CombatPoints,
                                 PokeBag.HealthPoints,
                                 PokeBag.Attack,
                                 PokeBag.Defense,
                                 PokeBag.Stamina,
                                 Cidade.NomeCidade,
                                 PokeBag.DataCaptura,
                                 PokeBag.Shiny,
                                 PokeBag.Evento,
                                 PokeBag.Sombroso,
                                 PokeBag.DisponivelTroca,
                                 PokeBag.FastAttack,
                                 PokeBag.ChargeAttack,
                                 PokeBag.Transferir
                             }).ToList();
                foreach (var item in Lists)
                {
                    PokemonBagJoinDex aux = new PokemonBagJoinDex();
                    if (item.Transferir == true)
                    {
                        aux.Id = item.Id;
                        aux.PokemonType = item.Name;
                        aux.CombatPoints = item.CombatPoints;
                        aux.HealthPoints = item.HealthPoints;
                        aux.Attack = item.Attack;
                        aux.Defense = item.Defense;
                        aux.Stamina = item.Stamina;
                        aux.NomeCidade = item.NomeCidade;
                        aux.DataCaptura = item.DataCaptura;
                        aux.Shiny = item.Shiny;
                        aux.Evento = item.Evento;
                        aux.Sombroso = item.Sombroso;
                        aux.DisponivelTroca = item.DisponivelTroca;
                        aux.FastAttack = item.FastAttack;
                        aux.ChargeAttack = item.ChargeAttack;
                        aux.Transferir = item.Transferir;

                        BagJoinDex.Add(aux);
                    }
                }
                return BagJoinDex;
            }
        }
        public List<PokemonBagJoinDex> PrintPokeBagTroca()
        {//Listar todos os pokémons que são para trocar - sugestaoTroca
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                List<PokemonBagJoinDex> BagJoinDex = new List<PokemonBagJoinDex>();
                var Lists = (from PokeBag in meusPokemons.PokemonBag
                             join Dex in meusPokemons.PokeDex on PokeBag.IdPokemonType equals Dex.Id
                             join Cidade in meusPokemons.Cidade on PokeBag.IdCidade equals Cidade.Id
                             select new
                             {
                                 PokeBag.Id,
                                 Dex.Name,
                                 PokeBag.CombatPoints,
                                 PokeBag.HealthPoints,
                                 PokeBag.Attack,
                                 PokeBag.Defense,
                                 PokeBag.Stamina,
                                 Cidade.NomeCidade,
                                 PokeBag.DataCaptura,
                                 PokeBag.Shiny,
                                 PokeBag.Evento,
                                 PokeBag.Sombroso,
                                 PokeBag.DisponivelTroca,
                                 PokeBag.FastAttack,
                                 PokeBag.ChargeAttack,
                                 PokeBag.Transferir
                             }).ToList();
                foreach (var item in Lists)
                {
                    PokemonBagJoinDex aux = new PokemonBagJoinDex();
                    if (item.DisponivelTroca == true)
                    {
                        aux.Id = item.Id;
                        aux.PokemonType = item.Name;
                        aux.CombatPoints = item.CombatPoints;
                        aux.HealthPoints = item.HealthPoints;
                        aux.Attack = item.Attack;
                        aux.Defense = item.Defense;
                        aux.Stamina = item.Stamina;
                        aux.NomeCidade = item.NomeCidade;
                        aux.DataCaptura = item.DataCaptura;
                        aux.Shiny = item.Shiny;
                        aux.Evento = item.Evento;
                        aux.Sombroso = item.Sombroso;
                        aux.DisponivelTroca = item.DisponivelTroca;
                        aux.FastAttack = item.FastAttack;
                        aux.ChargeAttack = item.ChargeAttack;
                        aux.Transferir = item.Transferir;

                        BagJoinDex.Add(aux);
                    }
                }
                return BagJoinDex;
            }
        }
        public List<PokemonBag> PrintPokeBagCidade(int idCidade)
        {//Listar todos os pokémons capturados em uma cidade (auxiliar de outra tabela) - pokemonsPorCidade
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokemonBag.Where(x => x.IdCidade.Equals(idCidade)).ToList();
            }
        }
        public List<PokeDex> PrintPokeDex(int especiePokemon)
        {//Listar informações de uma espécie de pokémon - dexDeUmPokemon
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokeDex.Where(x => x.Id.Equals(especiePokemon)).ToList();
            }
        }
        public List<PokeDex> PrintPokeDexType(string tipoPokemon)
        {//Listar informações de todas as espécies de pokémon de um tipo específico - pokemonsPorTipo
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokeDex.Where(x => x.Type1.Equals(tipoPokemon)||x.Type2.Equals(tipoPokemon)).ToList();
            }
        }
        public List<Cidade> PrintCidadeEspecifica(int idCidade)
        {//Listar uma cidade do banco (aux para outras tabelas) - listarCidadeEspecifica
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.Cidade.Where(x => x.Id.Equals(idCidade)).ToList();
            }
        }


        //#############//
        //PRINTAR TODOS//
        //#############//
        public List<PokemonBag> PrintAllPokeBag()
        {//Listar informações de todos os pokémon do banco - todosPokemonsDaBag
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokemonBag.ToList();
            }
        }
        public List<PokemonBagJoinDex> PrintAllPokeBagJoin()
        {//Listar informações de todos os pokémon do banco - todosPokemonsDaBagJoin
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                List<PokemonBagJoinDex> BagJoinDex = new List<PokemonBagJoinDex>();
                var Lists = (from PokeBag in meusPokemons.PokemonBag
                             join Dex in meusPokemons.PokeDex on PokeBag.IdPokemonType equals Dex.Id
                             join Cidade in meusPokemons.Cidade on PokeBag.IdCidade equals Cidade.Id
                             select new
                             {
                                 PokeBag.Id,
                                 Dex.Name,
                                 PokeBag.CombatPoints,
                                 PokeBag.HealthPoints,
                                 PokeBag.Attack,
                                 PokeBag.Defense,
                                 PokeBag.Stamina,
                                 Cidade.NomeCidade,
                                 PokeBag.DataCaptura,
                                 PokeBag.Shiny,
                                 PokeBag.Evento,
                                 PokeBag.Sombroso,
                                 PokeBag.DisponivelTroca,
                                 PokeBag.FastAttack,
                                 PokeBag.ChargeAttack,
                                 PokeBag.Transferir
                             }).ToList();
                foreach (var item in Lists)
                {
                    PokemonBagJoinDex aux = new PokemonBagJoinDex();

                    aux.Id = item.Id;
                    aux.PokemonType = item.Name;
                    aux.CombatPoints = item.CombatPoints;
                    aux.HealthPoints = item.HealthPoints;
                    aux.Attack = item.Attack;
                    aux.Defense = item.Defense;
                    aux.Stamina = item.Stamina;
                    aux.NomeCidade = item.NomeCidade;
                    aux.DataCaptura = item.DataCaptura;
                    aux.Shiny = item.Shiny;
                    aux.Evento = item.Evento;
                    aux.Sombroso = item.Sombroso;
                    aux.DisponivelTroca = item.DisponivelTroca;
                    aux.FastAttack = item.FastAttack;
                    aux.ChargeAttack = item.ChargeAttack;
                    aux.Transferir = item.Transferir;

                    BagJoinDex.Add(aux);
                
                }
                return BagJoinDex;
            }
        }
        public List<PokeDex> PrintAllPokeDex()
        {//Listar informações de todas espécies de pokémon do banco - todosPokemonsDaDex
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokeDex.ToList();
            }
        }
        public List<Cidade> PrintAllCidade()
        {//Listar todas as cidades do banco - listarCidades
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.Cidade.ToList();
            }
        }


        //##################//
        //EXCLUIR UM POKEMON//
        //##################//
        public List<PokemonBag> TransferirPokeBag(int idPokemon)
        {//Excluir um pokémon do banco caso exista - pokemonTransferido
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemonTransferido = meusPokemons.PokemonBag.FirstOrDefault(q => q.Id == idPokemon);
                List<PokemonBag> aux = new List<PokemonBag>();

                if (pokemonTransferido != null)
                {
                    aux.Add(pokemonTransferido);
                    meusPokemons.PokemonBag.Remove(pokemonTransferido);
                    meusPokemons.SaveChanges();
                }
                return aux;
            }
        }
        public bool ExcluirCidade(int idCidade)
        {//Excluir uma cidade do banco caso exista - excluirCidade
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var cidadeExcluida = meusPokemons.Cidade.FirstOrDefault(q => q.Id == idCidade);

                if (cidadeExcluida != null)
                {
                    meusPokemons.Cidade.Remove(cidadeExcluida);
                    meusPokemons.SaveChanges();
                    return false;
                }
                else
                    return true;
            }
        }

        //#############//
        //ALTERAR STATS//
        //#############//
        public bool AlterarPokeBag(int idPokemon, int novoCP, int novoHP)
        {//Alterar informações de um pokémon - alterarStats
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemon = meusPokemons.PokemonBag.FirstOrDefault(q => q.Id == idPokemon);

                if (pokemon != null)
                {
                    if (novoCP >= pokemon.CombatPoints && novoHP >= pokemon.HealthPoints)
                    {
                        pokemon.CombatPoints = novoCP;
                        pokemon.HealthPoints = novoHP;
                        meusPokemons.SaveChanges();
                        return false;
                    }
                    else return true;
                }
                else
                    return true;
            }
        }
        public bool AlterarPokeBagTransferir(int idPokemon, bool novoStatus)
        {//Alteraro status de transferir de um pokémon - alterarTransferir
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemon = meusPokemons.PokemonBag.FirstOrDefault(q => q.Id == idPokemon);

                if (pokemon != null)
                {
                    pokemon.Transferir = novoStatus;
                    meusPokemons.SaveChanges();
                    return false;
                }
                else
                    return true;
            }
        }
        public bool AlterarPokeDex(int idPokemon, int novoCP, int novoLvl35, int novoEgg)
        {//Alterar informações de uma espécie de pokémon - alterarDados
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemon = meusPokemons.PokeDex.FirstOrDefault(q => q.Id == idPokemon);

                if (pokemon != null)
                {
                    if (novoCP != 0 && novoLvl35 != 0)
                    {
                        pokemon.CPMax = novoCP;
                        pokemon.CPLvl35 = novoLvl35;
                    }
                    else if (pokemon.EggKm != novoEgg)
                    {
                        pokemon.EggKm = novoEgg;
                    }
                    else if (novoCP == 0 || novoLvl35 == 0) 
                    {
                        return true;
                    }
                    
                    meusPokemons.SaveChanges();
                    return false;
                }
                else
                    return true;
            }
        }
        public bool AlterarContagemPokemon(int idPokemon, int novaContagem)
        {//Alterar contagem de uma espécie de pokémon (auxiliar para outras tabelas) - atualizarContagem
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemon = meusPokemons.PokeDex.FirstOrDefault(q => q.Id == idPokemon);

                if (pokemon != null)
                {
                    pokemon.QtdePokemon = novaContagem;
                    meusPokemons.SaveChanges();
                    return false;
                }
                else
                    return true;
            }
        }
        public bool AlterarCidade(int idCidade, int novaContagem)
        {//Alterar contagem da cidade (aux para outras tabelas) - atualizarContagem
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var cidade = meusPokemons.Cidade.FirstOrDefault(q => q.Id == idCidade);

                if (cidade != null)
                {
                    cidade.QtdePokemons = novaContagem;
                    meusPokemons.SaveChanges();
                    return false;
                }
                else
                    return true;
            }
        }
    }
}

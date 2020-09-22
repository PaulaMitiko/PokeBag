using PokemonGo.Context.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonGo.Context.Utilitarios
{
    public class Utilitarios<T>
    {
        private PokemonGoContext meusPokemons;
        //########################//
        //ADICIONAR ITENS AO BANCO//
        //########################//
        public void AddPokeBag(PokemonBag pokemon)
        {
            meusPokemons = new PokemonGoContext();
            using (meusPokemons) 
            {
                meusPokemons.PokemonBag.Add(pokemon);
                meusPokemons.SaveChanges();
            }
        }
        public void AddPokeDex(PokeDex newType)
        {
            meusPokemons = new PokemonGoContext();
            using (meusPokemons)
            {
                meusPokemons.PokeDex.Add(newType);
                meusPokemons.SaveChanges();
            }
        }
        public string AddCidade(Cidade newCidade)
        {
            meusPokemons = new PokemonGoContext();
            using (meusPokemons)
            {
                var cidadeDuplicada = meusPokemons.Cidade.FirstOrDefault(q => q.NomeCidade == newCidade.NomeCidade);
                if (cidadeDuplicada is null)
                {
                    meusPokemons.Cidade.Add(newCidade);
                    meusPokemons.SaveChanges();
                    return Message.SuccessAdd;
                }
                else return Message.NoSuccess;
            }
        }
        //##################//
        //PRINTAR ESPECÍFICO//
        //##################//
        public List<PokemonBag> PrintPokeBag(int especiePokemon) //Testado - OK
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokemonBag.Where(x => x.IdPokemonType.Equals(especiePokemon)).ToList();
            }
        }
        public List<PokemonBagJoinDex> PrintPokeBag(string especiePokemon) //Testado - OK
        {
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

        public List<PokemonBagJoinDex> PrintPokeBagTransf() //Testado - OK
        {
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

        public List<PokemonBagJoinDex> PrintPokeBagTroca() //Testado - OK
        {
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

        public List<PokemonBag> PrintPokeBagCidade(int idCidade) //Testado - OK
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokemonBag.Where(x => x.IdCidade.Equals(idCidade)).ToList();
            }
        }
        public List<PokeDex> PrintPokeDex(int especiePokemon) 
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokeDex.Where(x => x.Id.Equals(especiePokemon)).ToList();
            }
        }

        public List<PokeDex> PrintPokeDexType(string tipoPokemon)
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokeDex.Where(x => x.Type1.Equals(tipoPokemon)||x.Type2.Equals(tipoPokemon)).ToList();
            }
        }

        public List<Cidade> PrintCidadeEspecifica(int idCidade)
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.Cidade.Where(x => x.Id.Equals(idCidade)).ToList();
            }
        }
        //#############//
        //PRINTAR TODOS//
        //#############//
        public List<PokemonBag> PrintAllPokeBag() //Testado - Ok
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokemonBag.ToList();
            }
        }
        public List<PokemonBagJoinDex> PrintAllPokeBagJoin() //Testado - Ok
        {
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
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.PokeDex.ToList();
            }
        }
        public List<Cidade> PrintAllCidade()
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                return meusPokemons.Cidade.ToList();
            }
        }

        //##################//
        //EXCLUIR UM POKEMON//
        //##################//
        public List<PokemonBag> TransferirPokeBag(int idPokemon) //Funcionando
        {
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
        public string ExcluirCidade(int idCidade) 
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var cidadeExcluida = meusPokemons.Cidade.FirstOrDefault(q => q.Id == idCidade);

                if (cidadeExcluida != null)
                {
                    meusPokemons.Cidade.Remove(cidadeExcluida);
                    meusPokemons.SaveChanges();
                    return Message.SuccessTransferir;
                }
                else
                    return Message.NoSuccessTransferir;
            }
        }

        //#############//
        //ALTERAR STATS//
        //#############//
        public string AlterarPokeBag(int idPokemon, int novoCP, int novoHP) //Funcionando
        {
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
                        return Message.SuccessAlter;
                    }
                    else return Message.NoSuccessAlter;
                }
                else
                    return Message.NoSuccessAlter;
            }
        }

        public string AlterarPokeBagTransferir(int idPokemon, bool novoStatus) //Funcionando
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemon = meusPokemons.PokemonBag.FirstOrDefault(q => q.Id == idPokemon);

                if (pokemon != null)
                {
                    pokemon.Transferir = novoStatus;
                    meusPokemons.SaveChanges();
                    return Message.SuccessAlter;
                }
                else
                    return Message.NoSuccessAlter;
            }
        }

        public string AlterarPokeDex(int idPokemon, int novoCP, int novoLvl35, int novoEgg)
        {
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
                    if (pokemon.EggKm != novoEgg)
                    {
                        pokemon.EggKm = novoEgg;
                    }
                    else if (novoCP == 0 || novoLvl35 == 0) 
                    {
                        return Message.NoSuccessAlter;
                    }
                    
                    meusPokemons.SaveChanges();
                    return Message.SuccessAlter;
                }
                else
                    return Message.NoSuccessAlter;
            }
        }

        public string AlterarContagemPokemon(int idPokemon, int novaContagem)
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var pokemon = meusPokemons.PokeDex.FirstOrDefault(q => q.Id == idPokemon);

                if (pokemon != null)
                {
                    pokemon.QtdePokemon = novaContagem;
                    meusPokemons.SaveChanges();
                    return Message.SuccessAlter;
                }
                else
                    return Message.NoSuccessAlter;
            }
        }

        public string AlterarCidade(int idCidade, int novaContagem)
        {
            meusPokemons = new PokemonGoContext();

            using (meusPokemons)
            {
                var cidade = meusPokemons.Cidade.FirstOrDefault(q => q.Id == idCidade);

                if (cidade != null)
                {
                    cidade.QtdePokemons = novaContagem;
                    meusPokemons.SaveChanges();
                    return Message.SuccessAlter;
                }
                else
                    return Message.NoSuccessAlter;
            }
        }
    }
}

using System;

namespace PokeBag_API
{
    public class Message
    {
        public static string Success => "Aqui os seus pokémons :D";
        public static string SuccessType => "Aqui os seus pokémons da espécis desejada :D";
        public static string NoPokemonType => "Você ainda não capturou nenhum pokémon dessa espécie :(";
        public static string NoPokemon => "Você ainda não capturou nenhum pokémon :(";
        public static string NoSuccess => "Deu ruim... :(";
        public static string NoSuccessTransferir => "Pokémon desejado não encontrado :(";
        public static string SuccessTransferir => "Pokémon transferido com sucesso!";
    }
}

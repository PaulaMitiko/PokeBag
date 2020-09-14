using System;

namespace PokeBag_API
{
    public class Message
    {
        public static string Success => "Aqui os seus pok�mons :D";
        public static string SuccessType => "Aqui os seus pok�mons da esp�cis desejada :D";
        public static string NoPokemonType => "Voc� ainda n�o capturou nenhum pok�mon dessa esp�cie :(";
        public static string NoPokemon => "Voc� ainda n�o capturou nenhum pok�mon :(";
        public static string NoSuccess => "Deu ruim... :(";
        public static string NoSuccessTransferir => "Pok�mon desejado n�o encontrado :(";
        public static string SuccessTransferir => "Pok�mon transferido com sucesso!";
    }
}

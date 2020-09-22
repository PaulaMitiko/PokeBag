namespace PokemonGo.Context.Utilitarios
{
    public class Message
    {
        //MENSAGENS DE SUCESSO
        public static string Success => "Aqui os seus pokémons! :D";
        public static string SuccessCity => "Aqui as suas cidades! :D";
        public static string SuccessAdd => "Adicionado com sucesso!! :D";
        public static string SuccessType => "Aqui os seus pokémons da espécis desejada :D";
        public static string SuccessTransferir => "Pokémon transferido com sucesso!";
        public static string SuccessTransferCity => "Cidade excluída com sucesso!";
        public static string SuccessAlter => "Stats alterados :D";
        public static string SuccessCount => "Contagem atualizada! :D";

        //MENSAGENS DE ERRO
        public static string NoSuccess => "Alguma coisa deu ruim... :(";
        public static string NoSuccessAdd => "A inserção deu ruim... :(";
        public static string NoPokemon => "Você ainda não capturou nenhum pokémon :(";
        public static string NoCity => "Você ainda não cadastrou nenhuma cidade :(";
        public static string NoOneCity => "Você ainda não cadastrou essa cidade :(";
        public static string NoPokemonType => "Você ainda não capturou nenhum pokémon dessa espécie :(";
        //public static string NoPokemonCity => "Você ainda não capturou nenhum pokémon nesta cidade :(";
        public static string NoSuccessTransferir => "Pokémon desejado não encontrado :(";
        public static string NoTransferCity => "Cidade desejada não encontrada :(";
        public static string NoSuccessAlter => "Stats não foram alterados :(";
    }
}

namespace PokemonGo.Context.Utilitarios
{
    public class Message
    {
        //MENSAGENS DE SUCESSO
        public static string Success => "Aqui os seus pokémons! :D";
        public static string SuccessCity => "Aqui as suas cidades! :D"; //Ok, não mudar mais
        public static string SuccessAdd => "Adicionado com sucesso!! :D"; //ok, não mudar mais
        public static string SuccessType => "Aqui os seus pokémons da espécie desejada :D"; //ok na pokedex
        public static string SuccessTransferir => "Pokémon transferido com sucesso!";
        public static string SuccessTransferCity => "Cidade excluída com sucesso!"; //ok, não mudar mais
        public static string SuccessAlter => "As informações foram alteradas! :D"; //ok pokedex
        public static string SuccessCount => "Contagem atualizada! :D"; //ok, não mudar mais 

        //MENSAGENS DE ERRO
        public static string NoSuccess => "Alguma coisa deu ruim... :("; //ok, não mudar mais 
        public static string NoSuccessAdd => "A inserção deu ruim... :("; //falta usar na pokebag
        public static string NoPokemon => "Você ainda não registrou nenhum pokémon :("; //Ok pokedex, falta pokebag
        public static string NoPokemonTypes => "Você ainda não registrou nenhum pokémon desse tipo:("; //ok, não mudar mais 
        public static string NoCity => "Você ainda não cadastrou nenhuma cidade :("; //ok, não mudar mais 
        public static string NoOneCity => "Você ainda não cadastrou essa cidade :("; //ok, não mudar mais 
        public static string NoPokemonType => "Você ainda não capturou nenhum pokémon dessa espécie :(";
        public static string NoPokemonSpecie => "Você ainda não registrou este pokémon na sua PokeDex :("; //ok, não mudar mais 
        //public static string NoPokemonCity => "Você ainda não capturou nenhum pokémon nesta cidade :(";
        public static string NoSuccessTransferir => "Pokémon desejado não encontrado :(";
        public static string NoTransferCity => "Cidade desejada não encontrada :("; //ok, não mudar mais 
        public static string NoSuccessAlter => "As infos não foram alteradas :("; //ok pokedex 
    }
}

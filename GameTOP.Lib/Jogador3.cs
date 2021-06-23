using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string chuta()
        {
           return "Está chutando \n";
        }

        public string corre()
        {
           return "Está correndo \n";
        }

        public string passe()
        {
           return "Está passando \n";
        }
    }
}
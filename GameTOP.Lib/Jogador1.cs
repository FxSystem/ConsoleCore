using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 :iJogador
    {
        public readonly string _Nome ;  

        public Jogador1(string Nome = "Ronaldo")
        {
            _Nome = Nome;
        }


        public string chuta()
        {
            return $"{_Nome} está chutando \n";
        }

        public string passe ()
        {
            return $"{_Nome} está passando \n";
            
        }

        public string corre()
        {
            return $"{_Nome} está correndo \n";            
        }

    
    
    }
}
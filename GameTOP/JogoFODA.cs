using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {

        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;

        private readonly iJogador _jogador3;
        public JogoFODA(iJogador jogador1,iJogador jogador2, iJogador jogador3)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
            _jogador3 = jogador3;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogador1.chuta());
            System.Console.Write(_jogador1.corre());
            System.Console.Write(_jogador1.passe());

            System.Console.Write("\n Proximo Jogador \n");


             System.Console.Write(_jogador2.chuta());
             System.Console.Write(_jogador2.corre());
             System.Console.Write(_jogador2.passe());


                System.Console.Write("\n Proximo Jogador \n");

                 
            System.Console.Write(_jogador3.chuta());
            System.Console.Write(_jogador3.corre());
            System.Console.Write(_jogador3.passe());




        }
    
    }
}
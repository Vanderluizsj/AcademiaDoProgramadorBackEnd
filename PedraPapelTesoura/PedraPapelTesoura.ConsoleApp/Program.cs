using PedraPapelTesoura.ConsoleApp.entidades;

do
{   
    //0. Start Game
    StartGame.Start();

    //1. escolha jogador
    int escolhaDoJogador = Jogador.ObterEscolha();

    //2. escolha computador
    int escolhaDoComputador = Computador.ObterEscolha();    

    //3. vencedor
    RegrasDoJogo.ValidaJogada(escolhaDoJogador, escolhaDoComputador);    

} while (!StartGame.Continuar());
using ShowDoMilhaoSarah;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;
    public Gerenciador (Label LabelPerg, Button btResposta01, Button btResposta02, Button btResposta03,Button btResposta04, Button btResposta05)
    {
        CriarPerguntas (LabelPerg,btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
    }    
    void CriarPerguntas (Label labelPergunta, Button btResposta01, Button btResposta02,Button btResposta03,Button btResposta04, Button btResposta05)
    {
        var Questao01 = new Questao ();
        Questao01.Nivel = 1;
        Questao01.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao01.pergunta = "Quem descobriu o Brasil?";
        Questao01.resposta1 = "Neymar";
        Questao01.resposta2 = "Pedro Álvares Cabral";
        Questao01.resposta3 = "Napoleão Bonaparte";
        Questao01.resposta4 = "Jair Bolsonaro";
        Questao01.resposta5 = "Thiago Macedo";
        Questao01.respostacorreta = 2;
        ListaQuestoes.Add (Questao01);
        ProximaQuestao();

        var Questao02 = new Questao ();
        Questao02.Nivel = 1;
        Questao02.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao02.pergunta = "Qual é a montanha mais alta do mundo?";
        Questao02.resposta1 = "Monte Kilimanjaro";
        Questao02.resposta2 = "Aconcágua";
        Questao02.resposta3 = "Monte Everest";
        Questao02.resposta4 = "K2";
        Questao02.resposta5 = "Monte McKinley";
        Questao02.respostacorreta = 3;
        ListaQuestoes.Add (Questao02);
        ProximaQuestao();

        var Questao03 = new Questao ();
        Questao03.Nivel = 1;
        Questao03.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao03.pergunta = " Quem é conhecido como o Pai da Psicanálise?";
        Questao03.resposta1 = "Sigmund Freud";
        Questao02.resposta2 = "Ivan Pavlov";
        Questao02.resposta3 = "Erik Erikson";
        Questao02.resposta4 = "Carl Jung";
        Questao02.resposta5 = "Alfred Adler";
        Questao03.respostacorreta = 1;
        ListaQuestoes.Add (Questao03);
        ProximaQuestao();


    }
    void ProximaQuestao()
    {
        var NumAleat = Random.Shared.Next(0,ListaQuestoes.Count);
        while(ListaQuestoesRespondidas.Contains(NumAleat))
        NumAleat=Random.Shared.Next(0, ListaQuestoesRespondidas.Count);
        ListaQuestoesRespondidas.Add(NumAleat);
        QuestaoCorrente=ListaQuestoes[NumAleat];
        QuestaoCorrente.desenhar();
    }
    public int Pontuacao {get; private set;}
    int NivelAtual = 0;
    void Inicializar()
    {
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }
    public async void VerificaResposta (int RR)
    {
        if (QuestaoCorrente.VerificaResposta(RR))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual++;
            ProximaQuestao();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert ("GAME OVER", "VOCÊ ERROU", "OK");
            Inicializar();
        }
    }
    void AdicionaPontuacao(int n)
    {
         if (n==1)
         Pontuacao=1000;
         else if (n==2)
         Pontuacao = 2000;
         else if (n==3)
         Pontuacao = 5000;
         else if (n==4)
         Pontuacao = 10000;
         else if (n==5)
         Pontuacao = 20000;
         else if (n==6)
         Pontuacao = 50000;
         else if (n==7)
         Pontuacao = 100000;
         else if (n==8)
         Pontuacao = 200000;
         else if (n==9)
         Pontuacao = 500000;
         else
         Pontuacao = 1000000;
    }
}
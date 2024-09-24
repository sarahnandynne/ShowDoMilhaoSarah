using ShowDoMilhaoSarah;

public class Gerenciador
{
    Label labelPontuacao;
    Label labelNivel;
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;
    public Gerenciador(Label LabelPerg, Button btResposta01, Button btResposta02, Button btResposta03, Button btResposta04, Button btResposta05, Label labelPontuacao, Label labelNivel)
    {
        CriarPerguntas(LabelPerg, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;
    }
    void CriarPerguntas(Label labelPergunta, Button btResposta01, Button btResposta02, Button btResposta03, Button btResposta04, Button btResposta05)
    {
        var Questao01 = new Questao();
        Questao01.Nivel = 1;
        Questao01.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao01.pergunta = "Quem descobriu o Brasil?";
        Questao01.resposta1 = "Neymar";
        Questao01.resposta2 = "Pedro Álvares Cabral";
        Questao01.resposta3 = "Napoleão Bonaparte";
        Questao01.resposta4 = "Jair Bolsonaro";
        Questao01.resposta5 = "Thiago Macedo";
        Questao01.respostacorreta = 2;
        ListaQuestoes.Add(Questao01);

        var Questao02 = new Questao();
        Questao02.Nivel = 1;
        Questao02.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao02.pergunta = "Qual é a montanha mais alta do mundo?";
        Questao02.resposta1 = "Monte Kilimanjaro";
        Questao02.resposta2 = "Aconcágua";
        Questao02.resposta3 = "Monte Everest";
        Questao02.resposta4 = "K2";
        Questao02.resposta5 = "Monte McKinley";
        Questao02.respostacorreta = 3;
        ListaQuestoes.Add(Questao02);

        var Questao03 = new Questao();
        Questao03.Nivel = 1;
        Questao03.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao03.pergunta = " Quem é conhecido como o Pai da Psicanálise?";
        Questao03.resposta1 = "Sigmund Freud";
        Questao03.resposta2 = "Ivan Pavlov";
        Questao03.resposta3 = "Erik Erikson";
        Questao03.resposta4 = "Carl Jung";
        Questao03.resposta5 = "Alfred Adler";
        Questao03.respostacorreta = 1;
        ListaQuestoes.Add(Questao03);

        var Questao04 = new Questao();
        Questao04.Nivel = 1;
        Questao04.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao04.pergunta = "Quem pintou a Mona Lisa?";
        Questao04.resposta1 = "Vincent van Gogh";
        Questao04.resposta2 = "Pablo Picasso";
        Questao04.resposta3 = "Leonardo da Vinci";
        Questao04.resposta4 = "Claude Monet";
        Questao04.resposta5 = "Salvador Dalí";
        Questao04.respostacorreta = 3;
        ListaQuestoes.Add(Questao04);

        var Questao05 = new Questao();
        Questao05.Nivel = 1;
        Questao05.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao05.pergunta = "Qual é a fórmula química da água?";
        Questao05.resposta1 = "H2O";
        Questao05.resposta2 = "CO2";
        Questao05.resposta3 = "O2";
        Questao05.resposta4 = "H2O2";
        Questao05.resposta5 = "CH4";
        Questao05.respostacorreta = 1;
        ListaQuestoes.Add(Questao05);

        var Questao06 = new Questao();
        Questao06.Nivel = 1;
        Questao06.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao06.pergunta = "Qual é o continente onde está localizado o Egito?";
        Questao06.resposta1 = "Ásia";
        Questao06.resposta2 = "América";
        Questao06.resposta3 = "África";
        Questao06.resposta4 = "Europa";
        Questao06.resposta5 = "Oceania";
        Questao06.respostacorreta = 3;
        ListaQuestoes.Add(Questao06);

        var Questao07 = new Questao();
        Questao07.Nivel = 1;
        Questao07.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao07.pergunta = "Qual é a moeda do Japão?";
        Questao07.resposta1 = "Yuan";
        Questao07.resposta2 = "Won";
        Questao07.resposta3 = "Dólar";
        Questao07.resposta4 = "Iene";
        Questao07.resposta5 = "Rupia";
        Questao07.respostacorreta = 4;
        ListaQuestoes.Add(Questao07);

        var Questao08 = new Questao();
        Questao08.Nivel = 1;
        Questao08.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao08.pergunta = "Quem é conhecido como o 'Rei do Pop'?";
        Questao08.resposta1 = "Elvis Presley";
        Questao08.resposta2 = "Michael Jackson";
        Questao08.resposta3 = "Prince";
        Questao08.resposta4 = "David Bowie";
        Questao08.resposta5 = "Freddie Mercury";
        Questao08.respostacorreta = 2;
        ListaQuestoes.Add(Questao08);

        var Questao09 = new Questao();
        Questao09.Nivel = 1;
        Questao09.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao09.pergunta = "Qual é o órgão responsável por bombear o sangue no corpo humano?";
        Questao09.resposta1 = "Fígado";
        Questao09.resposta2 = "Coração";
        Questao09.resposta3 = "Pulmão";
        Questao09.resposta4 = "Rim";
        Questao09.resposta5 = "Estômago";
        Questao09.respostacorreta = 2;
        ListaQuestoes.Add(Questao09);

        var Questao10 = new Questao();
        Questao10.Nivel = 1;
        Questao10.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao10.pergunta = "Qual é a língua oficial do Brasil?";
        Questao10.resposta1 = "Espanhol";
        Questao10.resposta2 = "Inglês";
        Questao10.resposta3 = "Francês";
        Questao10.resposta4 = "Português";
        Questao10.resposta5 = "Italiano";
        Questao10.respostacorreta = 4;
        ListaQuestoes.Add(Questao10);

        var Questao11 = new Questao();
        Questao11.Nivel = 2;
        Questao11.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao11.pergunta = "Qual é o nome do famoso cientista que formulou a teoria da relatividade?";
        Questao11.resposta1 = "Isaac Newton";
        Questao11.resposta2 = "Albert Einstein";
        Questao11.resposta3 = "Galileu Galilei";
        Questao11.resposta4 = "Nikola Tesla";
        Questao11.resposta5 = "Stephen Hawking";
        Questao11.respostacorreta = 2;
        ListaQuestoes.Add(Questao11);

        var Questao12 = new Questao();
        Questao12.Nivel = 2;
        Questao12.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao12.pergunta = "Qual é o maior oceano do mundo?";
        Questao12.resposta1 = "Oceano Atlântico";
        Questao12.resposta2 = "Oceano Índico";
        Questao12.resposta3 = "Oceano Pacífico";
        Questao12.resposta4 = "Oceano Ártico";
        Questao12.resposta5 = "Oceano Antártico";
        Questao12.respostacorreta = 3;
        ListaQuestoes.Add(Questao12);

        var Questao13 = new Questao();
        Questao13.Nivel = 2;
        Questao13.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao13.pergunta = "Qual é a capital da Itália?";
        Questao13.resposta1 = "Roma";
        Questao13.resposta2 = "Milão";
        Questao13.resposta3 = "Nápoles";
        Questao13.resposta4 = "Florença";
        Questao13.resposta5 = "Veneza";
        Questao13.respostacorreta = 1;
        ListaQuestoes.Add(Questao13);

        var Questao14 = new Questao();
        Questao14.Nivel = 2;
        Questao14.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao14.pergunta = "Qual é o planeta mais próximo do sol?";
        Questao14.resposta1 = "Terra";
        Questao14.resposta2 = "Marte";
        Questao14.resposta3 = "Mercúrio";
        Questao14.resposta4 = "Vênus";
        Questao14.resposta5 = "Júpiter";
        Questao14.respostacorreta = 3;
        ListaQuestoes.Add(Questao14);

        var Questao15 = new Questao();
        Questao15.Nivel = 2;
        Questao15.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao15.pergunta = "Qual é o maior planeta do sistema solar?";
        Questao15.resposta1 = "Terra";
        Questao15.resposta2 = "Marte";
        Questao15.resposta3 = "Júpiter";
        Questao15.resposta4 = "Saturno";
        Questao15.resposta5 = "Vênus";
        Questao15.respostacorreta = 3;
        ListaQuestoes.Add(Questao15);

        var Questao16 = new Questao();
        Questao16.Nivel = 2;
        Questao16.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao16.pergunta = "Qual é a capital da França?";
        Questao16.resposta1 = "Berlim";
        Questao16.resposta2 = "Madrid";
        Questao16.resposta3 = "Paris";
        Questao16.resposta4 = "Roma";
        Questao16.resposta5 = "Lisboa";
        Questao16.respostacorreta = 3;
        ListaQuestoes.Add(Questao16);

        var Questao17 = new Questao();
        Questao17.Nivel = 2;
        Questao17.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao17.pergunta = "Quem escreveu 'Dom Casmurro'?";
        Questao17.resposta1 = "Machado de Assis";
        Questao17.resposta2 = "José de Alencar";
        Questao17.resposta3 = "Joaquim Manuel de Macedo";
        Questao17.resposta4 = "Clarice Lispector";
        Questao17.resposta5 = "Carlos Drummond de Andrade";
        Questao17.respostacorreta = 1;
        ListaQuestoes.Add(Questao17);

        var Questao18 = new Questao();
        Questao18.Nivel = 2;
        Questao18.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao18.pergunta = "Qual é o elemento químico representado pela letra 'O'?";
        Questao18.resposta1 = "Ouro";
        Questao18.resposta2 = "Oxigênio";
        Questao18.resposta3 = "Ósmio";
        Questao18.resposta4 = "Oganessônio";
        Questao18.resposta5 = "Prata";
        Questao18.respostacorreta = 2;
        ListaQuestoes.Add(Questao18);

        var Questao19 = new Questao();
        Questao19.Nivel = 2;
        Questao19.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao19.pergunta = "Qual é o maior deserto do mundo?";
        Questao19.resposta1 = "Deserto do Saara";
        Questao19.resposta2 = "Deserto da Antártida";
        Questao19.resposta3 = "Deserto de Gobi";
        Questao19.resposta4 = "Deserto da Arábia";
        Questao19.resposta5 = "Deserto de Kalahari";
        Questao19.respostacorreta = 2;
        ListaQuestoes.Add(Questao19);

        var Questao20 = new Questao();
        Questao20.Nivel = 2;
        Questao20.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao20.pergunta = "Quem pintou 'A Última Ceia'?";
        Questao20.resposta1 = "Michelangelo";
        Questao20.resposta2 = "Leonardo da Vinci";
        Questao20.resposta3 = "Raphael";
        Questao20.resposta4 = "Van Gogh";
        Questao20.resposta5 = "Monet";
        Questao20.respostacorreta = 2;
        ListaQuestoes.Add(Questao20);

        var Questao21 = new Questao();
        Questao21.Nivel = 2;
        Questao21.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao21.pergunta = "Qual é o maior planeta do sistema solar?";
        Questao21.resposta1 = "Terra";
        Questao21.resposta2 = "Marte";
        Questao21.resposta3 = "Júpiter";
        Questao21.resposta4 = "Saturno";
        Questao21.resposta5 = "Vênus";
        Questao21.respostacorreta = 3;
        ListaQuestoes.Add(Questao21);

        var Questao22 = new Questao();
        Questao22.Nivel = 2;
        Questao22.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao22.pergunta = "Quem é o autor de 'O Alquimista'?";
        Questao22.resposta1 = "J.K. Rowling";
        Questao22.resposta2 = "Paulo Coelho";
        Questao22.resposta3 = "Gabriel García Márquez";
        Questao22.resposta4 = "Ernest Hemingway";
        Questao22.resposta5 = "F. Scott Fitzgerald";
        Questao22.respostacorreta = 2;
        ListaQuestoes.Add(Questao22);

        var Questao23 = new Questao();
        Questao23.Nivel = 2;
        Questao23.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao23.pergunta = "Qual é a capital da Austrália?";
        Questao23.resposta1 = "Sydney";
        Questao23.resposta2 = "Melbourne";
        Questao23.resposta3 = "Canberra";
        Questao23.resposta4 = "Brisbane";
        Questao23.resposta5 = "Perth";
        Questao23.respostacorreta = 3;
        ListaQuestoes.Add(Questao23);

        var Questao24 = new Questao();
        Questao24.Nivel = 2;
        Questao24.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao24.pergunta = "Qual é o maior oceano do mundo?";
        Questao24.resposta1 = "Oceano Atlântico";
        Questao24.resposta2 = "Oceano Índico";
        Questao24.resposta3 = "Oceano Pacífico";
        Questao24.resposta4 = "Oceano Ártico";
        Questao24.resposta5 = "Oceano Antártico";
        Questao18.respostacorreta = 3;
        ListaQuestoes.Add(Questao24);

        var Questao25 = new Questao();
        Questao25.Nivel = 2;
        Questao25.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao25.pergunta = "Qual é o símbolo químico do ouro?";
        Questao25.resposta1 = "Au";
        Questao25.resposta2 = "Ag";
        Questao25.resposta3 = "Pb";
        Questao25.resposta4 = "Fe";
        Questao25.resposta5 = "Hg";
        Questao25.respostacorreta = 1;
        ListaQuestoes.Add(Questao25);

        var Questao26 = new Questao();
        Questao26.Nivel = 2;
        Questao26.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao26.pergunta = "Qual é a língua oficial do Brasil?";
        Questao26.resposta1 = "Espanhol";
        Questao26.resposta2 = "Português";
        Questao26.resposta3 = "Inglês";
        Questao26.resposta4 = "Francês";
        Questao26.resposta5 = "Italiano";
        Questao26.respostacorreta = 2;
        ListaQuestoes.Add(Questao26);

        var Questao21 = new Questao();
        Questao21.Nivel = 2;
        Questao21.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao21.pergunta = "Quem pintou a obra 'Guernica'?";
        Questao21.resposta1 = "Pablo Picasso";
        Questao21.resposta2 = "Vincent van Gogh";
        Questao21.resposta3 = "Salvador Dalí";
        Questao21.resposta4 = "Claude Monet";
        Questao21.resposta5 = "Henri Matisse";
        Questao21.respostacorreta = 1;
        ListaQuestoes.Add(Questao21);

        var Questao22 = new Questao();
        Questao22.Nivel = 2;
        Questao22.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao22.pergunta = "Qual é a montanha mais alta do mundo?";
        Questao22.resposta1 = "K2";
        Questao22.resposta2 = "Kilimanjaro";
        Questao22.resposta3 = "Monte Everest";
        Questao22.resposta4 = "Makalu";
        Questao22.resposta5 = "Lhotse";
        Questao22.respostacorreta = 3;
        ListaQuestoes.Add(Questao22);

        var Questao23 = new Questao();
        Questao23.Nivel = 2;
        Questao23.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao23.pergunta = "Qual é o famoso monumento em Paris?";
        Questao23.resposta1 = "Torre Eiffel";
        Questao23.resposta2 = "Coliseu";
        Questao23.resposta3 = "Big Ben";
        Questao23.resposta4 = "Estátua da Liberdade";
        Questao23.resposta5 = "Cristo Redentor";
        Questao23.respostacorreta = 1;
        ListaQuestoes.Add(Questao23);

        var Questao24 = new Questao();
        Questao24.Nivel = 2;
        Questao24.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao24.pergunta = "Qual é o maior mamífero do mundo?";
        Questao24.resposta1 = "Elefante";
        Questao24.resposta2 = "Baleia Azul";
        Questao24.resposta3 = "Girafa";
        Questao24.resposta4 = "Hipopótamo";
        Questao24.resposta5 = "Orca";
        Questao24.respostacorreta = 2;
        ListaQuestoes.Add(Questao24);






        ProximaQuestao();
    }
    void ProximaQuestao()
    {
        var NumAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(NumAleat))
            NumAleat = Random.Shared.Next(0, ListaQuestoesRespondidas.Count);
        ListaQuestoesRespondidas.Add(NumAleat);
        QuestaoCorrente = ListaQuestoes[NumAleat];
        QuestaoCorrente.desenhar();
    }
    public int Pontuacao { get; private set; }
    int NivelAtual = 0;
    void Inicializar()
    {
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }
    public async void VerificaResposta(int RR)
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
            await App.Current.MainPage.DisplayAlert("GAME OVER", "VOCÊ ERROU", "OK");
            Inicializar();
        }
        labelPontuacao.Text = "Pontuação: R$" + Pontuacao.ToString();
        labelNivel.Text = "Nível:" + NivelAtual.ToString();

    }
    void AdicionaPontuacao(int n)
    {
        if (n == 1)
            Pontuacao = 1000;
        else if (n == 2)
            Pontuacao = 2000;
        else if (n == 3)
            Pontuacao = 5000;
        else if (n == 4)
            Pontuacao = 10000;
        else if (n == 5)
            Pontuacao = 20000;
        else if (n == 6)
            Pontuacao = 50000;
        else if (n == 7)
            Pontuacao = 100000;
        else if (n == 8)
            Pontuacao = 200000;
        else if (n == 9)
            Pontuacao = 500000;
        else
            Pontuacao = 1000000;
    }
}
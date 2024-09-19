public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;
    public Gerenciador (Label LabelPerg, Button btResposta01, Button btResposta02, Button btResposta03,Button btResposta04, Button btResposta05)
    {
        CriarPerguntas (LabelPerg,btResposta01, btResposta02, btResposta03, btResposta04, btResposta05); 
    }    
public async void VerificaResposta(int RR)
{
    if (QuestaoCorrente.VerificaResposta(RR))
    {
        await Task.Delay (1000);
        ProximaQuestao();
    }
}
    void ProximaQuestao()
    {
        var NumAlet.Random.Shared.Next(0,ListaQuestoes.Count);
        while(ListaQuestoesRespondidas.Countrins(NumAlet))
        NumAlet=Random.Shared.Next(0, ListaQuestoesRespondidas.Count);
        ListaQuestoesRespondidas.Add(NumAlet);
        QuestaoCorrente=ListaQuestoes[NumAlet];
        QuestaoCorrente.desenhar();
    }
}
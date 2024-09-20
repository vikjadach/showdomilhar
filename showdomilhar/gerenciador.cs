namespace Showdomilhar
{
    public class Gerenciador
    {
        List<questao> ListaQuestao = new List<questao>();
        List<int> ListasQuestaoRespomdidas = new List<int>();

        questao QuestaoAtual;
        public Gerenciador(Label per, Button bot1, Button bot2, Button bot3, Button bot4, Button bot5)
        {
            CriarPergunta(per, bot1, bot2, bot3, bot4, bot5);
        }

        void CriarPergunta(Label per, Button bot1, Button but2, Button bot3, Button bot4, Button bot5)
        {
            var Q1 = new questao();
            Q1.Questao = "quanto è 15+15";
            Q1.resposta1 ="1";
            Q1.resposta2 ="16";
            Q1.resposta3 ="1515";
            Q1.resposta4 ="30";
            Q1.resposta5 ="2001";
            Q1.respostaC = 4 ;
            ListaQuestao.Add(Q1);
            ProximaQuestao();
        }

        void ProximaQuestao()
        {
            var NumAlert =Random.Shared.Next(0,ListaQuestao);
            while(ListasQuestaoRespondidas.Contains(NumAlert));
            ListasQuestaoRespondidas.Add(NumAlert);
            QuestaoAtual=ListaQuestao[NumAlert];
            QuestaoAtual.desenhar();
        }

    }
}
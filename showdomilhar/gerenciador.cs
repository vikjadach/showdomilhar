namespace showdomilhar;


    public class gerenciador
    
    {
        List<Questao> ListaQuestao = new List<Questao>();
        List<int> ListasQuestaoRespondidas = new List<int>();

        Questao QuestaoAtual;
        Label labelPontuacao;
        Label labelNivel;
        public gerenciador(Label labelPontuacao,Label labelnivel, Button buttonrep1,Button buttonrep2,Button buttonrep3,Button buttonrep4,Button buttonrep5)
        {
            this.labelPontuacao = labelPontuacao;
            this.labelNivel = babelNivel;
            CriarPergunta(labelPontuacao,labelnivel,buttonrep1,buttonrep2,buttonrep3,buttonrep4,buttonrep5);
        }

        void CriarPergunta(Label labelPontuacao,Label labelnivel, Button buttonrep1, Button buttonrep2, Button buttonrep3, Button buttonrep4, Button buttonrep5)
        {
            var Q1 = new questao();
            Q1.ConfiguraDesenho(labelPergunta,buttonrep1,buttonrep2,buttonrep3,buttonrep4,buttonrep5);
            Q1.questaoi = "Quanto é 40+30?";
            Q1.resposta1 = "1";
            Q1.resposta2 = "16";
            Q1.resposta3 = "60";
            Q1.resposta5 = "70";
            Q1.RespostaC = 5;
            ListaQuestao.Add(Q1);
            ProximaQuestao();
        }

        void ProximaQuestao()
        {
            var NumAlert =Random.Shared.Next(0,ListaQuestao.Count);
            while(ListasQuestaoRespondidas.Contains(NumAlert));
            NumAlert=Random.Shared.Next(0,ListaQuestao.Count);
            ListasQuestaoRespondidas.Add(NumAlert);
            QuestaoAtual=ListaQuestao[NumAlert];
            QuestaoAtual.desenhar;

        }
        public int Pontuação{get;private set;}
        int NivelAtual = 0;
        void Inicializar()
        {
            Pontuação = 0;
            NivelAtual = 1;
            ProximaQuestao();
        }

        public async void verificaCorreta(int rr)
        {
            if(QuestaoCorreta.EstaCorreto (rr))
            {
                await Task.Delay(1000);
                AdicionarPontuacao(NivelAtual);
                NivelAtual++;
                ProximaQuestao();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Fim","Incorreto","ok");
                Inicializar();
            }
            LabelPontuacao.Text="Pontuação: R$"+ labelPontuacao.ToString();
            labelNivel.Text="Nivel:"+NivelAtual.ToString();
        }
        void AdicionarPontuacao(int n)
        {
            if (n==1)
                Pontuação=1000;
            else if (n==2)
                Pontuação=2000;
            else if(n==3)
                Pontuação=5000;
            else if (n==4)
                Pontuação=10000;
            else if (n==5)
                Pontuação=20000;
            else if (n==6)
                Pontuação=50000;
            else if (n==7)
                Pontuação=100000;
            else if (n==8)
                Pontuação=200000;


        }
        
    }




namespace showdomilhar;

public partial class MainPage : ContentPage
{
  Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
    gerenciador = new Gerenciador (labelPergunta, labelPontuacao,labelnivel, buttonrep1, buttonrep2, buttonrep3, buttonrep4, buttonrep5);
	}

  private void OnBtnResposta01Clicked(object sender, EventArgs e)
  {
    gerenciador.VerificaCorreto(1);
  }

  private void OnBtnResposta02Clicked(object sender, EventArgs e)
  {
    gerenciador.VerificaCorreto(2);
  }

  private void OnBtnResposta03Clicked(object sender, EventArgs e)
  {
    gerenciador.VerificaCorreto(3);
  }

  private void OnBtnResposta04Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(4);
  }

  private void OnBtnResposta05Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(5);
  }
}



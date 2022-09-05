namespace src.Models;

public class Contract
{
    public Contract()
    {
        DataCriacao = DateTime.Now;
        Valor = 0;
        IdToken = "000000";
        Pago = false;
    }

    public Contract(string idToken, double valor)
    {
        DataCriacao = DateTime.Now;
        IdToken = idToken;
        Valor = valor;
        Pago = false;
    }

    public int Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public string IdToken { get; set; }
    public double Valor { get; set; }
    public bool Pago { get; set; }
    public int PessoaId { get; set; }
}
using System.Collections.Generic;

namespace src.Models;

public class Person
{
    public Person()
    {
        this.Nome = "template";
        this.Idade = 0;
        this.Contratos = new List<Contract>();
    }

    public Person(string nome, int idade, string cpf)
    {
        Nome = nome;
        Idade = idade;
        Cpf = cpf;
        this.Contratos = new List<Contract>();
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string? Cpf { get; set; }
    public bool Ativado { get; set; }

    public List<Contract> Contratos { get; set; }
}
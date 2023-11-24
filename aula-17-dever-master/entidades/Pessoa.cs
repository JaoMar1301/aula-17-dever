using System;
//Atributos
class Pessoa
{
    public string? Nome;
    public string? Sobrenome;
    public DateTime DataNascimento;
    public int CPF;
    public decimal Peso;
    public decimal Altura;
//construtor 
public Pessoa (string? nome, string? sobrenome, DateTime datanascimento, int cpf, decimal peso, decimal altura)
{
        Nome = nome;
        Sobrenome = sobrenome;
        DataNascimento = datanascimento;
        CPF = cpf;
        Peso = peso;
        Altura = altura;
        
}


//Metodos
    public int CalculaIdade()
    {
        DateTime dataAtual = DateTime.Now;
        int idade = dataAtual.Year - DataNascimento.Year;
        return idade;
    }

    public decimal CalculaIMC()
    {
        decimal peso = (decimal)Peso;
        decimal altura = Altura;

        decimal imc = peso / (altura * altura);

        return imc;
    }

    public bool Maioridade()
    {
        int idade = CalculaIdade();
        return idade >=18; 

    }
}
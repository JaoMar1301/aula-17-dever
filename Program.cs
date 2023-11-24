using System.Security.Authentication;

Console.WriteLine("digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine("digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

Console.WriteLine("digite seu cpf: ");
int.TryParse(Console.ReadLine(), out int cpf);

Console.WriteLine("digite seu data de nascimento no formto dd/mm/aa: ");
DateTime.TryParse(Console.ReadLine(), out DateTime datanascimento);

Console.WriteLine("digite seu peso: ");
decimal.TryParse(Console.ReadLine(), out decimal peso);

Console.WriteLine("digite sua altura: ");
decimal.TryParse(Console.ReadLine(), out decimal altura);

Pessoa p = new Pessoa(nome, sobrenome, datanascimento, cpf, peso, altura);

int idade = p.CalculaIdade();

decimal imc = Math.Round(p.CalculaIMC(),2);


bool sair = false;

while (!sair)
{
    Console.WriteLine("=====================================================");
    Console.WriteLine("escolha uma das opções abaixo!");
    Console.WriteLine("0 - informações do usuario");
    Console.WriteLine("1 - Calcular IMC");
    Console.WriteLine("2 - Verifica a maior idade do usuario");
    Console.WriteLine("3 - Calculadora");
    Console.WriteLine("4 - Calcular novo IMC");
    Console.WriteLine("5 - Sair");

    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "0":
            Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
            Console.WriteLine($"Data de Nascimento: {datanascimento}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Idade: {idade}");
            break;

        case "1":
        Console.WriteLine($"Seu IMC é {imc}");
        
            if (imc >=16 && imc <= 17)
            {
                Console.WriteLine("Você está muito abaixo do seu peso ideal!?");
            }
           else if (imc >=17 && imc <= 18)
            {
                Console.WriteLine("Você está abaixo do seu peso ideal!");
            }
          else if (imc >=19 && imc <= 25)
            {
                Console.WriteLine("Você está no seu pesso ideal!");
            }
           else if (imc >=26 && imc <= 35)
            {
                Console.WriteLine("Você esta com obesidade I");
            }
           else if (imc >=36 && imc <= 39)
            {
                Console.WriteLine("Você esta com obesidade II");
            }
           else  if (imc <= 40)
            {
                Console.WriteLine("Você esta com obesidade III");
            } 
            break;

        case "2":
            if (idade >= 18)
            {
                Console.WriteLine($"olá {nome}, parabend você tem {idade} já é Mair de idade");
            }
            else
                Console.WriteLine($"olá {nome}, você é Menor de Idade por ter apenas {idade} anos de idade");
            break;
        
        case "3":
        Calcular c = new Calcular();
        Console.WriteLine("Digite o primeiro valor");
        c.Numero1 = float.Parse(Console.ReadLine());
                      
        Console.WriteLine("Digite o segundo valor");
        c.Numero2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Qual será o calculo a ser efetuado?");
        Console.WriteLine("   |+ = soma");
        Console.WriteLine("   |- =");
        Console.WriteLine("   |/ = divisão");
        Console.WriteLine("   |* = multiplicação");

        string? operacao = Console.ReadLine();

        float resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = c.Soma();
                break;

                case "-":
                    resultado = c.Subtracao();
                break;
                    
                case "/":
                    resultado = c.Divisao();
                break;

                case "*":
                    resultado = c.Multuplicação();
                break;

                default:
                Console.WriteLine($"Opção invalida");
                break;
            }
            
            Console.WriteLine($"Resultado:{resultado}");
        break;

        case "4":
                Console.WriteLine($"Digite seu peso:");
                decimal.TryParse(Console.ReadLine(), out decimal peso2);

                Console.WriteLine($"Digite sua altuta(use a virgula):");
                decimal.TryParse(Console.ReadLine(), out decimal altura2);

                CalcularIMC ci = new CalcularIMC(peso2, altura2);

                decimal IMC2 = ci.calculoIMC2();
        
            Console.WriteLine($"Seu IMC é {IMC2}");

            if (imc >=16 && imc <= 17)
            {
                Console.WriteLine("Você está muito abaixo do seu peso ideal!?");
            }
           else if (imc >=17 && imc <= 18)
            {
                Console.WriteLine("Você está abaixo do seu peso ideal!");
            }
          else if (imc >=19 && imc <= 25)
            {
                Console.WriteLine("Você está no seu pesso ideal!");
            }
           else if (imc >=26 && imc <= 35)
            {
                Console.WriteLine("Você esta com obesidade I");
            }
           else if (imc >=36 && imc <= 39)
            {
                Console.WriteLine("Você esta com obesidade II");
            }
           else  if (imc <= 40)
            {
                Console.WriteLine("Você esta com obesidade III");
            }
        break;

        case "5":
            sair = true;
            break;
    }
}
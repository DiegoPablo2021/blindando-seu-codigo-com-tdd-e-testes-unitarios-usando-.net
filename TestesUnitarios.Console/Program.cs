using TestesUnitarios.Console;

Calculadora calc = new Calculadora(DateTime.Now.ToString());

int num1 = 0;
int num2 = 0;
bool num1Valido = true;
bool num2Valido = true;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    num1 = 0;
    num2 = 0;
    num1Valido = true; num2Valido = true;
    Console.WriteLine("Calculadora:");
    Console.WriteLine("Funções: Somar, Subtrair, Multiplicar, Dividir e Listar Histórico (3 últimas ações do histórico).");
    Console.WriteLine("Selecione uma das opções logo abaixo:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Histórico");
    Console.WriteLine("6 - Encerrar");


    switch (Console.ReadLine())
    {
        case "1":
            RecebeDados();
            if (num1Valido && num2Valido)
            {
                Console.WriteLine($"Resultado: {calc.Somar(num1, num2)}");
            }
            break;

        case "2":
            RecebeDados();
            if (num1Valido && num2Valido)
            {
                Console.WriteLine($"Resultado: {calc.Subtrair(num1, num2)}");
            }
            break;

        case "3":
            RecebeDados();
            if (num1Valido && num2Valido)
            {
                Console.WriteLine($"Resultado: {calc.Multiplicar(num1, num2)}");
            }
            break;

        case "4":
            RecebeDados();
            if (num1Valido && num2Valido)
            {
                if (num2 != 0)
                {
                    Console.WriteLine($"Resultado: {calc.Dividir(num1, num2)}");
                }
                else
                {
                    Console.WriteLine($"Resultado: Não é possível dividir por 0!");
                }
            }
            break;
        case "5":
            List<string> list = calc.Historico();
            list.ForEach(x =>
                Console.WriteLine(x));
            break;
        case "6":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadLine();
}

void RecebeDados()
{
    Console.WriteLine("Informe o primeiro número:");
    num1Valido = int.TryParse(Console.ReadLine(), out num1);
    if (num1Valido)
    {
        Console.WriteLine("Informe o segundo número:");
        num2Valido = int.TryParse(Console.ReadLine(), out num2);
        if (!num2Valido)
        {
            Console.WriteLine("número inválido");
        }
    }
}

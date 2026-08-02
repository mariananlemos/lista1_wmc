// 1. Soma de dois números
    // Solicite dois números inteiros e exiba a soma.
    static void Exercicio01()
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine()!);

        int soma = numero1 + numero2;
        Console.WriteLine("A soma é " + soma + ".");
    }

    // 2. Antecessor e sucessor
    // Leia um número inteiro e mostre o antecessor, o número informado e o sucessor.
    static void Exercicio02()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Antecessor: " + (numero - 1));
        Console.WriteLine("Número informado: " + numero);
        Console.WriteLine("Sucessor: " + (numero + 1));
    }

    // 3. Área de um retângulo
    // Solicite base e altura e calcule área e perímetro.
    static void Exercicio03()
    {
        Console.Write("Digite a base: ");
        double baseRetangulo = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a altura: ");
        double altura = double.Parse(Console.ReadLine()!);

        double area = baseRetangulo * altura;
        double perimetro = 2 * (baseRetangulo + altura);

        Console.WriteLine("Área: " + area);
        Console.WriteLine("Perímetro: " + perimetro);
    }

    // 4. Conversor de moedas
    // Leia um valor em reais e a cotação do dólar.
    static void Exercicio04()
    {
        Console.Write("Digite o valor em reais: ");
        double reais = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a cotação do dólar: ");
        double cotacaoDolar = double.Parse(Console.ReadLine()!);

        double dolares = reais / cotacaoDolar;
        Console.WriteLine("Esse valor em dólares é: US$ " + dolares.ToString("F2"));
    }

    // 5. Calculadora simples
    // Solicite dois números e mostre soma, subtração, multiplicação e divisão.
    static void Exercicio05()
    {
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Soma: " + (numero1 + numero2));
        Console.WriteLine("Subtração: " + (numero1 - numero2));
        Console.WriteLine("Multiplicação: " + (numero1 * numero2));

        if (numero2 != 0)
        {
            Console.WriteLine("Divisão: " + (numero1 / numero2));
        }
        else
        {
            Console.WriteLine("Divisão: não é possível dividir por zero.");
        }
    }

    // 6. Contagem crescente
    // Mostre os números de 1 até 100.
    static void Exercicio06()
    {
        for (int numero = 1; numero <= 100; numero++)
        {
            Console.WriteLine(numero);
        }
    }

    // 7. Contagem regressiva
    // Mostre os números de 50 até 1.
    static void Exercicio07()
    {
        for (int numero = 50; numero >= 1; numero--)
        {
            Console.WriteLine(numero);
        }
    }

    // 8. Tabuada
    // Solicite um número e exiba sua tabuada de 1 a 10.
    static void Exercicio08()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()!);

        for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
        {
            Console.WriteLine(numero + " x " + multiplicador + " = " + (numero * multiplicador));
        }
    }

    // 9. Soma dos números pares
    // Calcule a soma de todos os números pares entre 1 e 100.
    static void Exercicio09()
    {
        int soma = 0;

        for (int numero = 1; numero <= 100; numero++)
        {
            if (numero % 2 == 0)
            {
                soma += numero;
            }
        }

        Console.WriteLine("A soma dos números pares entre 1 e 100 é: " + soma);
    }

    // 10. Login simples
    // Solicite usuário e senha. Enquanto a senha estiver incorreta, peça novamente.
    static void Exercicio10()
    {
        string usuarioCorreto = "aluna";
        string senhaCorreta = "1234";

        Console.Write("Digite o usuário: ");
        string usuario = Console.ReadLine() ?? "";

        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine() ?? "";

        while (senha != senhaCorreta)
        {
            Console.WriteLine("Senha incorreta. Tente novamente.");
            Console.Write("Digite a senha: ");
            senha = Console.ReadLine() ?? "";
        }

        if (usuario == usuarioCorreto)
        {
            Console.WriteLine("Login realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Senha correta, mas usuário diferente do esperado.");
        }
    }

    // 11. Soma até digitar zero
    // Leia números inteiros. Quando o usuário digitar zero, encerre mostrando a soma.
    static void Exercicio11()
    {
        int soma = 0;
        int numero = 1;

        while (numero != 0)
        {
            Console.Write("Digite um número (0 para parar): ");
            numero = int.Parse(Console.ReadLine()!);
            soma += numero;
        }

        Console.WriteLine("A soma dos números digitados é: " + soma);
    }

    // 12. Contador de caracteres
    // Leia um nome e informe quantos caracteres ele possui.
    static void Exercicio12()
    {
        Console.Write("Digite um nome: ");
        string nome = Console.ReadLine() ?? "";

        Console.WriteLine("O nome tem " + nome.Length + " caracteres.");
    }

    // 13. Verificador de senha
    // Solicite uma senha e informe se ela possui pelo menos 8 caracteres.
    static void Exercicio13()
    {
        Console.Write("Digite uma senha: ");
        string senha = Console.ReadLine() ?? "";

        if (senha.Length >= 8)
        {
            Console.WriteLine("A senha tem pelo menos 8 caracteres.");
        }
        else
        {
            Console.WriteLine("A senha tem menos de 8 caracteres.");
        }
    }

    // 14. Maior elemento
    // Leia 10 números e informe o maior valor e a posição em que ele aparece.
    static void Exercicio14()
    {
        int maiorValor = int.MinValue;
        int posicaoMaior = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero > maiorValor)
            {
                maiorValor = numero;
                posicaoMaior = i + 1;
            }
        }

        Console.WriteLine("Maior valor: " + maiorValor);
        Console.WriteLine("Posição: " + posicaoMaior);
    }

    // 15. Média de um vetor
    // Leia 8 notas e calcule a média.
    static void Exercicio15()
    {
        double soma = 0;

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Digite a " + (i + 1) + "ª nota: ");
            double nota = double.Parse(Console.ReadLine()!);
            soma += nota;
        }

        double media = soma / 8;
        Console.WriteLine("A média é: " + media.ToString("F2"));
    }

    // 16. Contagem de pares
    // Leia 20 números e informe quantos são pares.
    static void Exercicio16()
    {
        int contagemPares = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero % 2 == 0)
            {
                contagemPares++;
            }
        }

        Console.WriteLine("Quantidade de números pares: " + contagemPares);
    }

    // 17. Ordem inversa
    // Leia 10 números e exiba-os na ordem inversa.
    static void Exercicio17()
    {
        int[] numeros = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Números na ordem inversa:");
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }

    // 18. Jogo da senha
    // Gere um número aleatório entre 1 e 100 e informe se o número digitado é maior ou menor.
    static void Exercicio18()
    {
        Random random = new Random();
        int numeroSorteado = random.Next(1, 101);
        int tentativa = 0;

        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        while (tentativa != numeroSorteado)
        {
            Console.Write("Digite um número: ");
            tentativa = int.Parse(Console.ReadLine()!);

            if (tentativa < numeroSorteado)
            {
                Console.WriteLine("O número sorteado é maior.");
            }
            else if (tentativa > numeroSorteado)
            {
                Console.WriteLine("O número sorteado é menor.");
            }
            else
            {
                Console.WriteLine("Parabéns, você acertou!");
            }
        }
    }

    // 19. Caixa eletrônico
    // Solicite um valor para saque e informe quantas notas serão entregues.
    static void Exercicio19()
    {
        int valorSaque = 0;
        int[] notas = { 100, 50, 20, 10, 5, 2 };

        Console.Write("Digite o valor do saque: ");
        valorSaque = int.Parse(Console.ReadLine()!);

        foreach (int nota in notas)
        {
            int quantidadeNotas = valorSaque / nota;
            valorSaque %= nota;
            Console.WriteLine("Notas de R$" + nota + ": " + quantidadeNotas);
        }
    }
}

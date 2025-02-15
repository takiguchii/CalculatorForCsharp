class Calculadora
{
    public static double Somar(double a, double b){
        return a + b;
    }

    public static double Subtrair(double a, double b){
        return a - b;
    }

    public static double Multiplicar(double a, double b){
        return a * b;
    }

    public static double Dividir(double a, double b){
        return a / b;
    }
    public static void Main(){
        Console.Write("Calculadora iniciada...");
        Console.Write("Digite o primeiro valor:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escolha a operação (+, -, *, /): ");
        string operacao = Console.ReadLine();

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        if (operacao == "+"){
            resultado = Somar(num1, num2);
        }
        else if (operacao == "-"){
            resultado = Subtrair(num1, num2);
        }
        else if (operacao == "*"){
            resultado = Multiplicar(num1, num2);
        }
        else if (operacao == "/"){
            resultado = Dividir(num1, num2);
        }
        else{
            Console.WriteLine("Operação inválida!");
            return;
        }
        Console.WriteLine($"Resultado: {resultado}");


    }
}    
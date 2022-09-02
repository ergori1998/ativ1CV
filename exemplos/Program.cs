internal class Program
{
    private static void Main(string[] args)
    {
	//alteração realizada por Érgori
<<<<<<< HEAD
	//alteração refeita por Érgori
=======
	//outra alteração realizada por Érgori
>>>>>>> branch1
        Console.WriteLine("Digite seu ano de nascimento:");
        int anoN = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ano de nascimento = " + (anoN));
        int idade = 2022 - anoN;
        Console.WriteLine($"Idade = " + (idade));
        if(idade >= 16)
            Console.WriteLine("Voto permitido!");
        else if(idade < 0)
            Console.WriteLine("Erro: digite um número válido!");
        else
            Console.WriteLine("Sem direito ao voto!");    

    }
}
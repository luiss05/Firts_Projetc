using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Você prefere beber pinga ou morar na bct? ");
        string resposta = Convert.ToString(Console.ReadLine());
        if (resposta == "prefiro morar na bct e sair pra beber pinga"  )
        {
            Console.WriteLine("A MLK DOIDO");
        }
        else
        {
            Console.WriteLine("paia");
        }
        Console.ReadKey();
    }
}
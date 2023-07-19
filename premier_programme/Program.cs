using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, quel est ton nom ? ");
        string nom = Console.ReadLine();

        int age_num = 0;

        while (age_num > 0) 
        {
            Console.Write("Tu as quel âge ? ");
            string age_str = Console.ReadLine();

            try
            {
                age_num = int.Parse(age_str);
            }
            catch
            {
                Console.WriteLine("Erreur, vous devez entrer un age valide.");
            }

            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age_num + " ans");

            int age_prochain = age_num + 1;
            Console.WriteLine("Vous aurez bientôt " + age_prochain + " ans");
        }
    }
}
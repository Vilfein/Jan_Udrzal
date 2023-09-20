namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MojeDatabase DB = new MojeDatabase();

            DB.PridatZaznam(new Osoba("Vašek", 33));
            DB.PridatZaznam(new Osoba("Jonáš", 3));
            DB.PridatZaznam(new Osoba("Lucie", 18));

            //DB.Vyhledej("Lucie");

            DB.Vypis();
            DB.PridatZaznam(new Osoba("Marek", 44));

        }
    }
}
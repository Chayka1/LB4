namespace Lab4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = "";
            ApplicationLicense applicationLicense;
            Console.WriteLine("Введіть ключ пробного режиму чи платного: ");
            applicationLicense = new ApplicationLicense(Console.ReadLine());
        }
    }
}
namespace MyPlaylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MasterClas mas = new MasterClas(38, "Giuliano", "12345678");
            Console.WriteLine("Dni actual antes de setear nuevo: "+ mas.getDni());
            Console.WriteLine(mas.getEdad());
            mas.setDni("44069663");
            Console.WriteLine("Nuevo Dni : "+mas.getDni());
            Console.WriteLine(mas.getNombreCompleto());
            
        }
    }
}

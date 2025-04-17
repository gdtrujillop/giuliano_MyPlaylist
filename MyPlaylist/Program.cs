namespace MyPlaylist
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Postulante pos = new Postulante();
            pos.Experiencias();

            Gato miau= new Gato();
            Console.WriteLine(miau.contarPares());
            miau.PeliPrincipal();    
            Console.WriteLine(miau.CalculoNota(18));

             /*MasterClas mas = new MasterClas(38, "Giuliano", "12345678","didier1402@gmail.com");
             Console.WriteLine("Dni actual antes de setear nuevo: "+ mas.Dni);
             Console.WriteLine(mas.Edad);
             mas.Dni = "44069663";
             Console.WriteLine("Nuevo Dni : "+mas.Dni);
             Console.WriteLine(mas.NombreCompleto);*/

            /*Song song1 = new Song("Bohemian Rhapsody", "Queen", "A Night at the Opera", "Rock");
            Console.WriteLine("Album: " + song1.Album);

            Song song2 = new Song("Por si tratas de volvr", "Libido", "Noche clara", "Rock");
            Console.WriteLine("Genero: " + song2.Genre);
            //song2.Genre.ToHashSet
            song2.Genre = "Soft Rock";
            Console.WriteLine("Genero: " + song2.Genre);*/
        }
    }
}

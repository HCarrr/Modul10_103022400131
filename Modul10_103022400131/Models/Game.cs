namespace Modul10_103022400131.Models
{
    public class Game
    {
        public string nama { get; set; }
        public string developer { get; set; }
        public int tahunRilis { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
        public List<string> platform { get; set; }
        public List<string> mode { get; set; }
        public bool isOnline { get; set; }
        public int harga { get; set; }
    }

}

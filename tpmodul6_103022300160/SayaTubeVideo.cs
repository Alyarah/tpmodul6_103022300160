using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300160
{
    class SayaTubeVideo
    {
        private int id ;
        private string title;
        private int playCount;
        private string v;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.playCount = playCount;

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
        }

        public void IncreasePlayCount(int jumlah)
        {
            Debug.Assert(jumlah > 0, "Jumlah Play Count harus lebih dari 0");
            Debug.Assert(playCount + jumlah <= 10000000, "Play count maks 10.000.000");


        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}

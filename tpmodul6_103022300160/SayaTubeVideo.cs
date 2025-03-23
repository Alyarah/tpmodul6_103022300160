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

        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.playCount = 0;

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
        }

        public void IncreasePlayCount(int jumlah)
        {
            Debug.Assert(jumlah > 0, "Jumlah Play Count harus lebih dari 0");
            Debug.Assert(playCount + jumlah <= 10000000, "Play count maks 10.000.000");

            try
            {
                checked
                {
                    if (jumlah < 0) throw new ArgumentException("Jumlah tidak boleh negatif!");
                    if (playCount + jumlah > 10000000) throw new ArgumentException("Play count melebihi batas maksimal!");
                    playCount += jumlah;
                }
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count overflow!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}

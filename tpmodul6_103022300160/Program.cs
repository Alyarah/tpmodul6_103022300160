// See https://aka.ms/new-console-template for more information
using tpmodul6_103022300160;
class Program
{
    public static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Alya Rahmadayani");
        for (int i = 0; i < 5; i++)
        {
            video.IncreasePlayCount(1500000);
            video.PrintVideoDetails();

        }
    }
}


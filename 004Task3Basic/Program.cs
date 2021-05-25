using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Task3Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            ((IPlayable)player).Play();
            ((IPlayable)player).Pause();
            ((IPlayable)player).Stop();

            ((IRecodable)player).Record();
            ((IRecodable)player).Pause();
            ((IRecodable)player).Stop();
            Console.ReadKey();
        }
    }
}

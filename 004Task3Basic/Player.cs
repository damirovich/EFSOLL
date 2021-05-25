using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Task3Basic
{
    class Player : IPlayable, IRecodable
    {
        void IPlayable.Play() {
            Console.WriteLine("Проигрование");
        }
        void IPlayable.Pause() {
            Console.WriteLine("Пауза проигрование");
        }
        void IPlayable.Stop() {
            Console.WriteLine("Стоп проигрование");
        }
        void IRecodable.Record() {
            Console.WriteLine("Запись");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Запись на паузе");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена");
        }
    }
}

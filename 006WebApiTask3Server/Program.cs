using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace _006WebApiTask3Server
{
    class Program
    {

        static ServerObject server; // сервер
        static Thread listenThread; // потока для прослушивания
        static void Main(string[] args)
        {
            try
            {
                server = new ServerObject();
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start(); //старт потока
            }
            catch (Exception ex)
            {
                server.Disconnect();
                Console.WriteLine(ex.Message);
            }
        }
        //static void Main(string[] args)
        //{
        //    TcpListener server = null;
        //    try
        //    {
        //        //ip адрес компьютера
        //        IPAddress localAddr = IPAddress.Parse("192.168.8.100");
        //        //Порт который использует приложение
        //        server = new TcpListener(localAddr, 7777);

        //        Console.WriteLine("TCP Start");
        //        //Запуск ТСР
        //        server.Start();

        //        //Обработка новых клиентов который будет подключаться к этому серверу
        //        while (true) {
        //            Console.WriteLine("TCP Wait  for a client");
        //            //Ожидает подключение клиента
        //            TcpClient client = server.AcceptTcpClient();
        //            //Передача данных от клиента и обратно к клиенту
        //            NetworkStream stream = client.GetStream();

        //            string response = "Hello from the server";
        //            //Конверт сообщение набор байтов 
        //            byte[] data = Encoding.UTF8.GetBytes(response);
        //            //Запишем поток и отправляем ответ
        //            stream.Write(data, 0, data.Length);
        //            Console.WriteLine("Send: {0}", response);
        //            stream.Close();
        //            client.Close();
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message); 
        //    }
        //    finally {
        //        if (server != null) {
        //            server.Stop();
        //        }
        //    }
        //}
    }
}

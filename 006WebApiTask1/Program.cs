using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _006WebApiTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string host = "ru.wikipedia.org";
                TcpClient client = new TcpClient();
                client.Connect(host, 443);
                SslStream sslStream = new SslStream(
                    client.GetStream(),
                    false,
                    new RemoteCertificateValidationCallback(ValidateServerCertificate),
                    null
                    );

                sslStream.AuthenticateAsClient("");
                sslStream.ReadTimeout=2000;

                StringBuilder dataComplier = new StringBuilder();
                dataComplier.AppendLine("GET / HTTP/1.1");
                dataComplier.AppendLine($"Host: {host}");
                dataComplier.AppendLine("Accept: text/html");
                dataComplier.AppendLine("Connection: close");
                dataComplier.AppendLine($"User-Agent: {Assembly.GetExecutingAssembly().GetName().Name}");
                dataComplier.AppendLine("");

                string requesData = dataComplier.ToString();

                sslStream.Write(Encoding.UTF8.GetBytes(requesData));
                Console.WriteLine(requesData);

                var reader = new StreamReader(sslStream, Encoding.UTF8);
                Console.WriteLine("TCP Received:");
                Console.WriteLine(reader.ReadToEnd());

                reader.Close();
                client.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
        private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

    }
}

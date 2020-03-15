using System;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class Program : MonoBehaviour
    {
    public void Start()
    {
        bool continuer = true;

        while (continuer)
            while (continuer)
            {
                Console.Write("\nEntrez un message : ");
                string message = Console.ReadLine();

                //Sérialisation du message en tableau de bytes.
                byte[] msg = Encoding.Default.GetBytes(message);

                UdpClient udpClient = new UdpClient();

                //La méthode Send envoie un message UDP.
                udpClient.Send(msg, msg.Length, "127.0.0.1", 5035);

                udpClient.Close();

                Console.Write("\nContinuer ? (O/N)");
                continuer = (Console.ReadKey().Key == ConsoleKey.O);
            }
    }

}


using System;
using System.Net;
using System.Net.Sockets;

public class Conversor  
{  
    private TcpClient client = null;          

    public Conversor(TcpClient client)  {  
        this.client = client;  
    }  

    public void ProcessRequest()  {  
        Byte[] bytes = new Byte[256];  
        string data = null;  
        NetworkStream stream = client.GetStream();  
        Int32 i = stream.Read(bytes, 0, bytes.Length);  
        // Traducimos los datos enviados a un string ASCII  
        // ...  
        // Determinamos el tipo de conversión y la efectuamos  
        while((i = stream.Read(bytes, 0, bytes.Length)) != 0)  {  
            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);  
            // ...  
            // Determinamos el tipo de conversión y la efectuamos  
            // ...  
            // Enviamos la respuesta al cliente  
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);  
            stream.Write(msg, 0, msg.Length);  
        }
        // ...  
        // Cerramos el cliente y la conexión con él 
        client.Close();  
    }  
} 
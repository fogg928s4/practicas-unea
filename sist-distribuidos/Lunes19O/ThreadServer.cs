using System;
using System.Threading;

namespace ServerThread {
    class Program {
        public int operar(int x, int y)  {  
            return x + y;  
        }
        // Tests out 
        public void ArrancarMultiThread() { 
            try {  
                // Hacemos que el TcpListener escuche en host:port.  
                IPAddress localAddr =  IPAddress.Parse(ConfigurationManager.AppSettings["host"]);  
                // Casi lo mismo del socket pero con threads
                TcpListener server = new TcpListener(localAddr,  
                Int32.Parse(ConfigurationManager.AppSettings["port"]));                 
                server.Start(); 
                while (true) {  
                    TcpClient client = server.AcceptTcpClient(); 
                    // lock se usa como monitor
                    // evita que otros hilos accedan a este para evitar problemas de acceso concurrente a la variable requestCounter
                    // Le pasamos entre () el objeto que queremos bloquear, en este caso lockObject
                    lock (lockObject) { 
                        requestCounter += 1;  
                    } 

                    Conversor procesoConversion = new Conversor(client); // <-- Aqui se procesa la request
                    // Se crea un hilo para procesar la request y se le pasa el objeto Conversor que contiene la request
                    Thread hiloProcesador = new Thread(  
                        new ThreadStart(procesoConversion.ProcessRequest)
                    ); 
                    hiloProcesador.Start(); 
                }  
            
            } 
            catch (SocketException e)  {  
                 Console.WriteLine("SocketException: {0}", e);  
            }  
        }     
    }
    
}
# SOAP y REST

SOA/SOAP es un **protocolo estándar definido por la IEEE**. REST, aunque lo usa tanta gente, no es un estándar formalmente definido.
SOAP tiene un poco más de años y suele manejarse por XML, aunque también funciona por JSON. REST se maneja mejor con JSON.

## XML y JSON

La principal diferencia entre ambos es que el payload de JSON es más pequeño, aka más "rápido". Aun así, tiene la desventaja de los tipos, los cuales deben de ser inferidos.

## Sobre SOAP y .NET

SOAP requiere que se defina un WSDL (Web Services Desc. Lang.) que permite la definción de clases, y tipos para su consumo. UN recurso de ejemplo para SOAP se puede encontrar [aquí](https://www.dataaccess.com/webservicesserver/NumberConversion.wso) o también [este](http://www.dneonline.com/calculator.asmx?WSDL)

Para conectar un cliente de servicio SOAP y agregar las referencias a un proyecto de .NET hacemos lo siguiente:

1. Click derecho en el proyecto (NO LA SOLUCIÓN)
2. Seleccionamos **Agregar > Referencia de Servicio**
3. Seleccionamos el que dice WCF.
4. Ponemos la URI del WSDL del servicio, esto nos creará la definición de clases, namespace, y métodos necesarios según la especificación
5. Damos si a todo lo que sea por defecto. Podemos seleccionar crear métodos sync o async o ambos.
6. Listo

Para utilizarlos podemos crear un cliente, haciendo referencia a la clase en el namespace creado y darle la configuración requerida.

```C#
using CalculatorService;
using static CalculatorService.CalculatorSoapClient;

namespace SoapTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            // Part of the CalculatorService namespace
            // Inside the parameter for the constructor que have to add a shit from the CalcuatorService.EndpointConfiguration enum
            CalculatorSoapClient client = 
                new CalculatorSoapClient(
                    EndpointConfiguration.CalculatorSoap12, 
                    "http://www.dneonline.com/calculator.asmx"
               );
        }
    }
}
```
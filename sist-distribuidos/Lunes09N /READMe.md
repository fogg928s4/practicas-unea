# SOAP services w/ WCF

Auto creates a .NET Framework project for SOAP

**ICheeseService.cs**

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICheesesService" en el código y en el archivo de configuración a la vez.
namespace TestWCFService.App_Code
{
    [ServiceContract]
    public interface ICheesesService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        Cheese favouriteCheese(string name);

    }
    public class Cheese
    {
        //THe data memeber decorator shows the properties to generate the wsdl
        // and create a property around it
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Origin { get; set; }
        [DataMember]
        public bool Creamy { get; set; }

        public Cheese(string name)
        {
            Name = name;
            Description = "Your favourite cheese";
            Origin = "Here";
            Creamy = true;
        }

    }
}
```

**CheeseService.cs**

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "CheesesService" en el código, en svc y en el archivo de configuración a la vez.
namespace TestWCFService.App_Code
{
    public class CheesesService : ICheesesService
    {
        public void DoWork()
        {
        }
        public Cheese favouriteCheese(string name)
        {
            return new Cheese(name);
        }
    }
}

```
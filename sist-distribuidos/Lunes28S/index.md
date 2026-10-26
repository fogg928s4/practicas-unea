# Clase Lunes 28 Sept

## Herencia en C#/.NET

C# no permite herencia de multiples clases a diferencia de otros lenguajes como Java

```C#
class Empleado : Persona1, Persona2 {
    ...
    // No se puede
}
```

Para usar los métodos de la clase padre podemos utilizar el método `base`. Se parece mucho al `super` de Java. 

- **Clase Persona**

```C#
class Persona {
    public Persona(string nombre) { /*...*/ }
}


class Empleado : Persona {
    public Empleado() : base(string nombre) {}
}
```

Una interfaz define un contrato. Cualquier `class`, `record` o `struct` que implemente ese contrato debe proporcionar una implementación de los miembros definidos en la interfaz.  

## Windows Forms

Los objetos dentro de C# pueden hacer uso de **eventos**. Estos son *punteros a un método*. En Windows Forms se usan mucho para dar funcionalidad a botones y otros elementos.

```C#

class Form1 {
    private void label1_Click(object sender, EventArgs e){
        this.Close();
    }
    private void InitializeComponent() {
        /*
        * Agrega un metodo a un label al hacer click
        * Aunque haga += este es un método
        */
        this.label1.Click += label1_Click;
    }
}

```


## Excepciones

SOn errores o comportamientos inesperados que ocurren en **tiempo de ejecución**. No vale solo poner try/catch por todos lados, sino que se deben de manejar. También en lo posible se debe de evitar limitar al usuario en lo que quiere.

Hay muuuuuchos tipos de excepciones

````C#

try {
    int numero1, numero2;
    int cociente = numero1 / numero2;

} catch(DividedByZeroException ex) {
    //Que hacemos si divide entre 0
}

```
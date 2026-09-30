# Miercoles 30 S


## Delegados

`Delegate` sirve como un puntero de métodos. Puede 

```C#
// no devuelve y recibe un texto
public delegate void Ejecutar(string unTexto);

public class Deposito {

    // Es <<como>> un tipo
    public event Ejecutar EventoEjecutar;
    public Ejecutar DelegadoEjecutar;

    private bool DepositoLleno;

    private void DisparadorEvento(string unTexto) {
        if(this.EventoEjecutar != null)
            ths.EventoEjecutar(unTexto);
    }

    public void LlenarDeposito() {
        this.DepositoLleno = true;
        Message.Show($"En el deposito algo se llena. El texto es {unTexto}");
    }

}
```

Un evento no es un puntero a un método, es un array de punteros a métodos. Osea cuando ocurre, llamará a X cantidad de eventos dentro del array.

### Delegado normal vs Evento delegado

Un evento es un array de punteros a métodos. Llamar a un delegado fuera de un evento puede *forzar* su ejecución incluso cuando el evento no ha sucedido. La cosa es que hacerlo el evento lo permite enganchar/desenganchar pero no invocar.

```C#
class SomeForm {
    ...
    private void btn_Click(object sender, EventArgs e) {
        this.deposito.EventoEjecutar("Ejecucion Random");
        // Es como forzar el evento de hacer click en el boton SIN hacer click en el boton
    }
}
```
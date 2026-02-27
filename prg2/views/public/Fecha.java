package vistas;

// vista publica de la clase Fecha
class Fecha {
    public Fecha(int dia, int mes, int anio) {  }

    // getter q devuelve el valor del dia
    // a masias no le gustan
    public int dia;
    public int Dia() { return dia; }

    public String mostrar() { return ""; }

    // toma la actual instancia de la clase
    public boolean esBisiesto() { return true; }

    // a una fecha le restamos dias
    public Fecha restar(int dias) { }

    public void editarFecha(int dia, int mes, int anio) {}
    public void editarFecha(Fecha fecha) {}
    public void editarFecha(int dia) {}

    public Fecha[] calendarizar(Fecha final, int frecuenciaDias) { return null;}


    public int diasTranscurridosFinAño() { return 1; }
    public int mesesTranscurridosFinAño() { return 1; }
    public int semanasTranscurridosFinAño() { return 1; }
}

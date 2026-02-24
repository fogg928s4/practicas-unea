package vistas;

class Intervalo {

    // Datos
    double longitud;
    double limSuperior;
    double limInferior;

    // Constructor
    public Intervalo(double inferior, double superior) {
        this.limSuperior = superior;
        this.limInferior = inferior;
        this.longitud = obtenerLongitud();
    }

    // Propiedades
    public double LimSuperior() {
        return this.limSuperior; 
    }
    public double LimInferior() {
        return this.limInferior; 
    }
    public double Longitud() {
        return this.longitud;
    }

    private double obtenerLongitud() {
        return limSuperior - limInferior;
    }
}
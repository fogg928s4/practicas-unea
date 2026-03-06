package vistas;

class Intervalo {

    // Datos
    private double longitud;
    private double limSuperior;
    private double limInferior;

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

    // Metodos
    public double puntoMedio() {
        double temp = limSuperior + limInferior;
        return temp/2;
    }

    // Esto es una implementacion, por lo cual va mas en la vista privada
    public Intervalo unirIntervalos(Intervalo intervalo1, Intervalo intervalo2) {
        /*double nuevoSuperior, nuevoInferior;

        if(intervalo1.LimSuperior() >= intervalo2.LimInferior()) {
            nuevoSuperior = intervalo2.LimSuperior();
            nuevoInferior = intervalo1.LimInferior();
        }
        else {
            nuevoSuperior = intervalo1.LimSuperior();
            nuevoInferior = intervalo2.LimInferior();
        }

        return new Intervalo(nuevoSuperior,nuevoInferior);*/
    }
}
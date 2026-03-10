class Intervalo {

    // Implementacion privada
    private double inferior;
    private double superior;
    // Otra opcion puede ser
    // Como es privado no necesita saber como se implementa
    // private double puntoMedio;
    // private double longitud;

    public Intervalo (double inferior, double superior) {
        // sirve para verificar que se cumpla antes de crear el objeto
        assert inferior <= superior : "Hey! inferior es mayor que superior";
        // para "comprometer el funcionamiento"
        // longitud = superior - inferior;
        // puntoMedio = inferior + (longitud /2 );
        this.inferior = inferior;
        this.superior = superior;
    }
    public Intervalo (double superior) {
        this(0, superior);
    }
    public Intervalo () {
        this(0,0);
    }
    public Intervalo (Intervalo intervalo) {
        // puede ser
        // inferior = intervalo.inferior;
        // superior = intervalo.superior;
        // o podemos llamar al primer constructor
        this(intervalo.inferior, intervalo.superior);
        // es de java pero debe ser la primera linea de la implementacion
    }

    public Intervalo clone() {
        return new Intervalo(this.inferior, this.superior);
    }
    public double longitud() {
        return superior - inferior;
    }
    public void desplazar(double desplazamiento) {
        // parte de la vista privada, no se ve
        //puntoMedio += desplazamiento;
        superior+=desplazamiento;
        inferior+=desplazamiento;

    }
    public Intervalo desplazado(double desplazamiento) {
        return new Intervalo(inferior+desplazamiento, superior +desplazamiento);

        //o usando desplazar
        Intervalo temp = this.clone();
        temp.desplazar(desplazamiento);
        return temp;
    }

    public boolean incluye(double punto) {
        return inferior <= punto && superior >= punto;
    }
    public boolean incluye(Intervalo intervalo) {
        // Objetos de la misma clase pueden interactuar con
        // atributos privados del mismo tipo
        return this.superior >= intervalo.superior && 
                this.inferior <= intervalo.inferior;  
        
        // o
        return this.incluye(intervalo.inferior) && this.incluye(intervalo.superior);
    }
    public boolean equals(Intervalo intervalo) {
        assert intervalo != null : "El intervalo de comparacion no puede ser nulo";
        return this.superior == intervalo.superior && 
                this.inferior == intervalo.inferior;
    }

    public Intervalo interseccion(Intervalo intervalo) {
        assert this.intersecta(intervalo);

        if(this.incluye(intervalo)) {
            return intervalo.clone();
        }
        else if (intervalo.incluye(this)) {
            return this.clone();
        }
        else if (this.incluye(intervalo.inferior)) {
            return new Intervalo(intervalo.inferior, superior);
        }
        else {
            return new Intervalo(intervalo.superior, inferior);
        }
    }

    public boolean intersecta(Intervalo intervalo)   {
        assert intervalo != null;
        // reusando tanto como se pueda
        return this.incluye(intervalo.inferior) 
                || this.incluye(intervalo.superior)
                || intervalo.incluye(this);
    }
    
    public void oponer()
    public void doblar() {
        double longitud = this.longitud();
        inferior = inferior-(longitud/2);
        superior = superior+(longitud/2);
    }
    public void mostrar()
    public void recoger()

    public Intervalo[] trocear(int numeroTrozos)
    public Intervalo union(Intervalo intervalo)
    public double puntoMedio();

}
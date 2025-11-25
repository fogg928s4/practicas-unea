import java.util.Scanner;

class Metodos {
    public static void main(String[] args) {
        mostrarMenu(); 
        int opcion = pedirNumeroValido(1,4 );
        procesarOpcion(opcion);
        //  imprimirQuesos();
    }   

    private static void imprimirQuesos() {
        String[] quesos = {
            "mozzarella",
            "gouda",
            "viejo",
            "quesillo"
        };        
        for(int i = 0; i < quesos.length; i++) {
            System.out.println((i+1) +" - " + quesos[i]);
        }
    }

    private static void mostrarMenu() {
        String[] opciones = {
            "Ver Quesos Disponibles",
            "Comprar un queso", 
            "Version del programa",
            "Salir"
        };
        for(int i = 0; i<opciones.length; i++) {
            System.out.println((i+1) +" - " + opciones[i]);
        }
    }
    
    private static int capturarOpcion() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Elija su opcion: ");
        int opc = scanner.nextInt();
        //scanner.close();
        return opc;
    }

    private static boolean validarOpcion(int opcion, int min, int max) {
        return (opcion >= min && opcion <= max);
    }

    private static int pedirNumeroValido(int min, int max) {
        boolean opcionValida = false;
        int opcion;
        do {
            opcion = capturarOpcion();
            opcionValida = validarOpcion(opcion,min,max);
        } while(!opcionValida);
        return opcion;
    }
    
    //sobrecarga de metodos
    public static int pedirNumeroValido(String msj, int valor, int valorEvitar) {
        return 1+ 1;
    }
    private static void procesarOpcion(int opc) {
        switch(opc) {
            case 1:
                imprimirQuesos();
                break;
            case 2 -> System.out.println(":DDDDD"); // another switch
            default:
                System.out.println(":D");
                break;
        }
    }
}

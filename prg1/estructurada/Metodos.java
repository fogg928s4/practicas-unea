import java.util.Scanner;

class Metodos {
    public static void main(String[] args) {
        mostrarMenu(); 
        boolean opcionValida = false;
        int opcion;
        while(!opcionValida) {
            opcion = capturarOpcion();
            opcionValida = validarOpcion(opcion,1,3);
        }
        imprimirQuesos();
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
        scanner.close();
        return opc;
    }

    private static boolean validarOpcion(int opcion, int min, int max) {
        return (opcion >= min && opcion <= max);
    }
}

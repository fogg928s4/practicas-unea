import java.util.Scanner;

class MatricesDobles {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);

        int[] array1 = {1,2,3,4};
        int[] otroArray = null;
        int[] cuantosArraysSon = {-1};
        int[][] arrayDeArrays = {array1, otroArray, cuantosArraysSon};
        System.out.println(arrayDeArrays[0][3]);
        scr.nextLine();
        System.out.println("...Imprimiendo el array");
        int filas = arrayDeArrays.length;
        for(int i = 0; i < filas; i++) {
            for(int j = 0; j < arrayDeArrays[i].length; j++) {
                System.out.println("arrayDeArrays[" +i+"][" + j+ "] = "+ arrayDeArrays[i][j]);
            }
        }

    }
    public static void espaciosMemoria() {
        // una var de ref que guardar varias var de ref
        // en total se usan 13 espacios de memoria
        int[][] teclas = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        
        int[] z = {1, 2}, x = {-3,-4};
        int[][] v = {z, x}; // usa 7 espacios de  memoria 
        int[][] w = {z , z}; // guarda 5 espacios de memoria
        // esta ultima tecnica sirve para ahorrar
        // memoria en distintos juegos viejos

        int[] unaFila = {1,2,3}; // una fila = 4 espacios
        int[][] tabla = {
            unaFila,
            { 5, 4 ,-4},
            { 1, 0, 4},
            unaFila
        }; // tabla = 14 espacios 
        int[][] otraTabla = {
            {1},
            {2,3},
            unaFila,
            unaFila,
            unaFila
        }; // 10 espacios
    }
}

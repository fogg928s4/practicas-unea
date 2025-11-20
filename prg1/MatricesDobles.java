import java.util.Scanner;

class MatricesDobles {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        // una var de ref que guardar varias var de ref
        // en total se usan 13 espacios de memoria
        int[][] teclas = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

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
}

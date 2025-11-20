class PracticasMatrices {
    public static void main(String[] args) {
        construirParedes();
    }   

    // bloque de codigo bautizado
    // esto es un metodo
    // las funciones/metodos deben ser verbos
    // encapsulascion, abstraccion y encapsulacion
    private static void construirParedes() {
        int[][] matriz = {
            {0,1,0,1,0,1,0},
            {0,1,1,1,1,0,1},
            {1,1,0,1,0,1,0},
            {0,0,0,1,1,0,1}
        };
        String[] pared = {"[]", " "};
        for (int i = 0; i<matriz.length; i++) {
            for(int j = 0; j< matriz[i].length;j++) {
                System.out.print(pared[matriz[i][j]]);
            }
            System.out.println();
        }
    } 
}

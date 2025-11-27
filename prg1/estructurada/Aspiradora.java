class Aspiradora {
    public static void main(String[] args) {
        String[] estadosSuciedad = {
            " . ",
            "...",
            "ooo",
            "OOO",
            "***"
        };
        int[][] mapaSuciedad = {
            {0, 4, 2, 1, 3, 0, 2, 4, 1, 0, 3, 2, 4, 0, 1, 3, 2, 0, 4, 1, 2, 3, 0, 4, 1},
            {2, 1, 0, 3, 4, 2, 1, 0, 4, 3, 2, 1, 0, 4, 3, 2, 1, 0, 4, 3, 2, 1, 0, 4, 3},
            {3, 0, 4, 2, 1, 3, 0, 4, 2, 1, 3, 0, 4, 2, 1, 3, 0, 4, 2, 1, 3, 0, 4, 2, 1},
            {1, 2, 3, 0, 4, 1, 2, 3, 0, 4, 1, 2, 3, 0, 4, 1, 2, 3, 0, 4, 1, 2, 3, 0, 4},
            {4, 3, 2, 1, 0, 4, 3, 2, 1, 0, 4, 3, 2, 1, 0, 4, 3, 2, 1, 0, 4, 3, 2, 1, 0},
            {0, 1, 4, 3, 2, 0, 1, 4, 3, 2, 0, 1, 4, 3, 2, 0, 1, 4, 3, 2, 0, 1, 4, 3, 2},
            {2, 0, 3, 1, 4, 2, 0, 3, 1, 4, 2, 0, 3, 1, 4, 2, 0, 3, 1, 4, 2, 0, 3, 1, 4},
            {1, 4, 0, 2, 3, 1, 4, 0, 2, 3, 1, 4, 0, 2, 3, 1, 4, 0, 2, 3, 1, 4, 0, 2, 3}
        };

        int[][] superficie = new int[5][8];
        for (int i = 0; i < 16;i++) {
            int x = (int) (Math.random() * superficie.length);
            int y = (int)(Math.random() * superficie[0].length);
            superficie[x][y] = (int)(Math.random() *4) + 1;
        }
        int posY = superficie.length;
        int posX = superficie[posY - 1].length;
        
        
        for(int i = 0; i< mapaSuciedad.length; i++) {
            for(int j = 0;j < mapaSuciedad[i].length; j++) {
                if(i == posY && j == posX) {
                    System.out.println("(0)");
                }
                 else {
                    System.out.print(estadosSuciedad[mapaSuciedad[i][j]]);
                 }

            }
            System.out.println();
        }


    }
    private static void suciedadRandom() {
        
    }
}

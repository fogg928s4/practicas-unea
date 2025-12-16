class Battleship {
    public static void main(String[] args) {
        int[][] stage = {
            {-1,-1,-1,-1,-1,-1,-1,-1},
            {-1,-1,-1,-1,-1,-1,-1,-1},
            {-1,-1,-1,-1,-1,-1,-1,-1},
            {-1,-1,-1,-1,-1,-1,-1,-1},
            {-1,-1,-1,-1,-1,-1,-1,-1},
            {-1,-1,-1,-1,-1,-1,-1,-1},
            {-1,-1,-1,-1,-1,-1,-1,-1}
        };
        final int SOLDIER_COUNT = 16;

        placeSoldiers(SOLDIER_COUNT, stage);

    }
    
    static void placeSoldiers(int count, int[][] stage) {

    }

    static void printStage(int[][] stage) {
        
        for(int i = 0; i < stage.length; i ++) {
            for (int j = 0; j< stage[i].length; j++) {
                System.out.print(mapTile(stage[i][j]));
            }
            System.out.println();
        }
    }
    
    static String mapTile(int tile) {
        final String[] TILES = {"~~~" , "\\0/"};
        final String MIST = " ? ";
        return tile < 0 ? MIST : TILES[tile];
    }
}

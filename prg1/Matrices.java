class Matrices {
    public static void main(String[] args) {
        int[] original = { 1, 2, 3 };
        int[] alias = original; // coontiene la dir del array 1,2,3
        int[] independiente = { 1 , 2 ,3};
        int[] espejo = independiente;
        int[] fantasma = null;
        int[] copiaFantasma = fantasma;

        System.out.println("1) original == alias >>> "+ (original == alias));
        System.out.println("2) original == independiente >>> "+ (original == independiente));
        System.out.println("3) independiente==espejo >>> "+ (independiente==espejo));
        System.out.println("4) fantasma==copiaFantasma >>> "+ (fantasma==copiaFantasma));        

        System.out.println("fantasma =>> " + fantasma);
        System.out.println("copiaFantasma =>> " + copiaFantasma);

        String stringVacio = new String();
        System.out.println(stringVacio);
        Integer aInteger = new Integer("2");
        System.out.println("INTEGER   " + aInteger);

        int prim = 1;
        int prom = 2;
        int[] fromPrim = {prim, prom};
        System.out.println("3) fromPRim[0] >> " + fromPrim[0]);
        System.out.println("4) fromPRim[1] >> " + fromPrim[1]);
        prim = 500;
        prom = -12312;
        System.out.println("5) fromPRim[0] >> " + fromPrim[0]); //siempre imprime 1 y 2
        // prim no es var de ref, por lo cual el val no cambia en el array
        System.out.println("6) fromPRim[1] >> " + fromPrim[1]);
        // con llaves java solo admite una vez
        // para hacerlo de nuevo en la misma se usa new
        fromPrim = new int[] {prim, prom};
        System.out.println("5) fromPRim[0] >> " + fromPrim[0]); 
        System.out.println("6) fromPRim[1] >> " + fromPrim[1]);
    }
}
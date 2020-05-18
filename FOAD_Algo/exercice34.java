package crm.algorithme.exercices;

public class exrecice34 {
    public static void main(String[] args) {
        int i2=0, tmpCase=0, tableauEntier[] = {5, 21, 3, 12, 4, 36, 54, 22};
        for(int i = 0; i < tableauEntier.length; i++) {
            tmpCase=0;
            //on prend la case suivante si on est pas a la fin du tableau
            if((i+1) < tableauEntier.length) {
                i2 = i + 1;
            }
            while(i2 < tableauEntier.length) {
                if(tableauEntier[i] > tableauEntier[i2]) {
                    tmpCase = tableauEntier[i2];
                    tableauEntier[i2] = tableauEntier[i];
                    tableauEntier[i] = tmpCase;
                }
                i2++;
            }

        }
        System.out.println("Valeur des cases du tableau aprés tri");
        for(int i=0; i < tableauEntier.length; i++) {
            System.out.println(tableauEntier[i]);
        }
    }
}

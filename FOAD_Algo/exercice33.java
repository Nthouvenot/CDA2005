package crm.algorithme.exercices;

import java.util.Scanner;

public class exercice33 {

    public static void main(String[] args) {

        int occurenceLettreAlphabet[] = new int[25];
        char tableauLettreAlphabet[] = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        String chaine = "";
        boolean ok = false;
        // initialisation des cases du tableau a 0
        for(int i=0; i < 25; i++) {
            occurenceLettreAlphabet[i] = 0;
        }
        Scanner sc = new Scanner(System.in);
        System.out.println("saisissez une chaine d'au moins 120 caratéres");
        //on répete la saisie tant qu'elle ne contient pas 120 caractéres au minimum
        while(!ok) {
            chaine = sc.nextLine();
            if(chaine.length() >= 120) {
                ok = true;
            }
            else
            {
                System.out.println("La chaine saisie doit faire au minimum 120 caractéres");
            }
        }
        for(int i=0; i < chaine.length(); i++) {
            for(int i2=0; i2 < 25; i2++) {
                char temporaireChaine = chaine.charAt(i);
                if(temporaireChaine == tableauLettreAlphabet[i2]) {
                    occurenceLettreAlphabet[i2] = occurenceLettreAlphabet[i2] + 1;
                }

            }
        }
        System.out.println("Nombre d'occurence de chaque lettre de l'alphabet présente dans la chaine saisie :");
        for(int i=0; i < 25; i++) {
            System.out.println(tableauLettreAlphabet[i] + " : " + occurenceLettreAlphabet[i] + "fois");
        }
    }
}

package crm.algorithme.exercices;

import java.util.Scanner;

public class exercice32 {

    public static void main(String[] args) {

        String chaine, caractere;
        char charOccurency, charAtPosition;
        int occurence = 0;
        Scanner sc = new Scanner(System.in);
        System.out.println("Saisissez une chaine qui se termine par un point");
        chaine = sc.nextLine();
        System.out.println("saisissez le caractére a rechercher");
        caractere = sc.nextLine();
        charOccurency = caractere.charAt(0);
        //On teste d'abord si le caractére '.' est bien présent dans la chaine
        if (chaine.indexOf(".") != -1) {
            if (chaine.indexOf('.') == 0) {
                System.out.println("La chaine  est vide");
            }
            else {
                for (int i = 0; i < chaine.length(); i++) {
                    charAtPosition = chaine.charAt(i);
                    if(charAtPosition == charOccurency)
                    occurence++;
                }
                System.out.println("le caractére " + caractere + " est présent " + occurence + " fois");
            }
        }
       else{
                System.out.println("erreur chaine incorrect le caractére de fin de chaine '.' est introuvable");
            }
    }
}

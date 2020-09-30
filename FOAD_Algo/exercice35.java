package crm.algorithme.exercices;

import java.util.Scanner;

public class exercice35 {

    public static void main(String[] args) {
        String chaine = "";
        int longeurChaine = 0, i = 0;
        boolean palindrome = true;
        Scanner sc = new Scanner(System.in);
        System.out.println("Saisisser une phrase ou un mot finissant par '.'");
        chaine = sc.nextLine();
        //Si la chaine contient le caractére '.' on continue les test
        if (chaine.charAt(chaine.length() - 1) == '.' && chaine.charAt(0) != '.') {
            //On enléve le '.' de la chaine
            chaine = chaine.substring(0, chaine.length() - 1);
            if ((chaine.length() - 1) % 2 == 0) {
                longeurChaine = chaine.length() - 1;
                while (i < chaine.length() / 2 && palindrome) {
                    if (chaine.charAt(i) == chaine.charAt(longeurChaine)) {
                        i++;
                        longeurChaine--;
                    } else {
                        palindrome = false;
                    }
                }
            } else {
                palindrome = false;
            }
            //Afichage du résultat
            if (palindrome) {
                System.out.println(chaine + " est un palindrome");
            } else {
                System.out.println(chaine + " n'est pas un palindrome");
            }
        } else if(chaine.charAt(0) == '.') {
            System.out.println("La chaine est vide");
        }
        else {
            System.out.println("Chaine mal formaté, le caractére '.' est introuvable");
        }
    }
}

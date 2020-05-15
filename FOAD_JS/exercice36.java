package crm.algorithme.exercices;

import java.util.Scanner;

public class exercice36 {

    public static void main(String[] args) {

        int essaisRestant = 6, caractereOk = 0;
        boolean victoire = false, caractereTrouve = false;
        String chaine, chaineCaractere;
        char[] reponseUtilisateur = new char[25];
        char caractereReponse = ' ';
        Scanner sc = new Scanner(System.in);
        System.out.println("Jeu du pendu");
        System.out.println("Saisissez un mot de minimum 5 lettres");
        chaine = sc.nextLine();
        //On récupere le premier et le dérnier caractère du mot
        reponseUtilisateur[0] = chaine.charAt(0);
        reponseUtilisateur[chaine.length()] = chaine.charAt(chaine.length() - 1);
        //On insére des '-' entre la premiére et la dérnière lettre du mot
        for (int i = 1; i < chaine.length() - 1; i++) {
            reponseUtilisateur[i] = '-';
        }
        //On a droit a 6 essais
        while (essaisRestant >= 0 && victoire == false) {

            System.out.println("Essais restant :" + essaisRestant);
            System.out.println(String.copyValueOf(reponseUtilisateur));
            System.out.println("Saisissez une lettre");
            chaineCaractere = sc.nextLine();
            caractereReponse = chaineCaractere.charAt(0);
            //On reinitialise pour la prochaine lettre
            caractereTrouve = false;
            //On teste et remplace les '-' par le caractére rentré par l'utilisateur
            for (int i = 0; i < chaine.length() - 1; i++) {
                if(caractereReponse == chaine.charAt(i)) {
                    reponseUtilisateur[i] = chaine.charAt(i);
                    caractereTrouve = true;
                }
            }
            if(!caractereTrouve) {
                essaisRestant--;
            }
            //On verifie si le mot de l'utilsateur est identique au mot a deviner
            caractereOk = 1;
            for(int i=0; i < chaine.length(); i++) {
                if(reponseUtilisateur[i] == chaine.charAt(i)) {
                    caractereOk++;
                }
                //Si tout les caractéres sont identique le mot a été trouvé
                if(caractereOk == chaine.length()  && !victoire) {
                    victoire = true;
                    essaisRestant = 6 - essaisRestant;
                    System.out.println("Vous avez trouvez en " + essaisRestant + " coup");
                }
            }
        }
    }
}

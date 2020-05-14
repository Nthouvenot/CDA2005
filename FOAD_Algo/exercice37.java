package crm.algorithme.exercices;

public class exercice37 {

    public static void main(String[] args) {
        String name[] = {"agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie"}, nameSearch="chloé";
        int middleName=0, i=0, compareResult, lowIndex, hightIndex, position=-1;
        middleName = (int)Math.ceil(name.length/2);
        while(position == -1 || i < name.length - 1) {
            compareResult = nameSearch.compareToIgnoreCase(name[middleName]);
            if(compareResult > 0) {
                lowIndex = middleName + 1;
                hightIndex = ????;
            }
        }
    }
}

package crm.algorithme.exercices;

public class exercice37 {

    public static void main(String[] args) {
        String name[] = {"agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie"}, nameSearch="olga";
        int middleName=0, i=0, compareResult,lowPrevIndex, lowIndex=0, hightPrevIndex, hightIndex, position=-1;
        lowPrevIndex = 0;
        hightPrevIndex = hightIndex = name.length;
        middleName = (int)Math.ceil(name.length/2);
        while(position == -1 && i < name.length - 1) {
            compareResult = nameSearch.compareToIgnoreCase(name[middleName]);
            if(compareResult < 0) {
                lowIndex = lowPrevIndex;
                hightIndex = middleName;
                middleName = (int)Math.ceil((hightIndex - lowIndex) / 2);
            } else if(compareResult > 0) {
                lowIndex = middleName;
                hightIndex = hightPrevIndex;
                middleName += (int)Math.ceil((hightIndex - lowIndex) / 2);
            } else {
                position = middleName;
            }
            lowPrevIndex = lowIndex;
            hightPrevIndex = hightIndex;

            i++;
        }
        if(position == -1) {
            System.out.println("Le nom n'a pas été trouvé");
        } else {
            System.out.println("Le nom " + nameSearch + " est en position n° " + position);
        }
    }
}

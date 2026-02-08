public class Student extends Person {
    double averageGrade;

    Student(String name, char gender, String EGN, double averageGrade) {
        super(name, gender, EGN);
        this.averageGrade = averageGrade;
    }

    public void print() {
        System.out.println(name + " " + gender + " " + EGN + " " + averageGrade);
    }
}

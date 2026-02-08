public class Teacher extends Person {
    int salary;

    Teacher(String name, char gender, String EGN, int salary) {
        super(name, gender, EGN);
        this.salary = salary;
    }

    public void print() {
        System.out.println(name + " " + gender + " " + EGN + " " + salary);
    }
}

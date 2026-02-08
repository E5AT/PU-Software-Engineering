public class Student extends Person {
    private String major;
    float gpa;

    public Student(String name, int age, String major, float gpa) {
        super(name, age);
        this.major = major;
        this.gpa = gpa;
    }

    public Student() {
        super();
        major = "";
        gpa = 0;
    }

    public void printInfo() {
        super.printInfo();
        System.out.println("Major: " + major);
        System.out.println("GPA: " + gpa);
    }
}

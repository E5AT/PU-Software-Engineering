package school;

public class Student extends Person {
    private int studentNumber;
    private String major;

    Student(String name, int studentNumber, String major) {
        super(name);
        this.studentNumber = studentNumber;
        this.major = major;
    }

    @Override
    public void writeOutput() {
        super.writeOutput();
        System.out.println(this.studentNumber);
        System.out.println(this.major);
    }

    public boolean equals(Student other){
        if(this.getName() ==  other.getName())
            if(this.studentNumber == other.studentNumber)
                return true;
        return false;
    }
}

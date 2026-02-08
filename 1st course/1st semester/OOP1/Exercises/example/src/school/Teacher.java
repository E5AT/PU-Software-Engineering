package school;

public class Teacher extends Person {
    private double salary;

    Teacher(String name, double salary){
        super(name);
        this.salary = salary;
    }

    public void raiseSalary(double precent){
        salary += salary * (precent/100);
    }

    @Override
    public void writeOutput(){
        super.writeOutput();
        System.out.println(salary);
    }
}

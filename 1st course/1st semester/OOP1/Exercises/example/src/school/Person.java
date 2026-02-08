package school;

public class Person {
    private String name;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    Person(String name) {
        this.name = name;
    }

    public void writeOutput(){
        System.out.println(name);
    }
}

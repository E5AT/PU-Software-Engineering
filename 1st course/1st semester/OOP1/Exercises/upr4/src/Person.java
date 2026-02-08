public class Person {
    String name;
    int age;

    public void printInfo() {
        System.out.println("Name: " + name);
        System.out.println("Age: " + age);
    }

    public Person(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public Person() {
        name = "";
        age = -1;
    }

//    public Person(int age, String name){
//        this.age = age;
//        this.name = name;
//    }
}

abstract class Person {
    String name, EGN;
    char gender;

    Person(String name, char gender, String EGN) {
        this.name = name;
        this.gender = gender;
        this.EGN = EGN;
    }

    abstract void print();
}

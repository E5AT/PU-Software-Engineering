public class Pet {
    private String name;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    private int age;

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        if (age < 0) {
            System.out.println("Грешка: Отрицателна възраст.");
            System.exit(0);
        } else this.age = age;
    }

    private double weight;

    public double getWeight() {
        return weight;
    }

    public void setWeight(double weight) {
        if (weight < 0) {
            System.out.println("Грешка: Отрицателно тегло.");
            System.exit(0);
        } else this.weight = weight;
    }

    public Pet() {
        name = "Все още няма име";
        age = 0;
        weight = 0;
    }

    public Pet(String name, int age, double weight) {
        setName(name);
        setAge(age);
        setWeight(weight);
    }

    public void writeOutput() {
        System.out.println("Име: " + getName());
        System.out.println("Възраст: " + getAge());
        System.out.println("Тегло: " + getWeight());
    }

    public static double kgToLbs(double kg) {
        return kg * 2.20462;
    }
}

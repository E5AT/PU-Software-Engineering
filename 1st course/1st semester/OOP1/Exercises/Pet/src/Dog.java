public class Dog extends Pet {
    private String breed;

    public String getBreed() {
        return breed;
    }

    public void setBreed(String breed) {
        this.breed = breed;
    }

    public void writeOutput() {
        super.writeOutput();
        System.out.println("Порода: " + getBreed());
    }

    public int getAgeInHumanYears() {
        if (getAge() <= 2)
            return getAge() * 11;
        return 22 + ((getAge() - 2) * 5);
    }

    public Dog(String name, int age, double weight, String breed) {
        super(name, age, weight);
        setBreed(breed);
    }
}

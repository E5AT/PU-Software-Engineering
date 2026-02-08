import java.util.Scanner;

class ClinicDemo {
    void main() {
        Pet[] pets;
        Pet pet;
        int n, age;
        String name, breed;
        double weight;
        char type;

        Scanner input = new Scanner(System.in);
        System.out.print("Брой животни: ");
        n = input.nextInt();
        pets = new Pet[n];

        for (int i = 0; i < n; i++) {
            System.out.print("\n[Ж]ивотно или [К]уче?: ");
            type = input.next().charAt(0);

            System.out.print("Име: ");
            name = input.next();

            System.out.print("Възраст: ");
            age = input.nextInt();

            System.out.print("Тегло: ");
            weight = input.nextDouble();

            if(type=='к' || type=='К'){
                System.out.print("Порода: ");
                breed = input.next();
                pet = new Dog(name, age, weight, breed);
            }
            else pet = new Pet(name, age, weight);

            pets[i] = pet;
            System.out.println("Успешно добавено!\n");
        }

        System.out.println("\nПълен списък на животните:");
        int i = 0;
        double averageAge = 0;

        while (true){
            pets[i].writeOutput();
            System.out.println();
            averageAge += pets[i].getAge();
            i++;
            if(i==n) break;
        }
        averageAge/=n;

        System.out.println("\nСписък на имената на животните с възраст над средната:");
        for(Pet pet1 : pets){
            if(pet1.getAge()>averageAge)
                System.out.println(pet1.getName());
        }


    }
}

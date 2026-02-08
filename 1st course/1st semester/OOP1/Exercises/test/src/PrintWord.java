import java.util.Scanner;

public  class PrintWord {
    public static void main(String[] args) {
        System.out.println("Hello World");
        Scanner input = new Scanner(System.in);
        System.out.print("Please enter your age: ");
        int age = input.nextInt();
        System.out.println("You are "+age+" years old");
    }
}

public class Sportsman {
	String name;
	int age;
	
	public void printInfo() {
		System.out.println("Name: " + name);
		System.out.println("Age: " + age);
	}
	
	public Sportsman(String name, int age) {
		this.name = name;
		this.age = age;
	}
	
	public Sportsman() {
		name="";
		age=0;
	}
}

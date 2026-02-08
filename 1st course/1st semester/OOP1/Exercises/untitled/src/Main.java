import java.util.ArrayList;

public class Main {

	public static void main(String[] args) {
		Athlete a1 = new Athlete("Иван", 23, 7);
		Athlete a2 = new Athlete("Петър", 35, 3);
		Athlete a3 = new Athlete("Георги", 29, 8);
		Athlete a4 = new Athlete("Димитър", 17, 12);
		
		Coach c1 = new Coach("Стоян", 52, 50);
		Coach c2 = new Coach("Венцислав", 33, 13);
		Coach c3 = new Coach("Любомир", 28, 22);
		Coach c4 = new Coach("Пламен", 45, 18);
		
		ArrayList<Sportsman>sportsmen = new ArrayList<Sportsman>();
		sportsmen.add(a1);
		sportsmen.add(a2);
		sportsmen.add(a3);
		sportsmen.add(a4);
		sportsmen.add(c1);
		sportsmen.add(c2);
		sportsmen.add(c3);
		sportsmen.add(c4);
		
		int couchcount=0;


		for(Sportsman s:sportsmen) {
			if(s instanceof Athlete && s.weeklytraining>4 && s.age<30) { {
				a.printInfo();
				System.out.println(a.name);
			}
			
		}
			else if(s instanceof Coach) {
				Coach c=(Coach)s;

				if((Coach)s.customers>15 && (Coach)s.age>40) {
					couchcount++;
				}
			}
	 }
		System.out.println("Броя на треньорите на възраст над 40г и с над 15 клиента " + couchcount);

	}

}

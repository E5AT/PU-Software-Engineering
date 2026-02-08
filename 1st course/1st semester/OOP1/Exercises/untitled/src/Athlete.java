
public class Athlete extends Sportsman{
 int  weeklytraining;
 
  public Athlete(String name, int age, int weeklytraining) {
	  super(name,age);
	  this.weeklytraining = weeklytraining;
  }
  
  public Athlete() {
	  super();
	  weeklytraining=0;
  }
  
  public void printInfo() {
	  super.printInfo();
	  System.out.println("Weeklytraining: " + weeklytraining);
  }
}

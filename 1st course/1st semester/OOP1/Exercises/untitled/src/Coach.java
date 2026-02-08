
public class Coach extends Sportsman{
 int  customers;
 
  public Coach(String name, int age, int customers) {
	  super(name,age);
	  this.customers = customers;
  }
  
  public Coach() {
	  super();
	  customers=0;
  }
  
  public void printInfo() {
	  super.printInfo();
	  System.out.println("Customers: " + customers);
  }
}

void main() {
//    Person person1 = new Person(),
//            person2 = new Person(),
//            person3 = new Person("Mike", 32),
//            //person4 = new Person(12, "Kyle")
//            student1 = new Student("Jack", 21, "Physics", 3.4f);
//
//    person1.name = "John";
//    person1.age = 20;
//
//    person2.name = "Jane";
//    person2.age = 40;
//
//    person1.printInfo();
//    System.out.println();
//
//    person2.printInfo();
//    System.out.println();
//
//    person3.printInfo();
//    System.out.println();
//
//    //person4.printInfo();
//    student1.printInfo();
//    System.out.println();
//
//    person1 = student1;
//    person1.printInfo();

    Triangle t1 = new Triangle(3, 5),
            t2 = new Triangle(30, 50),
            t3 = new Triangle(300, 500);

    Rectangle r1 = new Rectangle(4, 5),
            r2 = new Rectangle(40, 50),
            r3 = new Rectangle(400, 500);

    ArrayList<Shape> shapes = new ArrayList<Shape>();
    shapes.add(t1);
    shapes.add(t2);
    shapes.add(t3);
    shapes.add(r1);
    shapes.add(r2);
    shapes.addFirst(r3);

    Shape maxAreaTriangle = null,
            minAreaRectangle = null;

    for (Shape s : shapes) {
//        System.out.print(s.area() + " - ");

//        if (s.getClass() == Triangle.class)

//        if (s.getClass().getName().equals("Triangle"))
//            System.out.println("триъгълник");
//        else
//            System.out.println("четириъгълник");

        if (maxAreaTriangle == null && s instanceof Triangle)
            maxAreaTriangle = s;
        else if (minAreaRectangle == null && s instanceof Rectangle) {
            minAreaRectangle = s;
        } else {
            if (maxAreaTriangle.area() < s.area() && s instanceof Triangle)
                maxAreaTriangle = s;
            if (minAreaRectangle.area() > s.area() && s instanceof Rectangle)
                minAreaRectangle = s;
        }
    }

    System.out.println("Максимално лице: " + maxAreaTriangle.area() + " - " + maxAreaTriangle.getClass().getName());

    System.out.println("Mинимално лице: " + minAreaRectangle.area() + " - " + minAreaRectangle.getClass().getName());

//    for(int i = 0;i<shapes.size();i++){
//        ...
//    }

//    shapes.forEach(item -> System.out.println(item.area()));

}

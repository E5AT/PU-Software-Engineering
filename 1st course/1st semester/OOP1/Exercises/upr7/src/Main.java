void main() {
    SchoolPerson school = new SchoolPerson();
    school.addPerson(new Student("Georgi", 'м', "0113687849", 6));
    school.addPerson(new Student("Elena", 'ж', "0928766035 ", 3.7));
    school.addPerson(new Student("Maria", 'ж', "0112453856", 5.4));

    school.addPerson(new Teacher("Vasil", 'м', "4676829059", 1000));
    school.addPerson(new Teacher("Desislava", 'ж', "9092664379", 900));
    school.addPerson(new Teacher("Stoyan", 'м', "9298560031", 1400));
    school.addPerson(new Teacher("Ivan",'м',"8298560031",1500));

    System.out.println("Girl student with the highest average grade:");
    school.findBestGirlStudent().print();

    System.out.println("\nAverage teacher salary:");
    System.out.println(school.calculateAverageSalaryOfTeacher());

    System.out.println("\nTeachers above average:");
    school.printTeacherAboveAverage();
}
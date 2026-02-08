import java.util.Comparator;
import java.util.LinkedList;
import java.util.stream.Stream;

public class SchoolPerson {
    LinkedList<Person> persons = new LinkedList<Person>();

    void addPerson(Person p) {
        persons.add(p);
    }

    Student findBestGirlStudent() {
        return
                (Student) persons.
                        stream().
                        filter(
                                p -> p instanceof Student
                                        &&
                                        p.gender == 'ж')
                        .max(Comparator.
                                comparingDouble(p -> ((Student) p).averageGrade))
                        .orElse(null);
    }

    double calculateAverageSalaryOfTeacher() {
        return
                persons.
                stream().
                filter(p -> p instanceof Teacher).
                mapToInt(p -> ((Teacher) p).salary).
                average().
                orElse(0.0);
    }

    void printTeacherAboveAverage(){
        persons.
        stream().
        filter(p ->
                p instanceof Teacher
                &&
                ((Teacher)p).salary>calculateAverageSalaryOfTeacher()).
        forEach(p -> ((Teacher)p).
        print());
    }


    void InvalidEGN(){
        pers
    }
}

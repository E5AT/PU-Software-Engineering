package school;

import java.util.LinkedList;

public class School {
    private LinkedList<Student> students;
    private LinkedList<Teacher> teachers;

    public void addStudent(Student s) {
        students.add(s);
    }

    public void printAllMembers() {
        System.out.println("Students:");
        for (Student s : students) {
            s.writeOutput();
            System.out.println();
        }

        System.out.println("Teachers:");
        for (Teacher t : teachers) {
            t.writeOutput();
            System.out.println();
        }
    }
}

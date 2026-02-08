public static int countMove = 0;

public static void move(int n, char start, char help, char goal) {
    if (n == 1) {
        System.out.println("От " + start + " на " + goal);
        countMove++;
    } else {
        move(n - 1, start, goal, help);
        System.out.println("От " + start + " на " + goal);
        countMove++;
        move(n - 1, help, start, goal);
    }
}

void main() {
    int n = 4;
    char start = 'a', help = 'b', goal = 'c';
    move(n, start, help, goal);
    System.out.println("Брой местения: " + countMove);
}
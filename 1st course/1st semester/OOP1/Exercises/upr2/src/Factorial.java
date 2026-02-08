public static int Factorial(int n) {
    if (n == 0 || n == 1) return 1;
    return n * Factorial(n - 1);
}

void main() {
    int n = 4;
    System.out.println(n + "! = " + Factorial(n));
}
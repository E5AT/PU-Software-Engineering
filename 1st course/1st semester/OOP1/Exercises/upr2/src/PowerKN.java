public static double power(int k, int n) {
    if (n == 0)
        return 1;
    double t = power(k, n / 2);
    if (n % 2 == 0)
        return t * t;
    return t * t * k;
}

void main() {
    int k = 3, n = 2;
    System.out.println(n + "**" + k + "=" + power(k, n));
}
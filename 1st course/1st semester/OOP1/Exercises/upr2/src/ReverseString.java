public static String Reverse(String s) {
    if (s == null || s.length() <= 1) {
        return s;
    }
    return Reverse(s.substring(1)) + s.charAt(0);
}

void main() {
    String word = "abcd";
    System.out.println(Reverse(word));
}
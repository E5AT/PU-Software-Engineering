void main() {
    String[] arr = {"dsa", "121212", "121wqwq", "1233", "abcdefchijk"};
    String ElMaxLength = "";
    for (String i : arr) {
        if (ElMaxLength.length() < i.length())
            ElMaxLength = i;
    }

//    String reversedMaxLengthEl = new StringBuilder(ElMaxLength).reverse().toString();

    String reversedMaxLengthEl = "";
    for (int i = ElMaxLength.length() - 1; i >= 0; i--) {
        reversedMaxLengthEl += ElMaxLength.charAt(i);
    }

    System.out.println(ElMaxLength + "\n" + reversedMaxLengthEl);
}
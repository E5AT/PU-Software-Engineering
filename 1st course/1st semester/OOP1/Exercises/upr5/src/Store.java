public void orderInfo(Product item) {
    item.showName();
    item.showLoc();
    System.out.println(item.BRAND + " " + item.PHONE);
    System.out.println(item.getPrice(50));
}

void main() {
    Book java = new Book();
    Shoes boti = new Shoes();

    orderInfo(java);
    System.out.println();
    orderInfo(boti);
}
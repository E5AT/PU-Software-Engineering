public class Shoes implements Product{

    @Override
    public String getPrice(int br) {
        if(br<5)
            return "Promociq";
        return "Nqma promociq";
    }

    @Override
    public void showName() {
        System.out.println("Obuvki");
    }

}

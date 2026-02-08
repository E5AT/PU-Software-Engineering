public class Book implements Product{

    @Override
    public String getPrice(int br) {
        if(br<100)
            return "Promociq";
        return "Nqma promociq";
    }

    @Override
    public void showName() {
        System.out.println("Kniga");
    }


    @Override
    public void showLoc() {
        System.out.println("America");
    }
}

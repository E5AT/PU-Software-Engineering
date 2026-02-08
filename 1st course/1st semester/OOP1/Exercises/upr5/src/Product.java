public interface Product extends Country{
    static final String BRAND = "My Corp.";
    String PHONE = "222 333 444";

    public abstract  String getPrice(int br);
    public void showName();
}

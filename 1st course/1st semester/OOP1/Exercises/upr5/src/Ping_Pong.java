public class Ping_Pong implements Runnable {

    String word;
    int time;

    public Ping_Pong(String word, int time) {
        this.word = word;
        this.time = time;
    }

    @Override
    public void run() {
        for (int i = 0; i < 5; i++) {
            System.out.println(word);
            try {
                Thread.sleep(time);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }

    public static void main() {
        Ping_Pong Ping = new Ping_Pong("Ping", 1000);
        Ping_Pong Pong = new Ping_Pong("\tPong", 2000);

        new Thread(Ping).start();
        new Thread(Pong).start();
    }
}
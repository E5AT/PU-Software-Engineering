public class PingPong extends Thread {

    String word;
    int time;

    public PingPong(String word, int time) {
        this.word = word;
        this.time = time;
    }

    public void run() {
        for (int i = 1; i < 5; i++)
            System.out.println(word);
        try {
            sleep(time);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

    public static void main() {
        new PingPong("Ping", 100).start();
        new PingPong("\tPong", 100).start();
    }
}
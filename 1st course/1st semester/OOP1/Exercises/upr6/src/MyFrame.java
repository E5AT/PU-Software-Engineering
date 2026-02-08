import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MyFrame extends JFrame {

    JButton button = new JButton("Show");
    JTextField field = new JTextField(20);

    public MyFrame(){
        this.setSize(400,600);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setLayout(new FlowLayout());

        this.add(button);
        this.add(field);

        button.addActionListener(new ButtonAction());

        this.setVisible(true);
    }

    class ButtonAction implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            System.out.println(field.getText());
        }
    }
}

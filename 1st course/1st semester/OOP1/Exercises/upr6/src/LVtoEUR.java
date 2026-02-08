import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

public class LVtoEUR extends JFrame {
    JPanel
            labelsAndTextFields = new JPanel(),
            buttons = new  JPanel();

    JLabel
            bgnLabel = new JLabel("BGN"),
            eurLabel = new JLabel("EUR"),
            course = new JLabel("Course");

    JTextField
            bgnTF = new JTextField(),
            eurTF = new JTextField(),
            courseTF = new JTextField("1.95583");

    JButton
            showButton = new JButton("Show"),
            deleteButton = new JButton("Delete");

    public LVtoEUR() {
        this.setSize(300, 400);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);

        this.setLayout(new BorderLayout());

        labelsAndTextFields.setLayout(new GridLayout(3, 2));
        labelsAndTextFields.add(bgnLabel);
        labelsAndTextFields.add(bgnTF);
        labelsAndTextFields.add(eurLabel);
        labelsAndTextFields.add(eurTF);
        labelsAndTextFields.add(course);
        labelsAndTextFields.add(courseTF);
        courseTF.setEditable(false);

        buttons.setLayout(new GridLayout(1,2));
        buttons.add(showButton);
        buttons.add(deleteButton);

        this.add(labelsAndTextFields, BorderLayout.CENTER);
        this.add(buttons, BorderLayout.SOUTH);

        showButton.addActionListener(new ShowButtonAction());
        deleteButton.addMouseListener(new DeleteButtonAction());


        this.setVisible(true);
    }

    class ShowButtonAction implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            double course = Double.parseDouble(courseTF.getText());

            if (bgnTF.getText().isEmpty()) {
                double eur = Double.parseDouble(eurTF.getText());
                bgnTF.setText("" + eur / course);
            }

            else if (eurTF.getText().isEmpty()) {
                double bgn = Double.parseDouble(bgnTF.getText());
                eurTF.setText(String.valueOf(bgn * course));
            }
        }
    }

    class DeleteButtonAction implements MouseListener{

        @Override
        public void mouseClicked(MouseEvent e) {

        }

        @Override
        public void mousePressed(MouseEvent e) {

        }

        @Override
        public void mouseReleased(MouseEvent e) {

        }

        @Override
        public void mouseEntered(MouseEvent e) {
            bgnTF.setText("");
            eurTF.setText("");
        }

        @Override
        public void mouseExited(MouseEvent e) {

        }
    }
}

package Bomberman;

//import java.awt.Color;
//import javax.swing.JPanel;
import javax.swing.JFrame;

public class Fenetre extends JFrame {
  public Fenetre(){
    this.setTitle("Bomberboy");
    this.setSize(400, 500);
    this.setLocationRelativeTo(null);
//    JPanel pan = new JPanel();
//    this.setContentPane(pan);
    this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);   
    this.setContentPane(new Panneau());
    this.setVisible(true);
  }
}
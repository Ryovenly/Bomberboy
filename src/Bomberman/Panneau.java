package Bomberman;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;
import javax.swing.JPanel;
 
public class Panneau extends JPanel {
  public void paintComponent(Graphics g){
    try {
      Image img = ImageIO.read(new File("Map.png"));
      g.drawImage(img, 0, 0, this.getWidth(), this.getHeight(), this);
      //Pour une image de fond
      //g.drawImage(img, 0, 0, this.getWidth(), this.getHeight(), this);
      Font font = new Font("Courier", Font.BOLD, 20);
      g.setFont(font);
      g.setColor(Color.black);          
      g.drawString("Que le jeu commence !", 80, 180);
    } catch (IOException e) {
      e.printStackTrace();
    }                
  }               
}

import java.io.FileInputStream;
import java.io.ObjectInputStream;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class RecuperarUsuario {
    
    public static void main(String[] args) {
        try {
            FileInputStream file = new FileInputStream("ficherosalida.dat");
            ObjectInputStream object = new ObjectInputStream(file);
            
            for (int i = 0; i < 100; i++) {
                Usuario user = (Usuario) object.readObject();
                System.out.println(user.toString());
            }
        } catch (Exception e) {
            System.out.println(e);
        }
    }
    
}

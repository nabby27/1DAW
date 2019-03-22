
import java.io.FileOutputStream;
import java.io.ObjectOutputStream;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class InsertarUsuario {
    
    public static void main(String[] args) {
        try {
            FileOutputStream file = new FileOutputStream("ficherosalida.dat");
            ObjectOutputStream object = new ObjectOutputStream(file);
            for (int i = 0; i < 100; i++) {
                Usuario user = new Usuario("Iván", (i + 1) +"");
                System.out.println(user.toString());
                object.writeObject(user);
            }
        } catch (Exception e) {
            System.out.println(e);
        }
        
        
    }
    
}

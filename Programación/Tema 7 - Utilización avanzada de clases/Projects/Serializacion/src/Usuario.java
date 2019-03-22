
import java.io.Serializable;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Usuario implements Serializable {
    
    public String nombre;
    public String password;

    public Usuario(String nombre, String password) {
        this.nombre = nombre;
        this.password = password;
    }

    @Override
    public String toString() {
        return "Usuario{" + "nombre=" + nombre + ", password=" + password + '}';
    }
    
}

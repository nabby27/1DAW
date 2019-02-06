package ClasesSeparadas;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Oficial extends Operario {

    public Oficial() {
    }

    public Oficial(String nombre) {
        super(nombre);
    }

    public Oficial(String nombre, int telefono) {
        super(nombre, telefono);
    }

    @Override
    public String toString() {
        return "Oficial{nombre=" + getNombre() + ", telefono=" + getTelefono() + '}';
    }
    
}

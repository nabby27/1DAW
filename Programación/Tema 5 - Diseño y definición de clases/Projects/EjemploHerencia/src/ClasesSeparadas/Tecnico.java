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
public class Tecnico extends Operario{

    public Tecnico() {
    }

    public Tecnico(String nombre) {
        super(nombre);
    }

    public Tecnico(String nombre, int telefono) {
        super(nombre, telefono);
    }

    @Override
    public String toString() {
        return "Tecnico{nombre=" + getNombre() + ", telefono=" + getTelefono() + '}';
    }
    
}

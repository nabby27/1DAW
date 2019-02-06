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
public class Operario extends Empleado {

    private int telefono;
    
    public Operario() {
    }

    public Operario(String nombre) {
        super(nombre);
    }

    public Operario(String nombre, int telefono) {
        super(nombre);
        this.telefono = telefono;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    @Override
    public String toString() {
        return "Operario{nombre=" + getNombre() + ", telefono=" + telefono + '}';
    }
    
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ02ArrayList.Agenda;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Contacto {
    
    private String nombre;
    private String telefono;
    private String dni;

    public Contacto() {
    }

    public Contacto(String nombre, String telefono, String dni) {
        this.nombre = nombre;
        this.telefono = telefono;
        this.dni = dni;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    @Override
    public String toString() {
        return dni + "," + nombre + "," + telefono;
    }
    
    public String formatString(Integer index) {
        return "\nIndice: " + index + "\nDni: " + dni + "\nNombre: " + nombre + "\nTelefono: " + telefono;
    }
    
}

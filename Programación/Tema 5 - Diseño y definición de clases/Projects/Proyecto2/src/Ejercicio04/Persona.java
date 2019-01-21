/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio04;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Persona {
    
    private String nombre;
    private int edad;
    private int telefono;

    public Persona() {
    }

    public Persona(String nombre, int edad, int telefono) {
        this.nombre = nombre;
        this.edad = edad;
        this.telefono = telefono;
    }
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    @Override
    public String toString() {
        return "Persona{" + "nombre=" + nombre + ", edad=" + edad + ", telefono=" + telefono + '}';
    }
    
}

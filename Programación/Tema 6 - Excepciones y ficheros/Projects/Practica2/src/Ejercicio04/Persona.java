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
    
    private int edad;

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) throws Exception {
        if (edad < 0 || edad > 100)
            throw new Exception("Edad incorrecta");
        this.edad = edad;
    }

    @Override
    public String toString() {
        return "Edad: " + edad;
    }
    
}

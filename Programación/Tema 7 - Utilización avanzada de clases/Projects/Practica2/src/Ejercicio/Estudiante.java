/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Estudiante extends Persona {
    
    private int curso;

    public Estudiante() {
        super();
    }

    public Estudiante(String nombre, String identificacion, int curso) {
        super(nombre, identificacion);
        this.curso = curso;
    }
    
    public void consultarCurso() {
        System.out.println(this.curso);
    }
    
    public void pasarCurso() {
        this.curso++;
    }
    
    @Override
    public String obtenerCarnet() {
        return    "Estudiante \n"
                + "========== \n"
                + super.obtenerCarnet() + "\n"
                + "Curso: " + this.curso + "\n";
    }
    
}

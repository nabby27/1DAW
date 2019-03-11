/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio05;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Alumno {
    
    private int np;
    private String nombre;
    private double nota1;
    private double nota2;

    public Alumno(int np, String nombre) {
        this.np = np;
        this.nombre = nombre;
    }
    
    public void ponNota(double nota1, double nota2) {
        this.nota1 = nota1;
        this.nota2 = nota2;
    }
    
    public double dameMedia() {
        return (this.nota1 + this.nota2) / 2;
    }
    
    public String muestraAlumno() {
        return "NP: " + this.np + ", Nombre: " + this.nombre + ", Media: " + this.dameMedia();
    }
    
}

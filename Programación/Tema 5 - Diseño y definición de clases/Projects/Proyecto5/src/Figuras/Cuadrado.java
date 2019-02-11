/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Figuras;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Cuadrado {
    
    protected int lado;

    public Cuadrado(int lado) {
        this.lado = lado;
    }
    
    public int calcularArea() {
        return this.lado * this.lado;
    }
    
    public int getLado() {
        return lado;
    }

    public void setLado(int lado) {
        this.lado = lado;
    }
    
}

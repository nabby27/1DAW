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
public class Rectangulo extends Cuadrado {
    
    private int lado2;

    public Rectangulo(int lado2, int lado) {
        super(lado);
        this.lado2 = lado2;
    }
    
    @Override
    public int calcularArea() {
        return lado * this.lado2;
    }

    public int getLado2() {
        return lado2;
    }

    public void setLado2(int lado2) {
        this.lado2 = lado2;
    }
    
}

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
public class Cubo extends Cuadrado {
    

    public Cubo(int lado) {
        super(lado);
    }
    
    @Override
    public int calcularArea() {
        return lado * lado * 6;
    }
    
}

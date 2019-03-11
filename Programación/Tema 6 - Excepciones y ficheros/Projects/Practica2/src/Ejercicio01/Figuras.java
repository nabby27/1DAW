/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio01;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Figuras {
    
    private int nLados;
    private double base;
    private double altura;

    public Figuras(double base, int nLados) {
        this.base = base;
        this.altura = base;
        this.nLados = nLados;
    }
    
    public Figuras(double base, double altura, int nLados) {
        this.base = base;
        this.altura = altura;
        this.nLados = nLados;
    }
    
    public double damePerimetro() {
        if (nLados == 4)
            return base * 2 + altura * 2;
        else 
            return 0;
    }
    
    public double dameArea() {
        if (nLados == 4)
            return base * altura;
        else
            return (base * altura) / 2;
    }
    
}

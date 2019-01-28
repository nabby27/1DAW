/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio03;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        Punto p1 = new Punto();
        Punto p2 = new Punto(5, 3);
        Punto p3 = new Punto(2, -1);
        Punto p4 = new Punto((p2.getAltitud()+p3.getAltitud())/2, (p2.getLatitud()+p3.getLatitud())/2);
        System.out.println(p1.toString());
        System.out.println(p2.toString());
        System.out.println(p3.toString());
        System.out.println(p4.toString());
    }
    
}

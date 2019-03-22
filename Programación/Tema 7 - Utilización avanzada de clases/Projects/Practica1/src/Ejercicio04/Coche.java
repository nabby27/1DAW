/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio04;

/**
 *
 * @author Iván Córodba Donet
 */
public class Coche extends Vehiculo {

    public Coche() {
        super(4, 4);
        System.out.println("Soy un coche");
    }
    
    public void cierraPuertas() {
        System.out.println("Cierro las puertas");
    }
    
    @Override
    public void conducir() {
        cierraPuertas();
        super.conducir();
    }
    
}

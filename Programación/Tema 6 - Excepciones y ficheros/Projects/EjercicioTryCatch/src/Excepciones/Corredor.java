/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Excepciones;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Corredor {
    
    private int energia;

    public Corredor(int energia) {
        this.energia = energia;
    }
    
    public void recargarEnergia(int energia) {
        this.energia = energia;
    }
    
    public void correr() throws Exception {
        System.out.println("Corriendo");
        if (this.energia >= 10) {
            this.energia -= 10;
        } else {
            throw new Exception("Agotado Exception");
        }
    }
            
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio2;

import java.util.ArrayList;

/**
 *
 * @author Iván Córdoba Donet
 */
public class RedPantanos {
    
    public static void main(String[] args) {
        ArrayList<Pantano> pantanos = new ArrayList<Pantano>();
        setPantanos(pantanos);
        
        for (Pantano pantano : pantanos) {
            System.out.println(pantano.toString());
        }
    }
    
    private static void setPantanos(ArrayList<Pantano> pantanos) {
        Pantano pantano1 = new Pantano("A", 20, 7);
        Pantano pantano2 = new Pantano("B", 15, 4);
        Pantano pantano3 = new Pantano("C", 27, 6);
        
        pantanos.add(pantano1);
        pantanos.add(pantano2);
        pantanos.add(pantano3);
    }
    
}

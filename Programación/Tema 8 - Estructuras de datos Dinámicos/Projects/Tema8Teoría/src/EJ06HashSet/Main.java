/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ06HashSet;

import java.util.HashSet;
import java.util.Iterator;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        HashSet hashSet = new HashSet();
        hashSet.add("Lunes");
        hashSet.add("Martes");
        hashSet.add("Miercoles");
        hashSet.add("Jueves");
        hashSet.add("Viernes");
        hashSet.add("Sabado");
        hashSet.add("Sabado");
        hashSet.add("Sabado");
        hashSet.add("Domingo");
        
        System.out.println("La semana desordenada sin repetir elementos");
        for (Object dia : hashSet) {
            System.out.println(dia);
        }
        
    }
    
}

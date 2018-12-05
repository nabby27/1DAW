/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio02;

import java.util.ArrayList;
import java.util.Random;

/**
 *
 * @author Iván Córdoba Donet
 */
public class TerminacioNNumeros {
    
    public static void main(String[] args) {
        
        ArrayList<Integer> numeros = new ArrayList<Integer>();
        ArrayList<Integer> v = new ArrayList<Integer>();
        Random rnd = new Random();
        int num = 0;
        int count = 0;
        
        for (int i = 0; i < 16; i++) {
            num = rnd.nextInt(100);
            numeros.add(num);
        }
        System.out.println(numeros);
        for (int i = 0; i < 10; i++) {
            count = 0;
            v = new ArrayList<Integer>();
            for (int j = 0; j < numeros.size()-1; j++) {
                if (i == numeros.get(j) % 10) {
                    v.add(numeros.get(j));
                    count++;
                }
            }
            System.out.println("Terminación: " + i + " total: " + count + " números: " + v);
        }
    }
    
}

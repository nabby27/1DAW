
import java.util.ArrayList;
import java.util.Random;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio07 {
    
    private static final int totalElementos = 10;
    
    public static void main(String[] args) {
    
        Random rnd = new Random(); 
        int random = 0;
        ArrayList<Integer> numeros = new ArrayList<Integer>();
        ArrayList<Integer> numeros2 = new ArrayList<Integer>();
                
        for (int i = 0; i < totalElementos; i++) {
            System.out.println("Dime un número");
            random = rnd.nextInt(101);
            numeros.add(i, random);
            System.out.println(numeros.get(i));
        }
        
        System.out.println();
               
        for (int i = 0; i < numeros.size(); i++) {
            int suma = 0;
            for (int j = 0; j < i; j++) {
                suma += numeros.get(j);
            }
            numeros2.add(suma); 
        }
                
        System.out.println("Original: " + numeros);
        System.out.println("Modificado: " + numeros2);
    }
    
}

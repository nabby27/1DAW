
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
public class Ejercicio11 {
    
    private static final int totalElementos = 10;
    
    public static void main(String[] args) {
                
        Random rnd = new Random(); 
        int random = 0;
        int mayor = 0;
        int menor = 10;
        ArrayList<Integer> numeros = new ArrayList<Integer>();
        
        for (int i = 0; i < totalElementos; i++) {
            System.out.println("Dime un número");
            random = rnd.nextInt(11);
            numeros.add(i, random);
            System.out.println(numeros.get(i));
        }
        
        for (Integer num : numeros) {
            if (num < menor)
                menor = num;
            if (num > mayor)
                mayor = num;
        }
        
        System.out.println("El mayor es: " + mayor);
        System.out.println("El menor es: " + menor);
    }
    
}

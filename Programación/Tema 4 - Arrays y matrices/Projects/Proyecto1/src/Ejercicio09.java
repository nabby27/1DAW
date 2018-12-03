
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
public class Ejercicio09 {
    
    private static final int totalElementos = 10;
    
    public static void main(String[] args) {
                
        Random rnd = new Random(); 
        int random = 0;
        int cont = 0;
        ArrayList<Integer> numeros = new ArrayList<Integer>();
                
        for (int i = 0; i < totalElementos; i++) {
            System.out.println("Dime un número");
            random = rnd.nextInt(11);
            numeros.add(i, random);
            System.out.println(numeros.get(i));
        }
        System.out.println("");
        System.out.println("Dime un número para buscar si esta en el array:");
        random = rnd.nextInt(11);
        System.out.println(random);
        
        for (Integer num : numeros) {
            if (num == (Integer)random) {
                cont++;
            }
        }
            
        System.out.println("Hay " + cont + " numeros que son " + random);
         
        //System.out.println("Los numeros no introducidos son: " + numerosNoIntroducidos);           
    }
    
}

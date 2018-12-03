
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
public class Ejercicio08 {
    
    private static final int totalElementos = 10;
    static ArrayList<Integer> numerosNoIntroducidos = new ArrayList<Integer>();
    
    public static void main(String[] args) {
        
        addNumerosNoIntroducidos();
        
        Random rnd = new Random(); 
        int random = 0;
        ArrayList<Integer> numeros = new ArrayList<Integer>();
                
        for (int i = 0; i < totalElementos; i++) {
            System.out.println("Dime un número");
            random = rnd.nextInt(11);
            numeros.add(i, random);
            if (numerosNoIntroducidos.contains((Integer)random))
                numerosNoIntroducidos.remove((Integer)random);
            System.out.println(numeros.get(i));
        }
        
        System.out.println();
         
        System.out.println("Los numeros no introducidos son: " + numerosNoIntroducidos);           
    }
    
    private static void addNumerosNoIntroducidos() {
        numerosNoIntroducidos.add(1);
        numerosNoIntroducidos.add(2);
        numerosNoIntroducidos.add(3);
        numerosNoIntroducidos.add(4);
        numerosNoIntroducidos.add(5);
        numerosNoIntroducidos.add(6);
        numerosNoIntroducidos.add(7);
        numerosNoIntroducidos.add(8);
        numerosNoIntroducidos.add(9);
        numerosNoIntroducidos.add(0);
    }
    
}

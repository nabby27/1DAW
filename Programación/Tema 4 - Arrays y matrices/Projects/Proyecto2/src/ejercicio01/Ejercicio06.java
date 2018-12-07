/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio01;

import java.util.ArrayList;
import java.util.Random;


/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio06 {
       
    public static void main(String[] args) {
        
        int num = 0;
        Random rnd = new Random();
        boolean capicua = false;
        ArrayList<Integer> numeros = new ArrayList<Integer>();
        
        for (int i = 0; i < 3; i++) {
            num = rnd.nextInt(10);
            numeros.add(num);
        }
        System.out.println(numeros);
        if (numeros.get(0) == numeros.get(2)){
            capicua = true;
        }
        
        if (capicua)
            System.out.println("Es capicua");
        else
            System.out.println("No es capicua");
    }
    
}

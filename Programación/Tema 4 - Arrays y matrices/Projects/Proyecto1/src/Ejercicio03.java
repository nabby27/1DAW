
import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio03 {
    
    private static final int totalElementos = 31;
    
    public static void main(String[] args) {
    
        Random rnd = new Random(); 
        int[] temperaturasEnero = new int[totalElementos];
        ArrayList<Integer> temperaturasSuperioresMedia = new ArrayList<Integer>();
        int menor = 0;
        int suma = 0;
        int media = 0;
                
        for (int i = 0; i < temperaturasEnero.length; i++) {
            System.out.println("Dime la temperatura del dia " + (i+1));
            temperaturasEnero[i] = rnd.nextInt(41);
            suma += temperaturasEnero[i];
            System.out.println(temperaturasEnero[i]);
        }
        
        System.out.println();
        media = suma / totalElementos;
        
        for (int i = 0; i < temperaturasEnero.length; i++) {
            if (i == 0) {
                menor = i;
            }
            else if (temperaturasEnero[i] < temperaturasEnero[menor]) {
                menor = i;
            }
            
            if (temperaturasEnero[i] > media) {
                temperaturasSuperioresMedia.add(temperaturasEnero[i]);
            }
        }
        
        System.out.println("El menor es " + temperaturasEnero[menor] + " que esta en el indice " + menor);
        System.out.println("La media de la temperatura es " + media);
        System.out.println("Las temperaturas por encima de la media son: ");
        for (int i = 0; i < temperaturasSuperioresMedia.size(); i++) {
            if (i == 0) 
                System.out.print(temperaturasSuperioresMedia.get(i));
            else 
                System.out.print(", " + temperaturasSuperioresMedia.get(i));
        }
        System.out.println("");
        System.out.println("En total hay " + temperaturasSuperioresMedia.size() + " dias con temperaturas superiores a la media");
        
    }
    
}


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
public class Order {
    
    static int[] numeros = new int[1000];
    static int[] numerosOrdenados = new int[numeros.length];
        
    public static void main(String[] args) {
        
        Random rnd = new Random();
        for (int i = 0; i < numeros.length; i++) {
            numeros[i] = rnd.nextInt(10000);
        }
        
        int numeroMenor = 0;
        int numeroMayor = 0;
        int lastNumberAdded = 0;
        int count = 0;
        
        for (int i = 0; i < numeros.length; i++) {
            if (i == 0 || numeros[i] < numeroMenor) {
                numeroMenor = numeros[i];
            } 
            if (i == 0 || numeros[i] > numeroMayor) {
                numeroMayor = numeros[i];
            }
        }
        
        lastNumberAdded = numeroMenor;
        
        for (int j = numeroMenor; j <= numeroMayor; j++) {
            for (int i = 0; i < numeros.length; i++) {
                if (j == numeros[i]){
                    numerosOrdenados[count] = j;
                    count++;
                }
            }
        }
        
        paint();
        
    }
    
    private static void paint() {
        System.out.print("Numeros: ");
        for (int numero : numeros) {
            System.out.print(numero + " ");
        }
        System.out.println("");
        System.out.print("Numeros ordenados: ");
        for (int numero : numerosOrdenados) {
            System.out.print(numero + " ");
        }
        System.out.println("");
    }
}

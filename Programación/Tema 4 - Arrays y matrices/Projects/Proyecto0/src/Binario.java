
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
public class Binario {
    
    static int numBinary = 2;
    
    public static void main(String[] args) {
        
        int num = 0;
        Scanner sc = new Scanner(System.in);
        
        do {
            System.out.println("Introduce un número entero no negativo");
            num = sc.nextInt();
            if (num < 0)
                System.out.println("El número no esta en el rango");
        } while (num < 0);
        
        obtenerBinario(num);
    }
    
    private static void obtenerBinario(int num) {
        int x = num;
        String binaryReverse = "";
        String binary = "";
        long TInicio = 0;
        long TFin = 0;
        
        while(x >= numBinary) {
           binaryReverse += x % numBinary +"";
           x = x / numBinary;
        }
        
        binary = (num == 0) ? "0" : "1";
        
        for (int i = binaryReverse.length(); i > 0 ; i--) {
            binary += binaryReverse.charAt(i-1);
        }
                        
        System.out.println(binary);
    }
    
}


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
        
    public static void main(String[] args) {
        
        int altura = 0;
        int base = 0;
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Dime la altura");
        altura = sc.nextInt();
        System.out.println("Dime la base");
        base = sc.nextInt();
        
        rectanguloCeros(base, altura);
    }
    
    private static void rectanguloCeros(int base, int altura) {
        System.out.println("");
        for (int i = 1; i <= altura; i++) {
            for (int j = 1; j <= base; j++) {
                if (i % 2 == 0)
                    System.out.print(i);
                else
                    System.out.print("0");
            }
            System.out.println("\n");
        }
    }
    
}

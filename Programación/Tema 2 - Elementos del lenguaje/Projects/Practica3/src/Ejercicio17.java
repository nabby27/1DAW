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
public class Ejercicio17 {
        
    public static void main(String[] args) {
        
        int a = 0;
        int b = 0;
        int  cantidadPares = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("Dime el númera 'A': ");
        a = teclado.nextInt();
        System.out.println("Dime el númera 'B': ");
        b = teclado.nextInt();
        
        System.out.println("Cuenta desde " + a + " hasta " + b + ":");
        for (int x = a; x <= b; x++) {
            System.out.println(x);
            if (x % 2 == 0)
                cantidadPares++;
        }
        System.out.println("Hay " + cantidadPares + " números pares");
    }
    
}

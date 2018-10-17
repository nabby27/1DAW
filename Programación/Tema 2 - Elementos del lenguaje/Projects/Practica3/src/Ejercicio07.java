import java.util.ArrayList;
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
public class Ejercicio07 {
    
    public static void main(String[] args) {
        
        int num = 0;
        int resulta = 0;
        ArrayList factores= new ArrayList<>();
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número: ");
            num = teclado.nextInt();
            if (num < 0) 
                System.out.println("El número tiene que ser positivo");
        } while(num < 0);
        resulta = num;
        for (int x = 2; x <= resulta; x++) {
            if (resulta % x == 0) {
                resulta = (resulta / x);
                factores.add(x);
                x--;
            }   
        }
        if (num == 1)
            System.out.println(num + " = " + num);
        else {
            System.out.print(num + " = ");
            for (Integer x = 0; x < factores.size(); x++) {
                if (x != 0)
                    System.out.print(" * ");
                System.out.print(factores.get(x));
            }
            System.out.println("");
        }
        
    }
    
}


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
public class Ejercicio08 {
    
    public static void main(String[] args) {
        
        int n1 = 0;
        String n2 = "";
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el número N1:");        
        n1 = teclado.nextInt();
        
        n2 = n1 + "";
        if (n2.length() > 2)
            n2 = n2.substring(1, n2.length()-1);
        else
            n2 = "0";
        System.out.println("N2 = " + n2);
    }
    
}

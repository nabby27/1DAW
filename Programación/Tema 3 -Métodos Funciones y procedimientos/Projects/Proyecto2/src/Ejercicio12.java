
import java.util.ArrayList;
import java.util.List;
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
public class Ejercicio12 {
        
    public static void main(String[] args) {
        
        for (int i = 1; i <= 500; i++) {
            System.out.print(i + "-> ");
            perfecto(i);
        }
        
    }
    
    private static void perfecto(int num) {
        int sumaDivisores = 0;
        List divisores = new ArrayList<>();
        for (int i = 1; i < num; i++) {
            if (num % i == 0) {
                sumaDivisores += i;
                divisores.add(i);
            }
        }
        if (sumaDivisores == num) {
            System.out.print("Es perfecto: ");
            for (int i = 0; i < divisores.size(); i++) {
                if (i == 0)
                    System.out.print(divisores.get(i));
                else
                    System.out.print(" + " + divisores.get(i));
            }
            System.out.println("");
        } else 
            System.out.println("No es perfecto");
    }
}

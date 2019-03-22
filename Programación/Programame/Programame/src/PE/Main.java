/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PE;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author TeProgramo
 */
public class Main {

    static ArrayList<Integer> binary = new ArrayList<Integer>();
    static int numberOf1 = 0;
    
    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        int numOfNumbers = sc.nextInt();
        
        for (int i = 0; i < numOfNumbers; i++) {
            int num = sc.nextInt();
            getBinaryNumber(num);
            countBinary1();
            checkIfIsEvil();
        }
        
    }

    private static void getBinaryNumber(int numero) {
        binary = new ArrayList<Integer>();
        int resto;

        do {
            resto = numero % 2;
            numero = numero / 2;
            binary.add(0, resto);
        } while (numero > 1);

        binary.add(0, numero);
    }

    private static void countBinary1() {
        numberOf1 = 0;
        for (Integer number : binary) {
            if (number == 1) {
                numberOf1++;
            }
        }
    }
    
    private static void checkIfIsEvil() {
        if (numberOf1 % 2 == 0)
            System.out.println("MALVADO");
        else
            System.out.println("NO MALVADO");
    }
        
}

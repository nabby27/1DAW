
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
public class Ejercicio02 {
    
    public static void main(String[] args) {
        
        int num = 0;
        String romano = "";
        int miles = 0, centenas = 0, decenas = 0, unidades = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número positivo: ");
            num = teclado.nextInt();
            if (num < 0 || num > 3999)
                System.out.println("el número tiene que ser positivo menor de 4000");
        } while (num < 0 || num > 3999);
        
        miles = num / 1000;
        centenas = num / 100 % 10;
        decenas = num / 10 % 10;
        unidades = num % 10;
        
        for (int x = 0; x < miles; x++) {
            romano = romano + "M";
        }
        
        if (centenas == 9) {
            romano = romano + "CM";
        } else if (centenas >= 5) {
            romano = romano + "D";
            for (int i = 5; i < centenas; i++) {
                romano = romano + "C";
            }
        } else if (centenas == 4) {
            romano = romano + "CD";
        } else {
            for (int i = 0; i < centenas; i++) {
                romano = romano + "C";
            }
        }
        
        if (decenas == 9) {
           romano = romano + "XC";
        } else if (decenas >= 5) {
            romano = romano + "L";
            for (int i = 5; i < decenas; i++) {
                romano = romano + "X";
            }
        } else if (decenas == 4) {
            romano = romano + "XL";
        } else {
            for (int i = 0; i < decenas; i++) {
                romano = romano + "X";
            }
        }
        
        if (unidades == 9) {
           romano = romano + "IX";
        } else if (unidades >= 5) {
            romano = romano + "V";
            for (int i = 5; i < unidades; i++) {
                romano = romano + "I";
            }
        } else if (unidades == 4) {
            romano = romano + "IV";
        } else {
            for (int i = 0; i < unidades; i++) {
                romano = romano + "I";
            }
        }
        
        System.out.println(romano);
    }
}

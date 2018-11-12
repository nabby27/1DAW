
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
public class Ejercicio11 {
    
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);
        float numero = 0;
        int opcion = 0;
        
        System.out.println("Dime un número");
        numero = keyboard.nextFloat();
        
        System.out.println("Elige una opción");
        System.out.println("----------------");
        System.out.println("1. Redondear");
        System.out.println("2. Saber si es primo");
        System.out.println("3. Saber si es capicua");
        System.out.println("4. Suma de los divisores");
        System.out.println("5. Salir");
        opcion = keyboard.nextInt();
        System.out.println("");
        
        operacion(numero, opcion);
    }
    
    private static void operacion(float numero, int opcion) {
        switch(opcion){
            case 1:
                System.out.println("El redondeo de " + numero + " es: " + Math.round(numero));
                break;
            case 2:
                primo(numero);
                break;
            case 3:
                capicua(numero);
                break;
            case 4:
                sumaDivisores(numero);
                break;
            case 5:
                System.exit(0);
                break;
            default:
                break;
        }
    }
    
    private static void primo(float numero) {
        numero = Math.round(numero);
        boolean primo = true;
        for (int i = 2; i < numero; i++) {
            if (numero % i == 0) {
                primo = false;
            }
        }
        if (primo) {
            System.out.println("El número " + numero + " es primo");
        } else {
            System.out.println("El número " + numero + " no es primo");
        }
    }
    
    private static void capicua(float numero) {
        numero = Math.round(numero);
        String numeroSt = numero + "";
        String reverseNumeroSt = "";
        
        for (int i = 0; i < numeroSt.length(); i++) {
            reverseNumeroSt += numeroSt.charAt(i);
        }
        
        if (reverseNumeroSt.equals(numeroSt)) {
            System.out.println("El número " + numero + " és capicua");
        } else {
            System.out.println("El número " + numero + " no és capicua");
        }
    }
    
    public static void sumaDivisores(float numero) {
        numero = Math.round(numero);
        int divisores = 0;
        for (int i = 1; i <= numero; i++) {
            if (numero % i == 0) {
                divisores += i;
            }
        }
        
        System.out.println("La suma de los divisores del numero " + numero + " es: " + divisores);
    }
    
}

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
public class Ejercicio02a {
    
    public static void main(String[] args) {
        
        int num1 = 0;
        char operador = 'a';
        int num2 = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el valor del primer número: ");
        num1 = teclado.nextInt();
        System.out.print("Dime el operando (+, -, *, /): ");
        operador = teclado.next().charAt(0);
        System.out.print("Dime el valor del segundo número: ");
        num2 = teclado.nextInt();
        
        switch (operador){
            case '+':
                System.out.println("El resultado es: " + (num1 + num2));
                break;
            case '-':
                System.out.println("El resultado es: " + (num1 - num2));
                break;
            case '*':
                System.out.println("El resultado es: " + (num1 * num2));
                break;
            case '/':
                System.out.println("El resultado es: " + (num1 / num2));
                break;
            default:
                System.out.println("El operador es incorrecto");
        }
                    
    }
    
}

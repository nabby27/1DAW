
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
public class Ejercicio08a {
        
    public static void main(String[] args) {
        
        int num = 0;
        char character = 'a';
        Scanner keyboard = new Scanner(System.in);
        
        System.out.println("Que letra quieres imprimir?");
        character = keyboard.next().charAt(0);
        
        System.out.println("Cuantas veces repetirlo?");
        num = keyboard.nextInt();
        
        triangulo(character, num);
    }
    
    private static void triangulo(char a, int b) {
        for(int i = 1; i <= b; i++) {
            //Espacios en blanco
            for(int j = 1; j <= b-i; j++){
                System.out.print(" ");
            }
            //Asteriscos
            for(int j = 1; j <= (i*2)-1; j++){
                System.out.print(a);
            }
            System.out.println();
        }
    }
    
}

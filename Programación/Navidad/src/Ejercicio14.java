
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
public class Ejercicio14 {
    
    public static void main(String[] args) {
        String frase = "";
        
        pedirFrase(frase);
        
        
    }
    
    private static void pedirFrase(String frase) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Escribe una frase:");
        frase = sc.nextLine();
    }
    
    private static void suprimirBlancos(String frase) {
        frase = frase.replace(" ", "");
    }
    
    private static void cambiarCaracteres(String frase) {
        Scanner sc = new Scanner(System.in);
        String caracter = "";
        System.out.println("Dime el carácter por el cual quieres remplazar las vocales");
        caracter = sc.nextLine();
        //caraceter = caracter.charAt(0);
        frase = frase.replace(" ", "");
    }
    
}

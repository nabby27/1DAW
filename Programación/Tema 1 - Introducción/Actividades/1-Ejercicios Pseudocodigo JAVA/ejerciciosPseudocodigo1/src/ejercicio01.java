
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
public class ejercicio01 {
    
    public static void main(String[] args) {
        System.out.println("AREA DEL TRIANGULO");
        System.out.print("Dime el valor de la base:");
        Scanner teclado = new Scanner(System.in);
        float base = teclado.nextShort();
        System.out.print("Dime el valor de la altura:");
        float altura = teclado.nextShort();
        System.out.println("El area es: " + (base * altura) / 2);
    }
}

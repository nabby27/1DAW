
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author AlumMati
 */
public class Ejercicio07 {
    
    public static void main(String[] args) {
        
        int num = 0;
        int nuevoNum = 0;
        int aceptados = 0;
        int fallos = 0;
        int totalNumeros = 0;
        Scanner teclado = new Scanner(System.in);
        
        do{
            System.out.print("Introduce un número:");
            nuevoNum = teclado.nextInt();
            if (num == 0)
                System.out.println("Cerrando");
            else {
                if (num > nuevoNum) {
                    num = nuevoNum;
                    aceptados++;
                }
            }
        } while(num != 0);
        
        
    }
    
}

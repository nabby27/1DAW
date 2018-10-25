
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
public class Ejercicio07 {
    
    public static void main(String[] args) {
        
        int num = 0;
        int nuevoNum = 0;
        int aceptados = 0;
        int fallos = 0;
        int totalNumeros = 0;
        String numerosAceptados = "";
        Scanner teclado = new Scanner(System.in);
        
        do{
            System.out.print("Introduce un número:");
            nuevoNum = teclado.nextInt();
            if (nuevoNum == 0) {
                System.out.println("Cerrando");
                System.out.println("Aceptados: " + numerosAceptados);
                System.out.println("Total números: " + totalNumeros);
                System.out.println("Fallos: " + fallos);
            } else {
                if (nuevoNum > num) {
                    num = nuevoNum;
                    if (numerosAceptados == "")
                        numerosAceptados += num;
                    else
                        numerosAceptados += ", " + num;
                    aceptados++;
                } else {
                    fallos++;
                }
                totalNumeros++;
            }
        } while(nuevoNum != 0);
        
        
    }
    
}

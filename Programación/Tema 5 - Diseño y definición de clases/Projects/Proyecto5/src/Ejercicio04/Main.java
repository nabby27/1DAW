/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio04;

import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Reloj r1 = new Reloj();
        Reloj r2 = new Reloj(17, 30, 10);
        
        do {
            menuFormato(r2);    
        } while (true);
    }
    
    private static void menuFormato(Reloj reloj) {
        Scanner sc = new Scanner(System.in);
        int formato = 0;
        
        do {
            System.out.println("Elige opción de visualización");
            System.out.println("-----------------------------");
            System.out.println("Formato 24 horas (24)");
            System.out.println("Formato 12 horas (12)");
            formato = sc.nextInt();
            if (formato != 12 && formato != 24)
                System.out.println("Opción no valida");
        } while(formato != 12 && formato != 24);
        
        reloj.setFormato(formato);
        System.out.println(reloj.dameHora());
    }
}


/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio26 {
    
    static final int num = 200;
        
    public static void main(String[] args) {
        System.out.println("100 PRIMEROS PARES");
        
        estructuraFor();
        estructuraWhile();
        estructuraDoWhile();
    }
    
    public static void estructuraFor() {
        System.out.println("ESTRUCTURA FOR");
        for (int x = num; x > -1; x -=2 ) {
            System.out.println(x);
        }
    }
    
    public static void estructuraWhile() {
        System.out.println("ESTRUCTURA WHILE");
        int x = num;
        while (x > -1) {
            System.out.println(x);
            x -= 2;
        }
    }
    
    public static void estructuraDoWhile() {
        System.out.println("ESTRUCTURA DO WHILE");
        int x = num;
        do {
            System.out.println(x);
            x -= 2;
        } while (x > -1);
    }
}

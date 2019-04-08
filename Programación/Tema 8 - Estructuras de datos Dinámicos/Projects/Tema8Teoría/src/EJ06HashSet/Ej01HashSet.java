/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ06HashSet;

import java.util.HashSet;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ej01HashSet {
    
    static HashSet<Integer> hs = new HashSet<Integer>();
    
    public static void main(String[] args) {
        do {
            add();
            remove();
        } while (true);
    }
    
    private static void add() {
        Scanner sc = new Scanner(System.in);
        int option = 0;
        do {
            System.out.println("Dime un número para añadir (-1 salir)");
            option = sc.nextInt();
            addNumberToHashSet(option);
        } while (option != -1);
        show(hs);
    }
    
    private static void remove() {
        Scanner sc = new Scanner(System.in);
        int option = 0;
        do {
            System.out.println("Dime un número para eliminar (-1 salir)");
            option = sc.nextInt();
            removeNumberToHashSet(option);
        } while (option != -1);
        show(hs);
    }
    
    private static void addNumberToHashSet(int option) {        
        if (option != -1) {
            if (hs.add(option)) {
                System.out.println("Añadido correctamente");
            } else {
                System.out.println("Ya se ha introducido ese número");
            }
        }
    }
    
    private static void removeNumberToHashSet(int option) {
        if (option != -1) {
            if (hs.remove(option)) {
                System.out.println("Eliminado correctamente");
            } else {
                System.out.println("No existe ese número");
            }
        }
    }
    
    private static void show(HashSet<Integer> hashSet) {
        for (Integer number : hashSet) {
            System.out.println(number);
        }
    }
    
}

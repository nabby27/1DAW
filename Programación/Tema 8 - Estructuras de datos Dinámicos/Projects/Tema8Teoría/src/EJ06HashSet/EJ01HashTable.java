/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ06HashSet;

import java.util.Hashtable;
import java.util.Map;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class EJ01HashTable {
    
    static Hashtable<Integer, String> hs = new Hashtable<Integer, String>();
    
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
            if (hs.put(option, option + "") == null) {
                System.out.println("Añadido correctamente");
            } else {
                System.out.println("Ya se ha introducido ese número");
            }
        }
    }
    
    private static void removeNumberToHashSet(int option) {
        if (option != -1) {
            if (hs.remove(option) != null) {
                System.out.println("Eliminado correctamente");
            } else {
                System.out.println("No existe ese número");
            }
        }
    }
    
    private static void show(Hashtable<Integer, String> hashSet) {
        for (Map.Entry<Integer, String> entry : hashSet.entrySet()) {
            System.out.println(entry.getKey());
        }
    }
    
}

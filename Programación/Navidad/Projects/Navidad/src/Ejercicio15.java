
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
public class Ejercicio15 {
    
    static int[] unidadesMonetarias = {500, 200, 100, 50, 20, 10, 5, 2, 1};
    
    public static void main(String[] args) {
                
        int num = pedirDato();
        desglosar(num);
    }
    
    private static int pedirDato() {
        Scanner sc = new Scanner(System.in);    
        System.out.println("Dime una cifra");
        return sc.nextInt();
    }
    
    private static void desglosar(int num) {
        ArrayList<Integer> desglose = new ArrayList<>();  
        for (int unidad : unidadesMonetarias) {
            while (num - unidad >= 0) {
                num -= unidad;
                desglose.add(unidad);
            }
        }
        System.out.println(desglose);
    }
    
}


import java.util.Arrays;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class OrdenarVector {

    public static void main(String[] args) {//main cuerpo del programa
        int[] a = {9, 2, 4, 3, 1, 8, 7, 5, 6};
        System.out.println("Arreglo desordenado");
        for (int i = 0; i < a.length; i++) {
            System.out.print(a[i] + ", ");
        }
        Arrays.sort(a);
        System.out.println("\nArreglo ordenado");
        for (int i = 0; i < a.length; i++) {
            System.out.print(a[i] + ", ");
        }
    }//Cierre del main
}//Cierre de la clase

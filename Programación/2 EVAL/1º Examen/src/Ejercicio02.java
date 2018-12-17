
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio02 {
 
    
    public static void main(String[] args) {
        
        int[] numeros = {11, 2, 1, 7, 9, 10, 6, 34, 88, 45};
        int[] numerosOrdenados = new int[numeros.length];
        int numeroMenor = 0;
        int numeroMayor = 0;
        int cont = 0;
        
        for (int i = 0; i < numeros.length; i++) {
            if (i == 0 || numeros[i] < numeroMenor) {
                numeroMenor = numeros[i];
            }
            if (i == 0 || numeros[i] > numeroMayor) {
                numeroMayor = numeros[i];
            }
        }
        
        for (int j = numeroMayor; j >= numeroMenor; j--) {
            for (int i = 0; i < numeros.length; i++) {
                if (numeros[i] == j) {
                    numerosOrdenados[cont] = numeros[i];
                    cont++;
                }
            }
        }
        
        System.out.print("Numeros: ");
        for (int numero : numeros) {
            System.out.print(numero + " ");
        }
        System.out.println("");
        
        System.out.print("Numeros ordenados: ");
        for (int numero : numerosOrdenados) {
            System.out.print(numero + " ");
        }
        System.out.println("");
        
    }
    
}

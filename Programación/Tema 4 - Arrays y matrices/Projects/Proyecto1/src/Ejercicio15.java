
import java.util.Random;


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
    
    
    static Random rnd = new Random();
    static final int filas = 4;
    static final int columnas = 15;
    static final int numeroComarca = 0;
    static final int numeroHabitantes = 1;
    static final int extension = 2;
    static final int densidad = 3;
    
    public static void main(String[] args) {
        
        int[][] comarcas = new int[filas][columnas];
        
        rellenarComarcas(comarcas);
        pintarTodo(comarcas);
        menorExtension(comarcas);
        menoresDeDiezMilH(comarcas);
        densidadSuperiorMedia(comarcas);
        
    }
    
    private static void rellenarComarcas(int[][] matriz) {        
        for (int j = 0; j < matriz[0].length; j++) {
            matriz[numeroComarca][j] = j+1;
            matriz[numeroHabitantes][j] = (rnd.nextInt(4801)+200);
            matriz[extension][j] = (rnd.nextInt(181)+20);
            matriz[densidad][j] = (matriz[1][j]/matriz[2][j]);
        }
    }
    
    private static void pintarTodo(int[][] matriz) {
        System.out.println("Comarcas:");
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                System.out.print(matriz[i][j] + "\t");
            }
            System.out.println("");
        }
        System.out.println("");
    }
    
    private static void menorExtension(int[][] matriz) {
        System.out.print("La comarca con menor extensión es: ");
        int comarcaMenor = 0;
        for (int j = 0; j < matriz[extension].length; j++) {
            if (j == 0 || matriz[extension][j] < matriz[extension][comarcaMenor]) {
                comarcaMenor = j;
            }
        }
        System.out.println(comarcaMenor+1);
        System.out.println("");
        
    }
    
    private static void menoresDeDiezMilH(int[][] matriz) {
        int habitantes = 1000;
        System.out.println("La comarca con menos de " + habitantes + " habitantes son: ");
        for (int j = 0; j < matriz[numeroHabitantes].length; j++) {
            if (matriz[numeroHabitantes][j] < habitantes) {
                System.out.print((j+1) + " - ");
            }
        }
        System.out.println("");
    }
    
    private static void densidadSuperiorMedia(int[][] matriz) {
        System.out.println("");
        int sum = 0;
        int media = 0;
        for (int j = 0; j < matriz[densidad].length; j++) {
            sum += matriz[densidad][j];
        }
        
        media = sum/matriz[densidad].length;
        System.out.println("La media es: " + media);
        System.out.println("Las comarcas con densidad mayor a la media son: ");
        for (int j = 0; j < matriz[densidad].length; j++) {
            if (matriz[densidad][j] > media) {
                System.out.print(j + " - ");
            }
        }
        System.out.println("");
        
    }
    
}

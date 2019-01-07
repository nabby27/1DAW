
import java.util.ArrayList;
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
public class Ejercicio04 {
    
    static final int alumnos = 10;
    static final int asiganturas = 4;
            
    public static void main(String[] args) {
        
        ArrayList<int[]> alumNotas = new ArrayList<int[]>();
        
        calcularNotas(alumNotas); //con Random
        
        notaMedia(alumNotas);
                
        todasAprobadas(alumNotas);
    }
    
    private static void calcularNotas(ArrayList<int[]> alumNotas) {
        Random rnd = new Random();
        for (int i = 0; i < alumnos; i++) {
            int[] notasAlum = new int[asiganturas];
            for (int j = 0; j < asiganturas; j++) {
                notasAlum[j] = rnd.nextInt(11);
            }
            alumNotas.add(notasAlum);
        }
    }
    
    private static void notaMedia(ArrayList<int[]> alumNotas) {
        int suma = 0;
        for (int[] alumno : alumNotas) {
            suma = 0;
            for (int nota : alumno) {
                suma += nota;
            }
            System.out.println("La nota media del alumno " + (alumNotas.indexOf(alumno)+1) + " es: " + (suma/asiganturas));
        }
    }
    
    private static void todasAprobadas(ArrayList<int[]> alumNotas) {
        ArrayList<Integer> aprobados = new ArrayList<Integer>();
        boolean suspendida = false;
        
        for (int[] alumno : alumNotas) {
            suspendida = false;
            for (int nota : alumno) {
                if (nota < 5) {
                    suspendida = true;
                }
            }
            if (!suspendida)
                aprobados.add(alumNotas.indexOf(alumno));
        }
        
        System.out.println("Los que han aprobado todas son los alumnos: " + aprobados);
    }
    
}

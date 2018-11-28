
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
public class Ejercicio05 {
    
    private static final int totalElementos = 20;
    
    public static void main(String[] args) {
    
        Random rnd = new Random(); 
        int random = 0;
        int inferior2 = 0;
        int cantidadAprobados = 0;
        int media = 0;
        int suma = 0;
        int sumaAprobados = 0;
        boolean algun10 = false;
        ArrayList<Integer> notas = new ArrayList<Integer>();
                
        for (int i = 0; i < totalElementos; i++) {
            System.out.println("Dime una nota");
            random = rnd.nextInt(11);
            suma += random;
            notas.add(i, random);
            System.out.println(notas.get(i));
        }       
        
        for (int i = 0; i < notas.size(); i++) {
            if (notas.get(i) < 2)
                inferior2++;
            else if (notas.get(i) == 10)
                algun10 = true;
            if (notas.get(i) > 4) {
                cantidadAprobados++;
                sumaAprobados += notas.get(i);
            }
        }
        
        System.out.println("La media es: " + suma/totalElementos);
        System.out.println("Porcentaje de aprobados: " + sumaAprobados/cantidadAprobados);
        System.out.println("Hay " + inferior2 + " notas inferiores a 2");
        if (algun10)
            System.out.println("Hay algun 10");
        else
            System.out.println("No hay ningún 10");
    }
    
}

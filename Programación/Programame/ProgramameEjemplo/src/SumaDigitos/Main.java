/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package SumaDigitos;

import java.util.ArrayList;

/**
 *
 * @author TeProgramo
 */
public class Main {
    
    private static ArrayList<ArrayList<Integer>> numeros = new ArrayList<ArrayList<Integer>>();
    
    public static void main(String[] args) {
        setDatos();
        calcular();
    }
    
    private static void setDatos() {
        ArrayList<Integer> fila = new ArrayList<Integer>(){{add(3); add(4); add(3); add(3);}};
        numeros.add(fila);
        fila = new ArrayList<Integer>(){{add(7);}};
        numeros.add(fila);
        fila = new ArrayList<Integer>(){{add(2);add(3);}};
        numeros.add(fila);        
    }
    
    private static void calcular() {
        int sum = 0;
        for (ArrayList<Integer> fila : numeros) {
            sum = 0;
            for (int i = 0; i < fila.size(); i++) {
                sum +=  fila.get(i);
                if (i != fila.size()-1) {
                    System.out.print(fila.get(i) + " + ");
                } else {
                    System.out.print(fila.get(i) + " = ");
                }
            }
            System.out.print(sum);
            System.out.println("");
        }
    }
    
}

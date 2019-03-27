/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Conscurso.A;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/**
 *
 * @author TeProgramo
 */
public class Main {
    
    static HashMap<Integer, Integer> piñonesSegundos = new HashMap<Integer, Integer>();
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int casos = sc.nextInt();
        sc.skip("\n");
        for(int i = 0; i < casos; i++) {
            piñonesSegundos = new HashMap<Integer, Integer>();
            String linea = sc.nextLine();
            String lineaVector[] = linea.split("");
            int piñonInicial = Integer.parseInt(linea.substring(0, 2));
            int piñonActual = piñonInicial;
            piñonesSegundos.put(piñonInicial, 0);
            for (int j = 2; j < lineaVector.length-1; j++) {
                if (charIsNumber(linea, j)) {
                    int segundos = Integer.parseInt(linea.substring(j, j+3));
                    if (piñonesSegundos.containsKey(piñonActual)) {
                        piñonesSegundos.put(piñonActual, piñonesSegundos.get(piñonActual) + segundos);
                    } else {
                        piñonesSegundos.put(piñonActual, segundos);
                    }
                    j+=2;
                } else {
                    if (linea.substring(j, j+1).equalsIgnoreCase("D")) {
                        piñonActual--;
                    } else{
                        piñonActual++;
                    }
                }
            }
            System.out.println("caso " + (i+1) + ":");
            for (Map.Entry<Integer, Integer> entry : piñonesSegundos.entrySet()) {
                if (entry.getValue() != 0) {
                    System.out.println(entry.getKey() + " " + entry.getValue());
                }
            }
            
        }
        
    }
    
    private static boolean charIsNumber(String linea, int potChar) {
        try {
            Integer.parseInt(linea.substring(potChar, potChar+1));
            return true;
        } catch (Exception e) {
            return false;
        }
    }
    
}

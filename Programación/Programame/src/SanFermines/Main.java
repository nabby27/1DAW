/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package SanFermines;

import java.util.ArrayList;

/**
 *
 * @author TeProgramo
 */
public class Main {
    
    private static ArrayList<ArrayList<Integer>> corridas = new ArrayList<ArrayList<Integer>>(){{}};
            
    public static void main(String[] args) {
        setToros();
        calcularMasRapidoDeCadaCorrida();
    }
    
    private static void setToros() {
        ArrayList<Integer> toros = new ArrayList<Integer>(){{add(1); add(9); add(8); add(7); add(10); add(3); add(12);}};
        corridas.add(toros);
        toros = new ArrayList<Integer>(){{add(10);}};
        corridas.add(toros);
    }
    
    private static void calcularMasRapidoDeCadaCorrida() {
        int velocidadMayor = 0;
        for (ArrayList<Integer> corrida : corridas) {
            velocidadMayor = 0;
            for (Integer toro : corrida) {
                if (toro > velocidadMayor) {
                    velocidadMayor = toro;
                }
            }
            System.out.println(velocidadMayor);
        }
    }
    
}

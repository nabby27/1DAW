/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio01;

import java.util.HashMap;
import java.util.Map;
import java.util.Random;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio05 {
    
    static HashMap<Integer, Integer> runners = new HashMap<>();
    static HashMap<Integer, Integer> teams = new HashMap<>();
        
    public static void main(String[] args) {
        
        Random rnd = new Random();
        int time = 0;
        int timeTeam = 0;
                
        for (int i = 1; i <= 100; i++) {
            time = rnd.nextInt(101);
            runners.put(i, time);
            System.out.println("El tiempo del corredor " + i + " es " + time);
        }
        
        for (int i = 1; i <= 10; i++) {
            timeTeam = sumTime(i);
            teams.put(i, timeTeam);
            System.out.println("El tiempo del equipo " + i + " es " + timeTeam);
        }
        
    }
    
    private static Integer sumTime(int numTeam) {
        String numberRunner = "";
        String lastNumber = "";
        Integer teamRunner = 0;
        Integer sumTime = 0;
        for (Map.Entry<Integer, Integer> runner : runners.entrySet()) {
            numberRunner = runner.getKey().toString();
            lastNumber = numberRunner.substring(numberRunner.length()-1, numberRunner.length());
            teamRunner = (lastNumber.equalsIgnoreCase("0")) ? 10 : Integer.parseInt(lastNumber);
            if (numTeam == teamRunner){
                sumTime += runner.getValue();
            }
        }
        return sumTime;        
    }
}

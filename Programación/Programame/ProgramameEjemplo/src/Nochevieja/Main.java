/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Nochevieja;

import java.util.ArrayList;

/**
 *
 * @author AlumMati
 */
public class Main {
    
    private static ArrayList<String> horas = new ArrayList<String>(){{add("23:45"); add("21:30"); add("00:01");}};
    private static ArrayList<Integer> horasEnMinutos = new ArrayList<Integer>();
    private final static Integer minutosDia = 1440;
    
    public static void main(String[] args) {
        
        for (String hora : horas) {
            horasEnMinutos.add(Integer.parseInt(hora.split(":")[0]) * 60 + Integer.parseInt(hora.split(":")[1]));
        }
        
        for (Integer horasEnMinuto : horasEnMinutos) {
            System.out.println(minutosDia - horasEnMinuto);
        }
        
    }
    
}

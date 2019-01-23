/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio4;

import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio06 {
    
    public static void main(String[] args) {        
        Scanner sc = new Scanner(System.in);
        int horaSalida = 0;
        int minSalida = 0;
        int horaLlegada = 0;
        int minLlegada = 0;
        int tiempo = 0;
        System.out.print("Hora de salida: ");
        horaSalida = sc.nextInt();
        System.out.print("Hora de llegada: ");
        horaLlegada = sc.nextInt();
        
        minSalida = (horaSalida / 100) * 60 + (horaSalida % 100);
        minLlegada = (horaLlegada / 100) * 60 + (horaLlegada % 100);
        
        tiempo = minLlegada - minSalida;
        
        System.out.println("Tiempo de viaje " + (tiempo / 60) + " horas " + (tiempo % 60) + " minutos");
    }
    
}

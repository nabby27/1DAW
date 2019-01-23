/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio4;

import java.util.HashMap;
import java.util.Map;
import java.util.Random;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio5 {
    
    static float vuelta = 0;
    static float[] monedasvalidas = {2, 1, 0.5F, 0.2F, 0.1F, 0.05F, 0.02F, 0.01F};
    static HashMap<Float, Integer> dineroVuelta = new HashMap<Float, Integer>();

    public static void main(String[] args) {
        
        vuelta = pedirDinero();
        calcularVuelta(vuelta);
        mostrarVuelta();
    }
    
    private static float pedirDinero() {
        Scanner sc = new Scanner(System.in);
        Random rnd = new Random();
        float precio = 0;
        float dinero = 0;
        
        precio = rnd.nextFloat()*500;
        System.out.println("Precio: " + precio);
        System.out.print("Dinero entregado: ");
        dinero = sc.nextFloat();
        System.out.println("");
        System.out.println("Vuelta en euros: " + (dinero-precio));
        return dinero-precio;
    }
    
    private static void calcularVuelta(float dinero) {
        dineroVuelta = new HashMap<Float, Integer>();
        int count = 0;
        for (float moneda : monedasvalidas) {
            count = 0;
            while (dinero > 0 && dinero-moneda >=0) {
                dinero -= moneda;
                count++;
            }
            dineroVuelta.put(moneda, count);
        }
    }
    
    private static void mostrarVuelta() {
        for (Map.Entry<Float, Integer> vuelta : dineroVuelta.entrySet()) {
            System.out.println(vuelta.getValue() + " monedas de " + vuelta.getKey() + " euros");
        }
    }
    
}

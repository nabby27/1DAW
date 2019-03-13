/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio03;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        Punto3D punto3d = new Punto3D(1, 2, 3);
        
        System.out.println("Coordenadas: " + punto3d.dameCoordenadas());
        System.out.println("Distancia al centro: " + punto3d.distanciaAlcentro());
    }
    
}

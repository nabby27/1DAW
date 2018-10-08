/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio11 {
    
    public static void main(String[] args) {
        int alto = 15;
        int ancho = 25;
        int perimetro = 0;
        int area = 0;
        
        perimetro = ((alto * 2) + (ancho* 2));
        area = (alto * ancho);
        
        System.out.println("El perímetro del rectangulo es: " + perimetro + " cm");
        System.out.println("El area del rectangulo es: " + area + " cm2");
   }
    
}

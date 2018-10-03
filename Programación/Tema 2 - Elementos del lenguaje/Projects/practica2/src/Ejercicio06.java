/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio06 {
    
    static final int descuento = 15;
    static final float precioBruto = 85.0F;
    
    public static void main(String[] args) {
        float precioNeto = (precioBruto - ((precioBruto * descuento) / 100));
        System.out.println("El precio final es: " + precioNeto);
    }
    
}

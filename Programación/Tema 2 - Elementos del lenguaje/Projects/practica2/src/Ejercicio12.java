/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio12 {
    
    static final float pi = 3.141592F;
    
    public static void main(String[] args) {
        float diametro = 15.5F;
        float altura = 42.4F;
        float area = 0;
        float volumen = 0;
        float radio = (diametro / 2); 
        area = (2 * pi * radio * (radio + altura));
        volumen = (pi * radio * radio * altura);
        
        System.out.println("El area del cilindro es: " + area + " cm2");
        System.out.println("El volumen del cilindro es: " + volumen + " cm3");
   }
    
}

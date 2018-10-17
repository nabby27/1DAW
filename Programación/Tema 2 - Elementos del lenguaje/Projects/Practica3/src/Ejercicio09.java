import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio09 {
    
    static final float precioPorPaso = 0.05F;
    static final float precioMinimo = 0.10F;
    static final float pasosMinimo = 5;
    
    public static void main(String[] args) {
        
        int pasos = 0;
        float precioTotal = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Cuantos pasos has hecho: ");
            pasos = teclado.nextInt();
            if (pasos < 0) 
                System.out.println("El número tiene que ser positivo");
        } while(pasos < 0);
        
        if (pasos <= pasosMinimo)
            precioTotal = precioMinimo;
        else {
            pasos -= pasosMinimo;
            precioTotal = (precioMinimo + (pasos * precioPorPaso));
        }
        
        System.out.println("El precio total es: " + precioTotal + "€");
    }
    
}

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
public class Ejercicio19 {
        
    public static void main(String[] args) {
        
        float precioLitro1 = 0;
        float pagado1 = 0;
        float km1 = 0;
        
        float precioLitro2 = 0;
        float pagado2 = 0;
        
        float km3 = 0;
        
        float litros1 = 0;
        float litros2 = 0;
        float consumo100 = 0;
        float precioKm = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("PRIMERA PARADA");
        System.out.println("¿Cuanto es el precio del litro de combustible?");
        precioLitro1 = teclado.nextFloat();
        System.out.println("¿Cuanto te ha costado llenar el deposito entero?");
        pagado1 = teclado.nextFloat();
        System.out.println("¿Cuantos kilometros marcaba el cuentakilometros?");
        km1 = teclado.nextFloat();

        System.out.println("SEGUNDA PARADA");
        System.out.println("¿Cuanto es el precio del litro de combustible?");
        precioLitro2 = teclado.nextFloat();
        System.out.println("¿Cuanto te ha costado llenar el deposito entero?");
        pagado2 = teclado.nextFloat();
        
        System.out.println("TERCERA PARADA");
        System.out.println("¿Cuantos kilometros marcaba el cuentakilometros?");
        km3 = teclado.nextFloat();

        litros1 = (pagado1 / precioLitro1);
        litros2 = (pagado2 / precioLitro2);
                
        consumo100 = (((litros1 + litros2) / (km1 + km3)) * 100);
        precioKm = ((pagado1 + pagado2) / (km1+km3));
        
        System.out.println("Consumo por cada 100Km: " + consumo100 + " litros");
        System.out.println("Coste por Km: " + precioKm + "€");
   }
   
}

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
        float marcaKilometros1 = 0;
        float precioDepositoEntero1 = 0;
        float precioLitro2 = 0;
        float precioDepositoEntero2 = 0;
        float marcaKilometros3 = 0;
        
        float kilometrosRecorridos = 0;
        float litrosLlenados2 = 0;
        float consumo = 0;
        float coste = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("PRIMERA PARADA");
        System.out.println("¿Cuanto es el precio del litro de combustible?");
        precioLitro1 = teclado.nextFloat();
        System.out.println("¿Cuanto te ha costado llenar el deposito entero?");
        precioDepositoEntero1 = teclado.nextFloat();
        System.out.println("¿Cuantos kilometros marcaba el cuentakilometros?");
        marcaKilometros1 = teclado.nextFloat();

        System.out.println("SEGUNDA PARADA");
        System.out.println("¿Cuanto es el precio del litro de combustible?");
        precioLitro2 = teclado.nextFloat();
        System.out.println("¿Cuanto te ha costado llenar el deposito entero?");
        precioDepositoEntero2 = teclado.nextFloat();
        
        System.out.println("TERCERA PARADA");
        System.out.println("¿Cuantos kilometros marcaba el cuentakilometros?");
        marcaKilometros3 = teclado.nextFloat();

        litrosLlenados2 = (precioDepositoEntero2 / precioLitro2);
        kilometrosRecorridos = (marcaKilometros3 - marcaKilometros1); 
        
        consumo = ((litrosLlenados2 / kilometrosRecorridos) * 100);
        
        coste = ((consumo / 100) * precioLitro2);
   }
   
}

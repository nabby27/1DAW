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
public class Ejercicio11 {
    
    public static void main(String[] args) {
        
        float num1 = 0;
        float num2 = 0;
        float num3 = 0;
        float resultado = 0;
        int accion = 0;
        Scanner teclado = new Scanner(System.in);
        
        num1 = pedirNumero(1);
        num2 = pedirNumero(2);
        num3 = pedirNumero(3);
        
        System.out.println("¿Que quieres hacer?");
        System.out.println("(1) - Obtener máximo");
        System.out.println("(2) - Obtener mínimo");
        accion = teclado.nextInt();
        
        switch (accion) {
            case 1:
                resultado = obtenerMaximo(num1, num2, num3);
                System.out.println("El numero más grande es: " + resultado);
                break;
            case 2:
                resultado = obtenerMinimo(num1, num2, num3);
                System.out.println("El numero más pequeño es: " + resultado);
                break;
        }
        
    }
    
    public static float pedirNumero(int numero) {
        float num = 0;
        Scanner teclado = new Scanner(System.in);

        do {
            System.out.print("Dime el numero " + numero + ": ");
            num = teclado.nextFloat();
            if (num < 0) 
                System.out.println("El número tiene que ser positivo");
        } while(num < 0);      
        return num;
    }
    
    public static float obtenerMaximo(float num1, float num2, float num3) {
        if (num1 >= num2 && num1 >= num3)
            return num1;
        else if (num2 > num1 && num2 >= num3)
            return num2;
        else
            return num3;
    }
    
    public static float obtenerMinimo(float num1, float num2, float num3) {
        if (num1 <= num2 && num1 <= num3)
            return num1;
        else if (num2 < num1 && num2 <= num3)
            return num2;
        else
            return num3;     
    }
}

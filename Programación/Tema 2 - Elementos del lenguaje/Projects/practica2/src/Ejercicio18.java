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
public class Ejercicio18 {
        
    public static void main(String[] args) {
        
        float lado = 0;
        float perimetro = 0;
        double area = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el tamaño de un lado del triangulo: ");
        lado = teclado.nextFloat();
        perimetro = (lado *3);
        area = ((Math.sqrt(3)/4) * Math.pow(lado, 2));
        
        System.out.println("El área del triangulo es: " + area);
        System.out.println("El perimetro del triangulo es: " + perimetro);
   }
    
}

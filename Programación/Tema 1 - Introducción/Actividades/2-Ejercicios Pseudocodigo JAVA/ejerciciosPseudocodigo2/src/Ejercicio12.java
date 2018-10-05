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
public class Ejercicio12 {
    
    public static void main(String[] args) {
        System.out.println("15 Y CALCULA");
        
        int sumaPares = 0;
        int productoPares = 1;
        boolean mayor500 = false;
        int cantidadNegativos = 0;
        Scanner teclado = new Scanner(System.in);
        
        for (int x = 0; x < 15; x++) {
            System.out.println("Dime un número: ");
            int num = teclado.nextInt();
            if ((num % 2 == 0) && (num > 19) && (num < 206)) {
                sumaPares = sumaPares + num;
                productoPares = productoPares * num;
            }
            if (num > 500)
                mayor500 = true;
            if (num < 0)
                cantidadNegativos++;
        }
        
        System.out.println("La suma de los números pares entre 20 y 205 (incluidos) es: " + sumaPares);
        if (productoPares == 1)
            System.out.println("El producto de los números pares entre 20 y 205 (incluidos) es: 0");
        else
            System.out.println("El producto de los números pares entre 20 y 205 (incluidos) es: " + productoPares);
        System.out.println("Hay " + cantidadNegativos + " numero/s negativo/s");
        if (mayor500)
            System.out.println("Hay al menos un número mayor a 500");
        else 
            System.out.println("No hay ningún número mayor a 500");
    }
    
}

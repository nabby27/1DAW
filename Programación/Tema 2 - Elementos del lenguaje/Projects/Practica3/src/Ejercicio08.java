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
public class Ejercicio08 {
    
    static final double pi = Math.PI;
    
    public static void main(String[] args) {
        
        int radio = 0;
        double area = 0;
        double perimetro = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime el radio: ");
            radio = teclado.nextInt();
            if (radio < 0) 
                System.out.println("El número tiene que ser positivo");
        } while(radio < 0);
        
        area = (pi * radio * radio);
        perimetro = (2 * pi * radio);
        
        System.out.println("El area es: " + area);
        System.out.println("El perimetro es: " + perimetro);
    }
    
}

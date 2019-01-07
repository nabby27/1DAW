
import java.util.ArrayList;
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
public class Ejercicio05 {
        
    public static void main(String[] args) {
        
        int num = pedirDato();
        
        descomponer(num);
    }
    
    private static int pedirDato() {
        Scanner sc = new Scanner(System.in);
        int num = 0;
        do {
            System.out.println("Dime un número para descomponer");
            num = sc.nextInt();
            if (num <= 0)
                System.out.println("El número no puede ser 0 o negativo");
        } while(num <= 0);
        return num;
    }
    
    private static void descomponer(int numero) {
        int primo = 2;
        ArrayList<Integer> descomposicion = new ArrayList<Integer>();
        while (numero > 1) {
            if (numero % primo == 0) {
                descomposicion.add(primo);
                numero /= primo;
            }
            if (numero % primo != 0)
                primo = siguientePrimo(primo);
        }
        System.out.println(descomposicion);
    }
    
    private static int siguientePrimo(int numero) {
        boolean encontrado = false;
        boolean primo = true;
        
        while (!encontrado) {
            numero++;
            primo = true;
            for (int i = 2; i < numero; i++) {
                if (numero % i == 0)
                    primo = false;
            }
            if (primo)
                encontrado = true;
        }
        return numero;
    }
}

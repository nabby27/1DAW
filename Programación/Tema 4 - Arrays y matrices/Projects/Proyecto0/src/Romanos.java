
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
public class Romanos {
    
    static int millares = 0, centenas = 0, decenas = 0, unidades = 0;
    
    static String romanos[][] = {
        {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
        {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
        {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"},
        {"", "M", "MM", "MMM", "MV", "V", "VM", "VMM", "VMMM", "MX"}
    };
    
    public static void main(String[] args) {
        
        int num = 0;
        Scanner sc = new Scanner(System.in);
        
        do {
            System.out.println("Introduce un número máximo hasta el 9999");
            num = sc.nextInt();
            if (num < 0 || num > 9999)
                System.out.println("El número no esta en el rango");
        } while (num < 0 || num > 9999);
        
        descomponer(num);
        obtenerRomano();
    }
    
    private static void descomponer(int num) {
        millares = num / 1000;
        centenas = (num % 1000) / 100;
        decenas = (num % 100) / 10;
        unidades = num % 10;
    }
    
    private static void obtenerRomano() {
        System.out.println(
                romanos[3][millares] + 
                romanos[2][centenas] + 
                romanos[1][decenas] +
                romanos[0][unidades]);
    }
    
}

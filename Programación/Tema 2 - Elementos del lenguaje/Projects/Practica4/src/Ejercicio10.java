
import java.util.Scanner;
import jdk.nashorn.internal.objects.NativeArray;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio10 {
    
    public static void main(String[] args) {
        
        int num = 0;
        String factoresPrimos = "";
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número positivo: ");
            num = teclado.nextInt();
            if (num < 0)
                System.out.println("El número tiene que ser positivo");
        } while (num < 0);
        
        for (int i = 3; i <= num; i++) {
            factoresPrimos = "";
            if (i % 3 == 0) {
                System.out.print("Múltiplo="+i+".");
                factoresPrimos = factoresPrimos(i);
                System.out.println("Los factores primos del " + i + " = " + factoresPrimos + ";");
            }
        }
        
    }
    
    public static String factoresPrimos(int num) {
        
        String result = "";
        
        for (int j = 2; j <= num; j++) {
            while (num % j == 0) {
                if (result.equals(""))
                    result += j;
                else
                    result += ", " + j;
                num /= j;
            }
        }
        return result;
    }
    
}

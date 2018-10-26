
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
public class Ejercicio09 {
    
    public static void main(String[] args) {
        
        int numerosAIntroducir = 0;
        int num = 0;
        String numText = "";
        String result = "";
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("¿Cuantos números quieres introducir?");
        numerosAIntroducir = teclado.nextInt();
        
        for(int x = 0; x < numerosAIntroducir; x++) {
            do {
                System.out.print("(" + (x+1) + "/" + numerosAIntroducir + ") Dime un número de dos cifras: ");
                num = teclado.nextInt();
                if (num < 9)
                    System.out.println("El número tiene que ser de dos digitos");
            } while (num < 9);
            
            numText = num + "";
            if (numText.contains("0")) {
                if (result.equals(""))
                    result += numText;
                else
                    result += ", " + numText;
            }               
        }
        
        System.out.println(result);
        
    }
    
}

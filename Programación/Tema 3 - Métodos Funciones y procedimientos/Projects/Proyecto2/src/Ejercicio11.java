
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
    
    private static Scanner sc = new Scanner(System.in);
    
    public static void main(String[] args) {
        
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        boolean capicua = false;
        
        num1 = pedirNum(1);
        num2 = pedirNum(2);
        num3 = pedirNum(3);
        num4 = pedirNum(4);
        
        capicua = capicua(num1, num2, num3, num4);
        if (capicua)
            System.out.println("Es capicua");
        else
            System.out.println("No es capicua");
    }
    
    private static int pedirNum(int num) {
        System.out.println("Dime el numero " + num);
        return sc.nextInt();
    }
    
    private static boolean capicua(int num1, int num2, int num3, int num4) {
        String num = num1+""+num2+""+num3+""+num4;
        String numReverse = num4+""+num3+""+num2+""+num1;
        if (Integer.parseInt(num) == Integer.parseInt(numReverse))
            return true;
        return false;
    }
}


/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio20 {
    
    public static void main(String[] args) {
        System.out.println("TABLAS DE MULTIPLICAR");
        
        int x = 0;
        int num = 3;
        System.out.println("TABLA DE MULTIPLICAR DE " + num);
        while (x < 11) {
            System.out.println(num + " x " + x + "= " + (num * x));
            if ((x == 10) && (num < 9)) {
               num += 2;
               x = -1;
               System.out.println("TABLA DE MULTIPLICAR DE " + num);
            }
            x++;
        }
    }
    
}


/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio16 {
        
    public static void main(String[] args) {
        
        int num = 5;
        num += num - 1 * 4 + 1;
        System.out.println(num);
        num = 4;
        num %= 7 * num % 3 * 7 >> 1;
        System.out.println(num);
        
    }
    
}

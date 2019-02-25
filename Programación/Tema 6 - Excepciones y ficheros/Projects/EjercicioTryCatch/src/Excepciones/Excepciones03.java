/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Excepciones;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Excepciones03 {
     
    public static void main(String[] args) {
       int a;
       for (int i = 0; i < 10; i++) {
           try {
               a = deveulveEntero(i);
           } catch (Exception e) {
               System.out.println(e.getMessage());
               a = 99;
           }
           System.out.println(a);
       }
    }
    
    public static int deveulveEntero(int num) throws Exception {
        if (num % 2 == 0) {
            throw new Exception("Lanzando excepcion pares");
        } else {
            throw new Exception("Lanzando excepcion impares");
        }
    }
     
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Calculator;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Calculator {
    
    public int sumar(int num1, int num2) {
        return num1 + num2;
    }
    
    public int restar(int num1, int num2) {
        return num1 - num2;
    }
    
    public int multiplicar(int num1, int num2) {
        return num1 * num2;
    }
    
    public int dividir(int num1, int num2) {
        if (num2 != 0) {
            return num1 / num2;
        }
        return 0;
    }
    
}

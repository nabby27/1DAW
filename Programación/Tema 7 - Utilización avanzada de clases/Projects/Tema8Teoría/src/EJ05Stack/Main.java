/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ05Stack;

import java.util.Iterator;
import java.util.ListIterator;
import java.util.Stack;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        Stack<String> pilaOriginal = new Stack<String>();
        Stack<String> pilaAux = new Stack<String>();
        Stack<String> pilaFinal = new Stack<String>();

        if (pilaOriginal.empty()) {
            System.out.println("La pila esta vacía");
        }
        
        pilaOriginal = apilar();
        
        visualizar(pilaOriginal);
        
        pilaAux = getReverseStack(pilaOriginal);
        
        visualizar(pilaAux);
        
        pilaFinal = getReverseStack(pilaAux);
        
        visualizar(pilaFinal);
    }
    
    private static Stack apilar() {
        Stack pila = new Stack();
        pila.push("1");
        pila.push("2");
        pila.push("3");
        pila.push("4");
        pila.push("5");
        return pila;
    }
    
    private static Stack desApilar(Stack pila) {
        while (!pila.empty()) {
            System.out.println(pila.pop());
        }
        return pila;
    }
    
    private static Stack getReverseStack(Stack pila) {
        Stack pilaAux = new Stack();
        while (!pila.empty()) {
            pilaAux.push(pila.pop());
        }
        return pilaAux;
    }
    
    private static void visualizar(Stack pila) {
        System.out.println("");
        for (Object item : pila) {
            System.out.println(item);
        }
    }
    
}

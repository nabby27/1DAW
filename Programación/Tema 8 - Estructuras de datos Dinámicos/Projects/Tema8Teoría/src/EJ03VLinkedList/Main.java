/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ03VLinkedList;

import java.util.Iterator;
import java.util.LinkedList;
import java.util.ListIterator;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        String colores[] = {"negro", "amarillo", "verde", "verde", "azul", "violeta", "plateado"};
        String colores2[] = {"dorado", "blanco", "cafe", "azul", "gris", "plateado"};
        LinkedList<String> lista = new LinkedList<String>();
        LinkedList<String> lista2 = new LinkedList<String>();
        
        System.out.println("Metemos \"valores\" en lista 2");
        lista2.add("Lunes");
        lista2.add("Martes");
        lista2.add("Miercoles");
        lista2.add("Jueves");
        lista2.add("Viernes");
        lista2.addFirst("Domingo");
        lista2.addLast("Sabado");

        visualizar(lista2);
        
        visualizar(lista2.iterator());
        
        lista2.clear();
        
        cambiarDevectorALinkedList(colores, lista);
        
        cambiarDevectorALinkedList(colores2, lista2);
        
        visualizar(lista);
        
        visualizar(lista2);
        
        cambiarAMayusculas(lista2);
        
        visualizar(lista2);
        
        System.out.println("");
        System.out.println(lista2.peek());
        visualizar(lista2);
        System.out.println(lista2.size());
        System.out.println("");
        System.out.println(lista2.pop());
        visualizar(lista2);
        System.out.println(lista2.size());
        
        ordenInverso(lista2);
        
    }
    
    private static void visualizar(LinkedList<String> lista) {
        System.out.println("");
        for (String item : lista) {
            System.out.print(item + " ");
        }
        System.out.println("");
    }
    
    private static void visualizar(String[] lista) {
        System.out.println("");
        for (String item : lista) {
            System.out.print(item + " ");
        }
        System.out.println("");
    }
    
    private static void visualizar(Iterator it) {
        System.out.println("");
        while (it.hasNext()) {
            System.out.print(it.next() + " ");
        }
        System.out.println("");
    }    
    
    private static void cambiarDevectorALinkedList(String[] vector, LinkedList<String> list) {
        for (String item : vector) {
            list.add(item);
        }
    }
    
    private static void cambiarAMayusculas(LinkedList<String> lista) {
        ListIterator<String> it = lista.listIterator();
        while (it.hasNext()) {
            it.set(it.next().toUpperCase());
        }
    }
    
    private static void ordenInverso(LinkedList<String> lista) {
        ListIterator<String> it = lista.listIterator(lista.size());
        while (it.hasPrevious()) {
            System.out.print(it.previous() + " ");
        }
        System.out.println("");
    }
            
}

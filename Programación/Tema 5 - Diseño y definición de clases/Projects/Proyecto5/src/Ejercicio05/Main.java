/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio05;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    static ArrayList<Almacen> almacenes = new ArrayList<Almacen>();
    
    public static void main(String[] args) {
        
        crearAlmacenes();
        ordenarAlmacenes();
        do {
            mostrarAlmacenes();
            menu();
        } while(true);
    }
    
    private static void crearAlmacenes() {
        Almacen almacen1 = new Almacen("Alamcen 1", 0, 2);
        Almacen almacen2 = new Almacen("Alamcen 2", 5, 4);
        Almacen almacen3 = new Almacen("Alamcen 3", 10, 8);
        
        almacenes.add(almacen1);
        almacenes.add(almacen2);
        almacenes.add(almacen3);
    }
    
    private static void ordenarAlmacenes() {
//        Collections.sort(almacenes, new Comparator() {
//            public int compare(Almacen a1, Almacen a2) {
//                    return new Integer(a1.getDistancia()).compareTo(new Integer(a2.getDistancia()));
//            }
//        });       
    }
    
    private static void mostrarAlmacenes() {
        for (Almacen almacen : almacenes) {
            System.out.println(almacen.toString());
        }
    }
    
    private static void menu() {
        Scanner sc = new Scanner(System.in);
        int opcion = 0;
        
        do {
            System.out.println("Elige una opción");
            System.out.println("----------------");
            System.out.println("0. Salir");
            System.out.println("1. Coger carga de almacen");
            System.out.println("2. Dejar carga a almacen");
            opcion = sc.nextInt();
            if (opcion < 0 || opcion > 2)
                System.out.println("Opción no valida");
        } while(opcion < 0 || opcion > 2);
        cargarOpcion(opcion);
    }
    
    private static void cargarOpcion(int opcion) {
        switch (opcion) {
            case 0:
                System.out.println("Adiós...");
                System.exit(0);
                break;
            case 1:
                cogerCarga();
                break;
            case 2:
                dejarCarga();
                break;
        }
    }
    
    private static void cogerCarga() {
        boolean recogido = false;
        for (Almacen almacen : almacenes) {
            if (almacen.getOcupadas() != 0 && !recogido) {
                System.out.println("Coger la carga del " + almacen.getNombre());
                almacen.setOcupadas(almacen.getOcupadas()-1);
                recogido = true;
            }
        }
        if (!recogido) {
            System.out.println("No hay cargas que recoger, tendrá que esperar");
        }
    }
    
    private static void dejarCarga() {
        boolean entregado = false;
        for (Almacen almacen : almacenes) {
            if (almacen.getOcupadas() < almacen.getCapacidad() && !entregado) {
                System.out.println("Dejar la carga en " + almacen.getNombre());
                almacen.setOcupadas(almacen.getOcupadas()+1);
                entregado = true;
            }
        }
    }
        
}

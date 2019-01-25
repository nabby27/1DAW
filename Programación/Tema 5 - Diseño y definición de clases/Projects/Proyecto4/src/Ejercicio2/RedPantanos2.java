/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio2;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class RedPantanos2 {
    
    static ArrayList<Pantano> pantanos = new ArrayList<Pantano>();
     
    public static void main(String[] args) {
        int numPantanos = 0;
        
        numPantanos = pedirNumPantanos();
        
        setPantanos(numPantanos);
        
        do {
            menu();
        } while(true);

    }
    
    private static void setPantanos(int numPantanos) {
        for (int i = 1; i <= numPantanos; i++) {
            Random rnd = new Random();
            Pantano pantano = new Pantano();
            pantano.setCapacidadTotal(rnd.nextInt(100)+1);
            pantano.setAguaAlmacenada(rnd.nextInt(pantano.getCapacidadTotal()+1));
            pantano.setNombreEmbalse("pantano " + i);
            pantanos.add(pantano);
        }
    }
    
    private static int pedirNumPantanos() {
        Scanner sc = new Scanner(System.in);

        System.out.println("Apliación para gestion de los pantanos");
        System.out.println("--------------------------------------");
        System.out.println("¿Cuantos pantanos tenemos?");
        return sc.nextInt();
    }
    
    private static void menu() {
        Scanner sc = new Scanner(System.in);
        int numOpcion = 0;
        String[] opciones = {
            "1. Mostrar información de los pantanos", 
            "2. ¿Cual es el porcentaje de ocupación?", 
            "3. ¿Cual es la cantidad de agua despues del incremento?", 
            "4. Suma litros de los pantanos", 
            "5. Nombre y cantidad del pantano con menos agua", 
            "6. Nombre y cantidad del pantano con más agua", 
            "7. Media de Hm3 almacenados", 
            "8. Salir"
        };

        do {
            System.out.println("Elige una opción");
            System.out.println("----------------");
        
            for (String opcion : opciones) {
                System.out.println(opcion);
            }
            numOpcion = sc.nextInt();
            if (numOpcion < 1 || numOpcion > 8)
                System.out.println("Opción incorrecta");
        } while (numOpcion < 1 || numOpcion > 8);
        
        cargaOpcion(numOpcion);
    }
    
    private static void cargaOpcion(int opcion) {
        switch (opcion) {
            case 1:
                info();
                break;
            case 2:
                porcentajeOcupacion();
                break;
            case 3:
                aguaDespuesDeIncremento();
                break;
            case 4:
                sumaLitros();
                break;
            case 5:
                infoPantanoMenosAgua();
                break;
            case 6:
                infoPantanoMasAgua();
                break;
            case 7:
                mediaHm3();
                break;
            case 8:
                System.out.println("Adiós...");
                System.exit(0);
                break;
        }
    }
    
    private static void info() {
        for (Pantano pantano : pantanos) {
            System.out.println(pantano.toString());
        }
    }
    
    private static void porcentajeOcupacion() {
        for (Pantano pantano : pantanos) {
            System.out.print(pantano.getNombreEmbalse());
            System.out.println("\t" + pantano.redProcentaje()+"% de ocupación");
        }
    }
    
    private static void aguaDespuesDeIncremento() {
        for (Pantano pantano : pantanos) {
            pantano.incrementarCantidad(1);
        }
    }
    
    private static void sumaLitros() {
        int suma = 0;
        for (Pantano pantano : pantanos) {
            suma += pantano.getAguaAlmacenada();
        }
        System.out.println("El agua total de todos los pantanos es: " + suma);
    }
    
    private static void infoPantanoMenosAgua() {
        Pantano pantanoMenosAgua = new Pantano();
        for (int i = 0; i < pantanos.size(); i++) {
            if (i == 0 || pantanoMenosAgua.getAguaAlmacenada() > pantanos.get(i).getAguaAlmacenada())
                pantanoMenosAgua = pantanos.get(i);
        }
        
        System.out.println(pantanoMenosAgua.toString());
    }
    
    private static void infoPantanoMasAgua() {
        Pantano pantanoMasAgua = new Pantano();
        for (int i = 0; i < pantanos.size(); i++) {
            if (i == 0 || pantanoMasAgua.getAguaAlmacenada() < pantanos.get(i).getAguaAlmacenada())
                pantanoMasAgua = pantanos.get(i);
        }
        
        System.out.println(pantanoMasAgua.toString());
    }
    
    private static void mediaHm3() {
        int suma = 0;
        for (Pantano pantano : pantanos) {
            suma += pantano.getAguaAlmacenada();
        }
        System.out.println("La media de Hm3 de todos los pantanos es: " + ((float) suma/pantanos.size()) + "Hm3");
    }
    
}

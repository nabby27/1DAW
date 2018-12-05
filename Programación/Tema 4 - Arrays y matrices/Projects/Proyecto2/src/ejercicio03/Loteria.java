/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio03;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Loteria {
    
    static final int numMinPrimitiva = 1;
    static final int numMaxPrimitiva = 49;
    static final int numMinReintegro = 0;
    static final int numMaxReintegro = 9;
    static ArrayList<Integer> boletoJugador = new ArrayList<Integer>();
    static int reintegroJugador = 0;
    static ArrayList<Integer> boletoGanador = new ArrayList<Integer>();
    static int reintegroGanador = 0;
    static int complementario = 0;
    static Scanner sc = new Scanner(System.in);

    public static void main(String[] args) {
        
        apuesta();
        
        System.out.println("");
        System.out.print("Tu boleto jugado es: " + boletoJugador);
        System.out.println(" r: " + reintegroJugador);
        
        sorteo();
        
        System.out.print("El boleto ganador es: " + boletoGanador);
        System.out.print(" c: " + complementario);
        System.out.println(" r: " + reintegroGanador);
        System.out.println("");
        
        repartoPremios();
        clear();
        System.out.println("");

    }
    
    private static void apuesta() {
        int opcion = 0;
        do {
            System.out.println("De que forma quieres hacer la primitiva?");
            System.out.println("1 - Manual");
            System.out.println("2 - Automática");
            opcion = sc.nextInt();
            if (opcion != 1 && opcion != 2)
                System.out.println("La opción no es correcta");
        } while(opcion != 1 && opcion != 2);
        switch (opcion) {
            case 1:
                apuestaManual();
                break;
            case 2:
                apuestaAutomatica();
                break;
            default:
                break;
        }
    }
    
    private static void apuestaManual() {
        int i = 0;
        int num = 0;
        boolean repetido = false;
        while (i < 6) {
            do {
                repetido = false;
                System.out.print("Dime el número " + (i+1) + ": ");
                num = sc.nextInt();
                if (boletoJugador.contains(num)) {
                    System.out.println("El número ya esta elegido y no puede repetirse");
                    repetido = true;
                } else if (num < numMinPrimitiva) {
                    System.out.println("El número no puede ser menor de " + numMinPrimitiva);
                }else if (num > numMaxPrimitiva) {
                    System.out.println("El número no puede ser mayor de " + numMaxPrimitiva);
                } else {
                    boletoJugador.add(num);
                }
            } while(repetido || num < numMinPrimitiva || num > numMaxPrimitiva);
            i++;
        }
        do {
            System.out.print("Dime el número del reintegro: ");
            reintegroJugador = sc.nextInt();
            System.out.println(reintegroJugador);
            if (reintegroJugador < numMinReintegro || reintegroJugador > numMaxReintegro) {
                System.out.println("El reintegro tiene que estar entre 0 y 9");
            }
        } while(reintegroJugador < numMinReintegro || reintegroJugador > numMaxReintegro);
    }
    
    private static void apuestaAutomatica() {
        int i = 0;
        int num = 0;
        boolean repetido = false;
        Random rnd = new Random();
        while (i < 6) {
            do {
                repetido = false;
                System.out.print("Dime el número " + (i+1) + ": ");
                num = rnd.nextInt(numMaxPrimitiva) + 1;
                System.out.println(num);
                if (boletoJugador.contains(num)) {
                    System.out.println("El número ya esta elegido y no puede repetirse");
                    repetido = true;
                } else {
                    boletoJugador.add(num);
                }
            } while(repetido);
            i++;
        }
        System.out.print("Dime el número del reintegro: ");
        reintegroJugador = rnd.nextInt(numMaxReintegro);
        System.out.println(reintegroJugador);
    }
    
    private static void sorteo() {
        int i = 0;
        int num = 0;
        boolean repetido = false;
        Random rnd = new Random();
        while (i < 6) {
            do {
                repetido = false;
                num = rnd.nextInt(numMaxPrimitiva) + 1;
                if (boletoGanador.contains(num)) {
                    repetido = true;
                } else {
                    boletoGanador.add(num);
                }
            } while(repetido);
            i++;
        }
        do {
            repetido = false;
            complementario = rnd.nextInt(numMaxPrimitiva) + 1;
            if (boletoGanador.contains(complementario))
                repetido = true;
        } while (repetido);
        reintegroGanador = rnd.nextInt(numMaxReintegro);
    }
    
    private static void repartoPremios() {
        int aciertos = 0;
        boolean reintegroAcertado = false;
        boolean complementarioAcertado = false;
        for (int i = 0; i < boletoJugador.size()-1; i++) {
            if (boletoGanador.contains(boletoJugador.get(i))){
                aciertos++;
            }
        }
        if (aciertos == 5){
            if (boletoJugador.contains(complementario)) {
                complementarioAcertado = true;
            }
        }
        if (reintegroGanador == reintegroJugador) {
            reintegroAcertado = true;
        }
        
        System.out.println("Has acertado " + aciertos + " número/s del boleto");
        if (complementarioAcertado)
            System.out.println("Has acertado el complementario");
        if (reintegroAcertado)
            System.out.println("Has acertado el reintegro");
        else
            System.out.println("No has acertado el reintegro");
    }
    
    private static void clear() {
        boletoJugador = new ArrayList<Integer>();
        reintegroJugador = 0;
        boletoGanador = new ArrayList<Integer>();
        reintegroGanador = 0;
        complementario = 0;
    }
}

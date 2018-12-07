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
public class LoteriaAlternativa {
    
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
    static int acierto = 0;
    static boolean reintegroAcertado = false;
    
    public static void main(String[] args) {
        int count = 0;
        while(acierto < 5 || !reintegroAcertado) {
            apuestaAutomatica();
            sorteo();
            repartoPremios();
            clear();
            count++;
        }
        System.out.println("Has tardado: " + count + " intentos");
    }
    
    private static void apuestaAutomatica() {
        int i = 0;
        int num = 0;
        boolean repetido = false;
        Random rnd = new Random();
        while (i < 6) {
            do {
                repetido = false;
                num = rnd.nextInt(numMaxPrimitiva) + 1;
                if (boletoJugador.contains(num)) {
                    repetido = true;
                } else {
                    boletoJugador.add(num);
                }
            } while(repetido);
            i++;
        }
        reintegroJugador = rnd.nextInt(numMaxReintegro);
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
        acierto = 0;
        reintegroAcertado = false;
        boolean complementarioAcertado = false;
        for (int i = 0; i < boletoJugador.size()-1; i++) {
            if (boletoGanador.contains(boletoJugador.get(i))){
                acierto++;
            }
        }
        if (acierto == 5){
            if (boletoJugador.contains(complementario)) {
                complementarioAcertado = true;
            }
        }
        if (reintegroGanador == reintegroJugador) {
            reintegroAcertado = true;
        }
    }
    
    private static void clear() {
        boletoJugador = new ArrayList<Integer>();
        reintegroJugador = 0;
        boletoGanador = new ArrayList<Integer>();
        reintegroGanador = 0;
        complementario = 0;
    }
}

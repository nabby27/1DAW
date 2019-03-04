/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Hexagonos;

import java.util.ArrayList;

/**
 *
 * @author TeProgramo
 */
public class Main {
    
    private static ArrayList<ArrayList<String>> hexagonos = new ArrayList<ArrayList<String>>(); 
    
    public static void main(String[] args) {
        setHexagonos();
        hacerPiramide();
    }
    
    private static void setHexagonos() {
        ArrayList<String> filaHexagono = new ArrayList<String>(){{add("3"); add("*");}};
        hexagonos.add(filaHexagono);
        filaHexagono = new ArrayList<String>(){{add("4"); add("p");}};
        hexagonos.add(filaHexagono);
    }
    
    private static void hacerPiramide() {
        for (ArrayList<String> filaHexagono : hexagonos) {
            int num = Integer.parseInt(filaHexagono.get(0));
            String caracter = filaHexagono.get(1);
                for (int i = 0; i < num-1; i++) {
                    for (int j = 0; j < num-i-1; j++) {
                        System.out.print(" ");
                    }
                    for (int j = 0; j < num+i+i; j++) {
                        System.out.print(caracter); 
                    }
                    System.out.println("");
                }
                for(int i = 0; i < num*2+(num/2); i++) {
                    System.out.print(caracter);
                }
                System.out.println("");
                for (int i = num-1; i > 0; i--) {
                    for (int j = 0; j <= num-i-1; j++) {
                        System.out.print(" ");
                    }
                    for (int j = 2; j < num+i+i; j++) {
                        System.out.print(caracter); 
                    }
                    System.out.println("");
                }
            }
            System.out.println("");
    }
    
}

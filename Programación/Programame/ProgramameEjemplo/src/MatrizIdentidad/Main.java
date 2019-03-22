/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package MatrizIdentidad;

import java.util.ArrayList;

/**
 *
 * @author teProgramo
 */
public class Main {
    
    private static ArrayList<ArrayList<ArrayList<Integer>>> matrizes = new ArrayList<ArrayList<ArrayList<Integer>>>();
    
    public static void main(String[] args) {
        setMatrizes();
        esMatrizIdentidad();
    }

    private static void setMatrizes() {
        ArrayList<Integer> fila1 = new ArrayList<Integer>(){{add(1); add(0); add(0);}};
        ArrayList<Integer> fila2 = new ArrayList<Integer>(){{add(0); add(1); add(0);}};
        ArrayList<Integer> fila3 = new ArrayList<Integer>(){{add(0); add(0); add(1);}};
        ArrayList<ArrayList<Integer>> matriz = new ArrayList<ArrayList<Integer>>(){{add(fila1); add(fila2); add(fila3);}};
        matrizes.add(matriz);
        ArrayList<Integer> fila4 = new ArrayList<Integer>(){{add(0); add(1);}};
        ArrayList<Integer> fila5 = new ArrayList<Integer>(){{add(1); add(0);}};
        matriz = new ArrayList<ArrayList<Integer>>(){{add(fila4); add(fila5);}};
        matrizes.add(matriz);
        ArrayList<Integer> fila6 = new ArrayList<Integer>(){{add(1); add(0); add(0); add(0); add(0);}};
        ArrayList<Integer> fila7 = new ArrayList<Integer>(){{add(0); add(5); add(0); add(0); add(0);}};
        ArrayList<Integer> fila8 = new ArrayList<Integer>(){{add(0); add(0); add(1); add(0); add(0);}};
        ArrayList<Integer> fila9 = new ArrayList<Integer>(){{add(0); add(0); add(0); add(1); add(0);}};
        ArrayList<Integer> fila10 = new ArrayList<Integer>(){{add(0); add(0); add(0); add(0); add(1);}};
        matriz = new ArrayList<ArrayList<Integer>>(){{add(fila6); add(fila7); add(fila8); add(fila9); add(fila10);}};
        matrizes.add(matriz);
    }
    
    private static void esMatrizIdentidad() {
        for (ArrayList<ArrayList<Integer>> matriz : matrizes) {
            boolean identidad = true;
            for (int i = 0; i < matriz.size() && identidad; i++) {
                for (int j = 0; j < matriz.get(0).size() && identidad; j++) {
                    if (j == i) {
                        if (matriz.get(i).get(i) != 1) {
                            identidad = false;
                        } 
                    } else {
                        if (matriz.get(i).get(j) != 0) {
                            identidad = false;
                        }
                    }
                }
               
            }
            if (identidad) {
                System.out.println("SI");
            } else {
                System.out.println("NO");
            }
        }
    }
    
}

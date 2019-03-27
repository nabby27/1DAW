/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Conscurso.D;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/**
 *
 * @author TeProgramo
 */
public class Main {

    static HashMap<String, Boolean> cuadradoPintado = new HashMap<String, Boolean>();

    public static void main(String[] args) {
        int filas = 0;
        int columnas = 0;
        do {
            cuadradoPintado = new HashMap<String, Boolean>();
            Scanner sc = new Scanner(System.in);
            int filaPintura = 0;
            int columnaPintura = 0;
            filas = sc.nextInt();
            columnas = sc.nextInt();
            int presion = sc.nextInt();
            cuadroPintadoVacio(filas, columnas);
            if (filas != 0 && columnas != 0) {
                do {
                    filaPintura = sc.nextInt();
                    columnaPintura = sc.nextInt();
                    if (filaPintura != -1 || columnaPintura != -1) {
                        for (int i = filaPintura-presion; i <= filaPintura+presion; i++) {
                            for (int j = columnaPintura-presion; j <= columnaPintura+presion; j++) {
                                if (i >= 0 && i < filas) {
                                    if (j >= 0 && j < columnas) {
                                        cuadradoPintado.put(i + "-" + j, true);
                                    }
                                }
                            }
                        }
                    }
                } while (filaPintura != -1 || columnaPintura != -1);
                pintarSalida();
            }
        } while (filas != 0 && columnas != 0);
    }
    
    private static void cuadroPintadoVacio(int filas, int columnas) {
        for (int i = 0; i < filas; i++) {
            for (int j = 0; j < columnas; j++) {
                cuadradoPintado.put(i + "-" + j, false);
            }
        }
    }

    private static void pintarSalida() {
        int cont = 0;
        for (Map.Entry<String, Boolean> entry : cuadradoPintado.entrySet()) {
            if (!entry.getValue()) {
                cont++;
            }
        }
        System.out.println(cont);
    }
    
}

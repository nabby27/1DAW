/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Prueba.PA;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author TeProgramo
 */
public class Main {
    
    public static void main(String[] args) {
        int numParticipantes = 0;
        do {
            ArrayList<String> competidores = new ArrayList<String>();
            ArrayList<Double> puntuacionPorRonda = new ArrayList<Double>();
            ArrayList<ArrayList<Double>> puntuaciones = new ArrayList<ArrayList<Double>>();
            Scanner sc = new Scanner(System.in);
            numParticipantes = sc.nextInt();
            if (numParticipantes != 0) {
                for (int i = 0; i < numParticipantes; i++) {
                    String competidor = sc.nextLine();
                    competidores.add(competidor);
                }
                
                for (int i = 0; i < 3; i++) {
                    String puntuacionRonda = sc.nextLine();
                    for (int j = 0; j < numParticipantes; j++) {
                        puntuacionPorRonda.add(Double.parseDouble(puntuacionRonda.split(" ")[i]));
                    }
                    puntuaciones.add(puntuacionPorRonda);
                }
                
                double ptMax = 0;
                ArrayList<Double> puntuacionMaximaCompetidores = new ArrayList<Double>();
                for (int i = 0; i < puntuaciones.size(); i++) {
                    for (int j = 0; j < puntuaciones.get(0).size(); j++) {
                        for (int k = 0; k < numParticipantes; k++) {
                            if (j == k) {
                                if (puntuaciones.get(i).get(j) > ptMax) {
                                    ptMax = puntuaciones.get(i).get(j);
                                }
                            }
                        }
                    }
                }
                
            }
        } while (numParticipantes != 0);
    }
    
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PD;

import java.util.Scanner;

/**
 *
 * @author TeProgramo
 */
public class Main {
    
    public static void main(String[] args) {
        int pasosDeVentaja = 0;
        int pasosDelLadronPorSegundo = 0;
        int pasosDelPoliciaPorSegundo = 0;
        
        do {
            int pasosHechosPolicia = 0;
            int pasosHechosLadron = 0;
            int segundos = 0;
            
            Scanner sc = new Scanner(System.in);
            String datos = sc.nextLine();
            
            pasosDeVentaja = Integer.parseInt(datos.split(" ")[0]);
            pasosDelLadronPorSegundo = Integer.parseInt(datos.split(" ")[1]);
            pasosDelPoliciaPorSegundo = Integer.parseInt(datos.split(" ")[2]);
            pasosHechosLadron = pasosDeVentaja;

            if (pasosDeVentaja != 0 || pasosDelLadronPorSegundo != 0 || pasosDelPoliciaPorSegundo != 0) {
                if (pasosDeVentaja > 0 && pasosDelLadronPorSegundo < pasosDelPoliciaPorSegundo) {
                    while (pasosHechosPolicia < pasosHechosLadron) {
                        segundos++;
                        pasosHechosPolicia += pasosDelPoliciaPorSegundo;
                        pasosHechosLadron += pasosDelLadronPorSegundo;
                    }
                }

                if (segundos == 0 && pasosDeVentaja > 0) {
                    System.out.println("Fugado");
                } else {
                    System.out.println(segundos);
                }
            }
        } while (pasosDeVentaja != 0 || pasosDelLadronPorSegundo != 0 || pasosDelPoliciaPorSegundo != 0);
        
    }
    
}

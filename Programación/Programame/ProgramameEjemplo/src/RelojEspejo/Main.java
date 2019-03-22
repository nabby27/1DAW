/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package RelojEspejo;

import java.util.ArrayList;

/**
 *
 * @author TeProgramo
 */
public class Main {
    
    static ArrayList<String> horas = new ArrayList<String>();
    
    public static void main(String[] args) {
        setData();
        calcularEspejo();
    }
    
    private static void setData() {
        String hora = "08:05";
        horas.add(hora);
        hora = "12:00";
        horas.add(hora);
        hora = "10:09";
        horas.add(hora);
    }
    
    private static void calcularEspejo() {
        for (String hora : horas) {
            Integer horaEnNumero = Integer.parseInt(hora.split(":")[0]);
            Integer minutosEnNumero = Integer.parseInt(hora.split(":")[1]);
            if (horaEnNumero == 12 || horaEnNumero == 00)
                System.out.print("12");
            else
                System.out.print(12-horaEnNumero-1);
            System.out.print(":");
            if (minutosEnNumero == 00 || minutosEnNumero == 60) 
                System.out.print("00");
            else
                System.out.print(60-minutosEnNumero);
            System.out.println("");
        }
    }
    
}

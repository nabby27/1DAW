import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio17 {
        
    public static void main(String[] args) {
        
        int num = 0;
        int dias = 0;
        int horas = 0;
        int minutos = 0;
        int segundos = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime una cantidad de segundos: ");
        num = teclado.nextInt();
        
        dias = (num / 86400);
        horas = ((num - (dias * 86400)) / 3600);
        minutos = ((num - (dias * 86400) - (horas * 3600)) / 60);
        segundos = (num - (dias * 86400) - (horas * 3600) - (minutos * 60));
        
        /* NO ES FIABLE 100%
        minutos = num / 60;
        segundos = minutos % 60;
        
        horas = minutos / 60;
        minutos = minutos % 60;
        
        dias = horas / 24;
        horas = horas % 24;
        */
        
        System.out.println(num + " seg. son: " + dias + " día/s, " + horas + " hora/s, " + minutos + " minuto/s " + segundos + " segundo/s");
   }
    
}

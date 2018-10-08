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
public class Ejercicio21 {
    
    public static void main(String[] args) {
        System.out.println("TEMPERATURA");
        
        float temperaturaMinima = 0;
        float temperaturaMaxima = 0;
        float temperatura = 0;
        int numDias = 0;
        int diaTempMinima = 0;
        int diaTempMaxima = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("¿Cuantos días tiene el mes?");
        numDias = teclado.nextInt();        
        for (int x = 0; x < numDias; x++) {
            System.out.println("¿Que temperatura hizo el día " + (x + 1) + "?");
            temperatura = teclado.nextFloat();
            if (x == 0) {
                temperaturaMaxima = temperatura;
                diaTempMaxima = (x + 1);
                temperaturaMinima = temperatura;
                diaTempMinima = (x + 1);
            } else if (temperatura < temperaturaMinima) {
                temperaturaMinima = temperatura;
                diaTempMinima = (x + 1);
            } else if (temperatura > temperaturaMaxima) {
                temperaturaMaxima = temperatura;
                diaTempMaxima = (x + 1);
            }  
        }
        
        System.out.println("El día mas caluroso fue el " + diaTempMaxima + " con " + temperaturaMaxima + "ºC");
        System.out.println("El día mas frío fue el " + diaTempMinima + " con " + temperaturaMinima + "ºC");
    }
    
}

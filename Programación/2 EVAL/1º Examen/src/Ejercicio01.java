
import java.util.Random;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio01 {
 
    static float[] temperaturas = new float[31];
    static int diaTemperaturaMinima = 0;
    static float temperaturaMinima = 0;
    static int diaTemperaturaMaxima = 0;
    static float temperaturaMaxima = 0;
    static float media = 0;
    static int mas10 = 0;
    
    public static void main(String[] args) {
        
        Rellenodelvector();
        
        temperaturaMinima();
        
        temperaturaMaxima();
        
        media();
        
        superado10grados();
       
        pintar();
    }
    
    private static void Rellenodelvector() {
        Random rnd = new Random();
        for (int i = 0; i < temperaturas.length; i++) {
            temperaturas[i] = ( (float) rnd.nextInt(201)/10);
        }
    }
    
    private static void temperaturaMinima() {
        for (int i = 0; i < temperaturas.length; i++) {
            if (i == 0 || temperaturas[i] < temperaturaMinima) {
                temperaturaMinima = temperaturas[i];
                diaTemperaturaMinima = i;            
            }
        }
    }
    
    private static void temperaturaMaxima() {
        for (int i = 0; i < temperaturas.length; i++) {   
            if (i == 0 || temperaturas[i] > temperaturaMaxima) {
                temperaturaMaxima = temperaturas[i];
                diaTemperaturaMaxima = i;            
            }
        }
    }
    
    private static void media() {
        float suma = 0;
        for (int i = 0; i < temperaturas.length; i++) {
            suma += temperaturas[i];
        }
        media = suma / temperaturas.length;
        media = Math.round(media * 10);
        media = (float) (media / 10);
    }
    
    private static void superado10grados() {
        boolean reset = true;
        for (int i = 0; i < temperaturas.length; i++) {
            if (temperaturas[i] > 10 && mas10++ > 0 || temperaturas[i] > 10 && reset) {
                mas10++;
                reset = false;
            }
            else {
                mas10 = 0;
                reset = true;
            }
        }
    }
    
    private static void pintar() {
        System.out.println("La media de temperatura del mes es: " + media + " ºC");
        System.out.println("Temperatura mínima el dia: " + (diaTemperaturaMinima+1) + " con " + temperaturaMinima + " ºC");
        System.out.println("Temperatura máxima el dia: " + (diaTemperaturaMaxima+1) + " con " + temperaturaMaxima + " ºC");
        if (mas10 >= 3)
            System.out.println("Se han superado los 10 ºC durante 3 días o más");
        else
            System.out.println("No se han superado los 10 ºC durante 3 días o más");
    }
    
}

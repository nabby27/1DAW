
import java.util.ArrayList;
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
public class Ejercicio03 {
    
    static ArrayList<Float> temperaturas = new ArrayList<Float>();
    static Float media = 0F;
    static Float minima = 0F;
    static int diaMinimaTemperatura = 0;
    static int diasTempMayorMedia = 0;
    
    public static void main(String[] args) {
        
        rellenar();
        
        temperaturaMedia();
        
        temperaturaMasBaja();
        
        diasTemperaturasMayorMedia();
        
        pintar();
    }
    
    private static void rellenar() {
        Random rnd = new Random();
        
        for (int i = 0; i < 31; i++) {
            temperaturas.add((float)rnd.nextInt(301)/10);
        }
    }
    
    private static void temperaturaMedia() {
        float suma = 0;
        for (Float temperatura : temperaturas) {
            suma += temperatura;
        }
        
        media = suma / temperaturas.size();
        media = (float) Math.round(media*10)/10;
    }
    
    private static void temperaturaMasBaja() {
        for (int i = 0; i < temperaturas.size(); i++) {
            if (i == 0 || minima > temperaturas.get(i)) {
                minima = temperaturas.get(i);
                diaMinimaTemperatura = i;
            }
        }
    }
    
    private static void diasTemperaturasMayorMedia() {
        for (Float temperatura : temperaturas) {
            if (temperatura > media) {
                diasTempMayorMedia++;
            }
        }
    }
    
    private static void pintar() {
        
        for (Float temperatura : temperaturas) {
            System.out.print(temperatura + " ");
        }
        System.out.println("");
        System.out.println("La temperatura media es: " + media + " ºC");
        System.out.println("La temperatura más baja es el dia " + (diaMinimaTemperatura+1) + " con " + minima + " ºC");
        System.out.println("Hay " + diasTempMayorMedia + " días que superan la temperatura media");
    }
    
}

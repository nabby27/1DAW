/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio07 {
    
    static final float dineroPlazofijo = 2000F;
    static final float interes = 2.75F;
    static final float meses = 06;
    static final float retencion = 18F;
    
    public static void main(String[] args) {
        float anos = (meses/12);
        float dineroTotal = (dineroPlazofijo + ((dineroPlazofijo * (interes * anos)) / 100));
        float dineroRetenido = ((dineroTotal * retencion) / 100);
        System.out.println("Tienes un dinero total de: " + dineroTotal + "€");
        System.out.println("Te han retenido: " + dineroRetenido + "€");
        System.out.println("Por eso solo puedes retirar : " + (dineroTotal - dineroRetenido) + "€");
    }
    
}

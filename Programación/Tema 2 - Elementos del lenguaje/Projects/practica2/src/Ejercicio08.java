/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio08 {
    
    static final float dineroPlazofijo = 2000F;
    static final float porcentajeInteres = 2.75F;
    static final float meses = 06;
    static final float porcentajeRetencion = 18F;
    
    public static void main(String[] args) {
        float anos = (meses/12);
        float dineroDelInteres = ((dineroPlazofijo * (porcentajeInteres * anos)) / 100);
        float dineroTotal = (dineroPlazofijo + dineroDelInteres);
        float dineroRetencion = ((dineroDelInteres * porcentajeRetencion) / 100);
        float dineroFinal = (dineroPlazofijo + (dineroDelInteres - dineroRetencion));
        System.out.println("Tienes un dinero total de: " + dineroTotal + "€");
        System.out.println("Pero te han retenido: " + dineroRetencion + "€");
        System.out.println("Por eso al fainl tienes: " + dineroFinal + "€");
    }
    
}

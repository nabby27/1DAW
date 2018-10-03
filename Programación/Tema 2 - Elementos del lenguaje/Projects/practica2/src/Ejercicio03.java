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
    
    static final float notaPrimerParcial = 8.0F;
    static final float notaSegundoParcial = 6.0F;
    static final int cantidadExamenes = 2;
    
    public static void main(String[] args) {
        System.out.println("BASE DE DATOS");
        float notaMedia = (notaPrimerParcial+notaSegundoParcial)/cantidadExamenes;
        System.out.println(notaPrimerParcial);
        System.out.println(notaSegundoParcial);
        System.out.println("La nota media es: " + notaMedia);
    }
    
}

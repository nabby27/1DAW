/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio15 {
    
    public enum diaSemana{LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO};
    
    public static void main(String[] args) {
        
        diaSemana hoy = diaSemana.MARTES;
        diaSemana dia = diaSemana.DOMINGO;

        System.out.println("Hoy es: " + hoy);
        System.out.println("Domingo es el número: " + (dia.ordinal()+1));
   }
    
}

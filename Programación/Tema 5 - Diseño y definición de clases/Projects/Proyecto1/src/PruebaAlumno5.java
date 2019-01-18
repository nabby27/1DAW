/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class PruebaAlumno5 {
    
    public static void main(String[] args) {
        
        Alumno5 alumno1 = new Alumno5("Juan", "García Fernández", 1985, 1020034569, "7031-91", 'M', 6.5F);
        Alumno5 alumno2 = new Alumno5("Iván", "Córdoba Donet", 1996, 1020034570, "7031-92", 'T', 9.3F);
        
        alumno1.imprimir();
        System.out.println("");
        alumno2.imprimir();
        
    }

}

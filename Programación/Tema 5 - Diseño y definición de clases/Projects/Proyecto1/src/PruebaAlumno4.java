/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class PruebaAlumno4 {
    
    public static void main(String[] args) {
        
        Alumno4 alumno1;
        Alumno4 alumno4;
        Alumno4 alumno5;
        Alumno4 delegado;
        
        alumno1 = new Alumno4();
        delegado = alumno1;
        alumno1.setNombre("Juan");
        
        alumno4 = new Alumno4();
        alumno4.setNombre("Clara");
        
        alumno5 = new Alumno4();
        alumno5.setNombre("Juan");
        
        System.out.println(alumno1 == delegado);
        System.out.println(alumno1 == alumno5);
        System.out.println(alumno5 == alumno4);

    }

}

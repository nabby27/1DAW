/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class PruebaAlumno3 {
    
    public static void main(String[] args) {
        
        Alumno3 alumno1 = new Alumno3();
        alumno1.setNombre("Juan");
        alumno1.setApellidos("García Fernández");
        alumno1.setAnoDeNacimiento(1985);
        alumno1.setNumeroPersonal(1020034569);
        alumno1.setGrupo("7031-91");
        alumno1.setHorario('M');
        alumno1.setNotaSelectividad(6.5F);
        
        Alumno3 alumno2 = new Alumno3();
        alumno2.setNombre("Iván");
        alumno2.setApellidos("Córdoba Donet");
        alumno2.setAnoDeNacimiento(1996);
        alumno2.setNumeroPersonal(1020034570);
        alumno2.setGrupo("7031-92");
        alumno2.setHorario('T');
        alumno2.setNotaSelectividad(9.3F);
       
        alumno1.imprimir();
        System.out.println("");
        alumno2.imprimir();
        System.out.println("");
        
        System.out.println("Media de selectividad de la pareja: " + ((alumno1.getNotaSelectividad() + alumno2.getNotaSelectividad()) / 2) );
        
    }

}

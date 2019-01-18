/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class PruebaAlumno2 {
    
    public static void main(String[] args) {
        
        Alumno2 alumno1 = new Alumno2();
        alumno1.setNombre("Juan");
        alumno1.setApellidos("García Fernández");
        alumno1.setAnoDeNacimiento(1985);
        alumno1.setNumeroPersonal(1020034569);
        alumno1.setGrupo("7031-91");
        alumno1.setHorario('M');
        
        Alumno2 alumno2 = new Alumno2();
        alumno2.setNombre("Iván");
        alumno2.setApellidos("Córdoba Donet");
        alumno2.setAnoDeNacimiento(1996);
        alumno2.setNumeroPersonal(1020034570);
        alumno2.setGrupo("7031-92");
        alumno2.setHorario('T');
        
        imprimir(alumno1);
        System.out.println("");
        imprimir(alumno2);
       
    }
    
    private static void imprimir(Alumno2 alumno) {
        System.out.println("\tDatos del alumno");
        System.out.println("\t================");
        System.out.println("Nombre: \t\t" + alumno.getNombre());
        System.out.println("Apellidos: \t\t" + alumno.getApellidos());
        System.out.println("Año de nacimiento: \t" + alumno.getAnoDeNacimiento());
        System.out.println("Número Personal: \t" + alumno.getNumeroPersonal());
        System.out.println("Grupo: \t\t\t" + alumno.getGrupo());
        System.out.println("Horario: \t\t" + alumno.getHorario());
    }

}

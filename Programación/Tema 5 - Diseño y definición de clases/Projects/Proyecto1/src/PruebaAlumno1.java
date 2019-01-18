/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class PruebaAlumno1 {
    
    public static void main(String[] args) {
        
        Alumno1 alumno1 = new Alumno1();
        alumno1.nombre = "Juan";
        alumno1.apellidos = "García Fernández";
        alumno1.anoDeNacimiento = 1985;
        alumno1.numeroPersonal = 1020034569;
        alumno1.grupo = "7031-91";
        alumno1.horario = 'M';
        
        Alumno1 alumno2 = new Alumno1();
        alumno2.nombre = "Iván";
        alumno2.apellidos = "Córdoba Donet";
        alumno2.anoDeNacimiento = 1996;
        alumno2.numeroPersonal = 1020034570;
        alumno2.grupo = "7031-92";
        alumno2.horario = 'T';
       
        imprimir(alumno1);
        System.out.println("");
        imprimir(alumno2);

    }
    
    private static void imprimir(Alumno1 alumno) {
        System.out.println("\tDatos del alumno");
        System.out.println("\t================");
        System.out.println("Nombre: \t\t" + alumno.nombre);
        System.out.println("Apellidos: \t\t" + alumno.apellidos);
        System.out.println("Año de nacimiento: \t" + alumno.anoDeNacimiento);
        System.out.println("Número Personal: \t" + alumno.numeroPersonal);
        System.out.println("Grupo: \t\t\t" + alumno.grupo);
        System.out.println("Horario: \t\t" + alumno.horario);
    }
    
}

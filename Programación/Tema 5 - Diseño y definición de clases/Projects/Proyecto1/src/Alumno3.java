/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Alumno3 {
    
    private String nombre;
    private String apellidos;
    private int anoDeNacimiento;
    private int numeroPersonal;
    private String grupo;
    private char horario;
    private float notaSelectividad;
    
    public String getNombre() {
        return this.nombre;
    }
        
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    
    public String getApellidos() {
        return this.apellidos;
    }
    
    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }
    
    public int getAnoDeNacimiento() {
        return this.anoDeNacimiento;
    }
    
    public void setAnoDeNacimiento(int anoDeNacimiento) {
        this.anoDeNacimiento = anoDeNacimiento;
    }
    
    public int getNumeroPersonal() {
        return this.numeroPersonal;
    }
    
    public void setNumeroPersonal(int numeroPersonal) {
        this.numeroPersonal = numeroPersonal;
    }
    
    public String getGrupo() {
        return this.grupo;
    }
    
    public void setGrupo(String grupo) {
        this.grupo = grupo;
    }
    
    public char getHorario() {
        return this.horario;
    }
    
    public void setHorario(char horario) {
        this.horario = horario;
    }
    
    public float getNotaSelectividad() {
        return this.notaSelectividad;
    }
    
    public void setNotaSelectividad(float notaSelectividad) {
        this.notaSelectividad = notaSelectividad;
    }
    
    public void imprimir() {
        System.out.println("\tDatos del alumno");
        System.out.println("\t================");
        System.out.println("Nombre: \t\t" + this.nombre);
        System.out.println("Apellidos: \t\t" + this.apellidos);
        System.out.println("Año de nacimiento: \t" + this.anoDeNacimiento);
        System.out.println("Número Personal: \t" + this.numeroPersonal);
        System.out.println("Grupo: \t\t\t" + this.grupo);
        System.out.println("Horario: \t\t" + this.horario);
        System.out.println("Nota selectividad: \t" + this.notaSelectividad);
    }

}

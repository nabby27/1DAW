/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio06;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Empleado {
    
    private String nombre;
    private String dni;
    private Character estadoCivil;
    private int anoDeIngreso;
    private float sueldoBrutoAnual;

    public Empleado() {
    }

    public Empleado(String nombre, String dni, Character estadoCivil, int anoDeIngreso, float sueldoBrutoAnual) {
        this.nombre = nombre;
        this.dni = dni;
        this.estadoCivil = estadoCivil;
        this.anoDeIngreso = anoDeIngreso;
        this.sueldoBrutoAnual = sueldoBrutoAnual;
    }

    public void incrementarSueldo() {
        this.sueldoBrutoAnual += this.sueldoBrutoAnual*0.1;
    }
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public Character getEstadoCivil() {
        return estadoCivil;
    }

    public void setEstadoCivil(Character estadoCivil) {
        this.estadoCivil = estadoCivil;
    }

    public int getAnoDeIngreso() {
        return anoDeIngreso;
    }

    public void setAnoDeIngreso(int anoDeIngreso) {
        this.anoDeIngreso = anoDeIngreso;
    }

    public float getSueldoBrutoAnual() {
        return sueldoBrutoAnual;
    }

    public void setSueldoBrutoAnual(float sueldoBrutoAnual) {
        this.sueldoBrutoAnual = sueldoBrutoAnual;
    }

    @Override
    public String toString() {
        return    "Nombre: " + nombre + "\n"
                + "Dni: " + dni + "\n"
                + "Estado civil: " + estadoCivil + "\n"
                + "Año de ingreso: " + anoDeIngreso + "\n"
                + "Sueldo bruto anual: " + sueldoBrutoAnual + "\n";
    }
    
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio02;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Cuenta {
    
    private Integer numCuenta;
    private String nombre;
    private String apellido;
    private Double saldo;

    public Cuenta() {
    }

    public Cuenta(Integer numCuenta, String nombre, String apellido, Double saldo) {
        this.numCuenta = numCuenta;
        this.nombre = nombre;
        this.apellido = apellido;
        this.saldo = saldo;
    }

    public Integer getNumCuenta() {
        return numCuenta;
    }

    public void setNumCuenta(Integer numCuenta) {
        this.numCuenta = numCuenta;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public Double getSaldo() {
        return saldo;
    }

    public void setSaldo(Double saldo) {
        this.saldo = saldo;
    }

    @Override
    public String toString() {
        return  numCuenta + "\t\t" + nombre + "\t\t" + apellido + "\t\t" + saldo;
    }
    
}

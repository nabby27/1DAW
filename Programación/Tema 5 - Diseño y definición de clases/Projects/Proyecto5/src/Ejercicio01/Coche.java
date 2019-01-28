/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio01;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Coche {
    
    private String modelo;
    private String color;
    private boolean pinturaMetalizada;
    private String matricula;
    private String tipo;
    private int anoFabricacion;
    private String seguro;

    public Coche() {
    }

    public Coche(String modelo, String color, boolean pinturaMetalizada, String matricula, String tipo, int anoFabricacion, String seguro) {
        this.modelo = modelo;
        this.color = color;
        this.pinturaMetalizada = pinturaMetalizada;
        this.matricula = matricula;
        this.tipo = tipo;
        this.anoFabricacion = anoFabricacion;
        this.seguro = seguro;
    }

    public void imprimeCoche() {
        System.out.println("Modelo: " + modelo + ", Color: " + color);
    }
    
    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public boolean isPinturaMetalizada() {
        return pinturaMetalizada;
    }

    public void setPinturaMetalizada(boolean pinturaMetalizada) {
        this.pinturaMetalizada = pinturaMetalizada;
    }

    public String getMatricula() {
        return matricula;
    }

    public void setMatricula(String matricula) {
        this.matricula = matricula;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public int getAnoFabricacion() {
        return anoFabricacion;
    }

    public void setAnoFabricacion(int anoFabricacion) {
        this.anoFabricacion = anoFabricacion;
    }

    public String getSeguro() {
        return seguro;
    }

    public void setSeguro(String seguro) {
        this.seguro = seguro;
    }

    @Override
    public String toString() {
        return    "Modelo: " + modelo + "\t"
                + "Color: " + color + "\t"
                + "Pintura metalizada: " + pinturaMetalizada + "\t"
                + "Matrícula: " + matricula + "\t"
                + "Tipo: " + tipo + "\t"
                + "Año de fabricacion: " + anoFabricacion + "\t"
                + "Modalidad de seguro: " + seguro;
    }
    
    
    
}

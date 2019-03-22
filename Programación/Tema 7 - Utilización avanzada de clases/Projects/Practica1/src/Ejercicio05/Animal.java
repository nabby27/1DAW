/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio05;

/**
 *
 * @author Iván Córdoba Donet
 */
public abstract class Animal {
    
    protected String especie;
    protected String ruido;
    protected String comida;

    public Animal(String especie, String ruido, String comida) {
        this.especie = especie;
        this.ruido = ruido;
        this.comida = comida;
    }

    public String obtenerComida() {
        return this.comida;
    }
    
    public String obtenerEspecie() {
        return this.especie;
    }
    
}

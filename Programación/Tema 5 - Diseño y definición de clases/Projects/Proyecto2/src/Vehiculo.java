/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Vehiculo {
 
    private String modelo;
    private Double potencia;
    private boolean cRuedas;

    public Vehiculo() {
    }

    public Vehiculo(String modelo) {
        this.modelo = modelo;
    }

    public void setPotencia(Double potencia) {
        this.potencia = potencia;
    }

    public void setcRuedas(boolean cRuedas) {
        this.cRuedas = cRuedas;
    }

    @Override
    public String toString() {
        return "Vehiculo{" + "modelo=" + modelo + ", potencia=" + potencia + ", cRuedas=" + cRuedas + '}';
    }
    
}

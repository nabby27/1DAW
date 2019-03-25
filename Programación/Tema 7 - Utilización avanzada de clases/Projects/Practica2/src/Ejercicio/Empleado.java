/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio;

/**
 *
 * @author Iván Córdoba Donet
 */
public abstract class Empleado extends Persona {
    
    protected String nomina;

    public Empleado() {
        super();
    }

    public Empleado(String nombre, String identificacion, String nomina) {
        super(nombre, identificacion);
        this.nomina = nomina;
    }
    
    public void consultarNomina() {
        System.out.println(this.nomina);
    }
    
    @Override
    public String obtenerCarnet() {
        return    "Empleado \n"
                + "======== \n"
                + super.obtenerCarnet() + "\n"
                + "Nomina: " + this.nomina;
    }
    
}

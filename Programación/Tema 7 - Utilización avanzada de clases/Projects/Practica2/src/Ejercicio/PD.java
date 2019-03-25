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
public class PD extends Empleado{
    
    private String departamenteo;

    public PD() {
        super();
    }

    public PD(String nombre, String identificacion, String nomina, String departamenteo) {
        super(nombre, identificacion, nomina);
        this.departamenteo = departamenteo;
    }
    
    public void consultarDpto() {
        System.out.println(this.departamenteo);
    }
    
    @Override
    public String obtenerCarnet() {
        return    super.obtenerCarnet() + "\n"
                + "Departamento: " + this.departamenteo + "\n";
    }
    
}

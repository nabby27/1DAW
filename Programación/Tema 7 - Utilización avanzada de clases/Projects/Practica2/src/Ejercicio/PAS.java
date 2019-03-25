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
public class PAS extends Empleado {
    
    private String area;

    public PAS() {
        super();
    }

    public PAS(String nombre, String identificacion, String nomina, String area) {
        super(nombre, identificacion, nomina);
        this.area = area;
    }
    
    public void consultarArea() {
        System.out.println(this.area);
    }
    
    @Override
    public String obtenerCarnet() {
        return    super.obtenerCarnet() + "\n"
                + "Area: " + this.area + "\n";
    }
    
}

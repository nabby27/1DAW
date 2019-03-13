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
public class Jefe {
    
    public String nombre = "Iván";
    protected int telefonoOficina;
    private int telefonoCasa;
    public int telefonoMovil;
    
    public String muestraTelefonos() {
        return    "Tlf. Oficina: " + telefonoOficina + "\n"
                + "Tlf. Casa: " + telefonoCasa + "\n"
                + "Tlf. Movil: " + telefonoMovil;
    }
    
}

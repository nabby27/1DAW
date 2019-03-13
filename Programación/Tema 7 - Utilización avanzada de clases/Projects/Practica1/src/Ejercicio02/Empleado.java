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
public class Empleado extends Jefe {
    
    @Override
    public String muestraTelefonos() {
        telefonoMovil = 3;
        int telefonoCasa = 2;
        return super.muestraTelefonos() + "\n Tlf. Casa empleado: " + telefonoCasa;
    }
    
}

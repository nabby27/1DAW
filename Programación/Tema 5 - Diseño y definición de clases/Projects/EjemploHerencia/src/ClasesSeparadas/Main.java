/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ClasesSeparadas;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        
        Tecnico t1 = new Tecnico();
        t1.setNombre("Tecnico Iván");
        System.out.println(t1.getNombre());
        
        Operario op1 = new Operario("Operario Iván");
        System.out.println(op1.getNombre());
        
        Oficial of1 = new Oficial();
        of1.setNombre("Oficial Iván");
        of1.setTelefono(123);
        System.out.println(of1.toString());
    }
    
}

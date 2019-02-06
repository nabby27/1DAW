/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ClasesJuntas;

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

abstract class Empleado {
        
    private String nombre;

    public Empleado() {
    }

    public Empleado(String nombre) {
        this.nombre = nombre;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    @Override
    public abstract String toString();
}

class Operario extends Empleado {

    private int telefono;
    
    public Operario() {
    }

    public Operario(String nombre) {
        super(nombre);
    }

    public Operario(String nombre, int telefono) {
        super(nombre);
        this.telefono = telefono;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    @Override
    public String toString() {
        return "Operario{nombre=" + getNombre() + ", telefono=" + telefono + '}';
    }

}

class Directivo extends Empleado {

    public Directivo() {
    }

    public Directivo(String nombre) {
        super(nombre);
    }

    @Override
    public String toString() {
        return "Directivo{nombre=" + getNombre() + '}';
    }

}

class Oficial extends Operario {

    public Oficial() {
    }

    public Oficial(String nombre) {
        super(nombre);
    }

    public Oficial(String nombre, int telefono) {
        super(nombre, telefono);
    }

    @Override
    public String toString() {
        return "Oficial{nombre=" + getNombre() + ", telefono=" + getTelefono() + '}';
    }

}

class Tecnico extends Operario{

    public Tecnico() {
    }

    public Tecnico(String nombre) {
        super(nombre);
    }

    public Tecnico(String nombre, int telefono) {
        super(nombre, telefono);
    }

    @Override
    public String toString() {
        return "Tecnico{nombre=" + getNombre() + ", telefono=" + getTelefono() + '}';
    }

}


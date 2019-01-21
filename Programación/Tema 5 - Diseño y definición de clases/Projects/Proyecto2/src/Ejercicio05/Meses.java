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
public class Meses {
    
    private String[] mesEspañol = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "junio", "Julio", "Agosto", "Septiembre", "Ocutbre", "Noviembre", "Diciembre"};
    private String[] mesIngles = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

    private String[] meses = new String[12];
    
    public Meses() {
        meses = mesEspañol;
    }
    
    public void cambiarIdioma() {
        if (meses == mesEspañol) {
            meses = mesIngles;
        } else {
            meses = mesEspañol;
        }
    }
    
    public String deveolverMes(int numMes) {
        numMes -= 1;
        if (numMes > meses.length)
            return "No existe ningún mes mayor de " + meses.length;
        if (numMes < 1)
            return "No existe ningun mes menor que 1";
        return meses[numMes];
    }
    
    public void imprimirMeses() {
        for (String mes : meses) {
            System.out.print(mes + " ");
        }
        System.out.println("");
    }
    
}


class Main {
    
    public static void main(String[] args) {
        Meses meses = new Meses();
        
        meses.imprimirMeses();
        System.out.println(meses.deveolverMes(6));
        
        meses.cambiarIdioma();
        meses.imprimirMeses();
        System.out.println(meses.deveolverMes(7));
        
        meses.cambiarIdioma();
        meses.imprimirMeses();
        System.out.println(meses.deveolverMes(8));
    }
    
}
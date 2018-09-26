/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Caracter {
    char character;
    
    /**
     * Método constructor de la clase Caracter 
     * 
     * @param character
     */
    public Caracter(char character) {
        this.character = character; 
    }
    
    /**
     * Método que sirve para asignar el número de veces 
     * que se repetira la variable this.character
     * 
     * @param num
     */
    public void repetir(int num) {
        int x = 0;
        while(x < num){
            System.out.println(this.character + " - " + (x+1));
            x++;
        }
    }
    
}

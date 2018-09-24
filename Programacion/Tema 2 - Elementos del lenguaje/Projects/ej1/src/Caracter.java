/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author AlumMati
 */
public class Caracter {
    char character;
    
    public Caracter(char character) {
        this.character = character; 
    }
    
    public void repetir(int num){
        int x = 0;
        while(x < num){
            System.out.println(this.character);
            x++;
        }
    }
}

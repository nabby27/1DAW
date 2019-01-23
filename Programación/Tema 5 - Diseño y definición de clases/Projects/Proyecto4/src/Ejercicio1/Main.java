package Ejercicio1;


import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String titulo = "";
        String actores = "";
        String director = "";
        String genero = "";
        Integer duracion = 0;
        String resumen = "";
        
        System.out.print("Dime el título: ");
        titulo = sc.nextLine();
        System.out.print("Dime el director: ");
        director = sc.nextLine();
        System.out.print("Dime los actores: ");
        actores = sc.nextLine();
        System.out.print("Dime el género: ");
        genero = sc.nextLine();
        System.out.print("Dime el resumen: ");
        resumen = sc.nextLine();
        System.out.print("Dime la duración: ");
        duracion = sc.nextInt();
        System.out.println("");
        
        DVDCine peli = new DVDCine(titulo, actores, director, genero, duracion, resumen);
        System.out.println(peli.muestraDVDCine());
        
        System.out.print("Es thriller? ");
        if (peli.esThriller()) {
            System.out.print("Sí");
        } else {
            System.out.print("No");
        }
        System.out.println("");
        System.out.print("Tiene resumen? ");
        if (peli.tieneResumen()) {
            System.out.print("Sí");
        } else{
            System.out.print("No");
        }
        System.out.println("");
    }
    
}

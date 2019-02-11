/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Figuras;

import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        Cuadrado c1 = new Cuadrado(3);
        do {
            menu();
        } while (true);
    }
    
    private static void menu() {
        Scanner sc = new Scanner(System.in);
        int opcion = 0;
        do {
            System.out.println("1. Area del cuadrado");
            System.out.println("2. Area del rectangulo");
            System.out.println("3. Area del cubo");
            System.out.println("4. Salir");
            opcion = sc.nextInt();
            if (opcion < 1 || opcion > 4)
                System.out.println("Opcion incorrecta");
        } while (opcion < 1 || opcion > 4);
        cargarOpcion(opcion);
    }
    
    private static void cargarOpcion(int opcion) {
        switch (opcion) {
            case 1:
                areaCuadrado();
                break;
            case 2:
                areaRectangulo();
                break;
            case 3:
                areaCubo();
                break;
            case 4:
                System.out.println("Adiós");
                System.exit(0);
                break;
        }
    }
    
    private static void areaCuadrado() {
        Scanner sc = new Scanner(System.in);
        int lado = 0;
        
        System.out.println("Cual es el lado del cuadrado?");
        lado = sc.nextInt();
        Cuadrado cuadrado = new Cuadrado(lado);
        System.out.println("El area del cuadrado es: " + cuadrado.calcularArea()); 
    }
    
    private static void areaRectangulo() {
        Scanner sc = new Scanner(System.in);
        int base = 0;
        int altura = 0;
        
        System.out.println("Cual es la base del rectangulo?");
        base = sc.nextInt();
        System.out.println("Cual es la altura del rectangulo?");
        altura = sc.nextInt();
        Rectangulo rectangulo = new Rectangulo(base, altura);
        System.out.println("El area del cuadrado es: " + rectangulo.calcularArea());
    }
    
    private static void areaCubo() {
        Scanner sc = new Scanner(System.in);
        int lado = 0;
        
        System.out.println("Cual es el lado del cubo?");
        lado = sc.nextInt();
        Cubo cubo = new Cubo(lado);
        System.out.println("El area del cuadrado es: " + cubo.calcularArea()); 
    }
    
}

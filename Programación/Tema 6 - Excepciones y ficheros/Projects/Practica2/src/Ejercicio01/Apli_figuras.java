/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio01;

import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Apli_figuras {
        
    public static void main(String[] args) {
        do {
            menu();
        } while(true);
    }
    
    private static void menu() {
        Scanner sc = new Scanner(System.in);
        int opcion = 0;
        do {
            System.out.println("Elige una opción");
            System.out.println("----------------");
            System.out.println("1 - Rectangulo");
            System.out.println("2 - Cuadrado");
            System.out.println("3 - Triangulo");
            System.out.println("4 - Salir");
            opcion = sc.nextInt();
            if (opcion < 1 || opcion > 4)
                System.out.println("Opción no valida");
        } while (opcion < 1 || opcion > 4);
        cargarOpcion(opcion);
    }
    
    private static void cargarOpcion(int opcion) {
        Scanner sc = new Scanner(System.in);
        double base = 0;
        double altura = 0;
        Figuras figura;
        switch (opcion) {
            case 1:
                System.out.println("Dime la base");
                base = sc.nextDouble();
                System.out.println("Dime la altura");
                altura = sc.nextDouble();
                figura = new Figuras(base, altura, 4);
                System.out.println("El perimetro es: " + figura.damePerimetro());
                System.out.println("El area es: " + figura.dameArea());
                break;
            case 2:
                System.out.println("Dime la base");
                base = sc.nextDouble();
                figura = new Figuras(base, 4);
                System.out.println("El perimetro es: " + figura.damePerimetro());
                System.out.println("El area es: " + figura.dameArea());
                break;
            case 3:
                System.out.println("Dime la base");
                base = sc.nextDouble();
                System.out.println("Dime la altura");
                altura = sc.nextDouble();
                figura = new Figuras(base, altura, 3);
                System.out.println("El perimetro es: " + figura.damePerimetro());
                System.out.println("El area es: " + figura.dameArea());
                break;
            case 4:
                System.out.println("Oki Adiós");
                System.exit(0);
                break;
        }
    }
    
}

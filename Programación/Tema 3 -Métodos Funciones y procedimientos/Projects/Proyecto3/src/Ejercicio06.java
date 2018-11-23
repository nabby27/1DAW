
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
public class Ejercicio06 {
    
    static Scanner sc = new Scanner(System.in);
    
    public static void main(String[] args) {
        
        float base = 0;
        float altura = 0;
        int opcion = 0;
        
        opcion = menu();        
        
        switch (opcion) {
            case 1:
                System.out.println("Dime la base");
                base = sc.nextInt();
                System.out.println("Dime la altura");
                altura = sc.nextInt();
                rectangulo(base, altura);
                break;
            case 2:
                System.out.println("Dime la base");
                base = sc.nextInt();
                cuadrado(base);
                break;
            case 3:
                System.out.println("Dime la base");
                base = sc.nextInt();
                System.out.println("Dime la altura");
                altura = sc.nextInt();
                triangulo(base, altura);
                break;
            case 4:
                salir();
                break;
            default:
                System.out.println("Opción no valida");
                break;
        }
    }

    private static int menu() {
        System.out.println("Elige la figura geométrica que deseas:");
        System.out.println("1.- Rectangulo");
        System.out.println("2.- Cuadrado");
        System.out.println("3.- Triángulo");
        System.out.println("4.- Salir");
        System.out.println("---------------------------------");
        System.out.println("Selecciona una opción");
        return sc.nextInt();
    }
 
    private static void rectangulo(float base, float altura) {
        float area = base * altura;
        float perimetro = 2 * base + 2 * altura;
        System.out.println("El area es: " + area);
        System.out.println("El perimetro es: " + perimetro);
    }
    
    private static void cuadrado(float base) {
        float area = base * 4;
        float perimetro = base * base;
        System.out.println("El area es: " + area);
        System.out.println("El perimetro es: " + perimetro);
    }
    
    private static void triangulo(float base, float altura) {
        float area = base * (altura / 2);
        System.out.println("El area es: " + area);
    }
    
    private static void salir() {
        System.out.println("Adios");
        System.exit(0);
    }
}

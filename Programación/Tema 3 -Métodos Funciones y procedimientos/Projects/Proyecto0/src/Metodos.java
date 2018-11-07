
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
public class Metodos {
    
    /**
     * 
     * @param x nums of * and lines of these
     */
    public static void ej_1(int x) {
        for (int i = 0; i < x; i++) {
            for (int j = 0; j < x; j++) {
                System.out.print("*");
            }
            System.out.println("");
        }
    }
    
    /**
     * 
     * @param num
     * @return digits of num
     */
    public static int ej_2(int num) {
        int digits = 0;
        for (int x = 1; x <= num; x*=10) {
            digits++;
        }
        return digits;
    }
    
    /**
     * 
     * @param num
     * @return digits of num
     */
    public static int ej_2b(int num) {
        String numString = Integer.toString(num);
        return numString.length();
    }
    
    /**
     * 
     * @param a Minim value of range to choose
     * @param b Maxim value of range to choose
     * @return int num choose between a and b 
     */
    public static int ej_3(int a, int b) {
        int num = 0;
        Scanner keyboard = new Scanner(System.in);
        do {
            System.out.print("Dame una opción entre " + a + " y " + b + ": ");
            num = keyboard.nextInt();
            if (num < a || num > b)
                System.out.println("Opción no valida");
        } while (num < a || num > b);
        return num;
    }
    
    /**
     * 
     * @param a num
     * @param b num
     * @param c num
     * @return the smallest number
     */
    public static int ej_4(int a, int b, int c) {
        if (a <= b && a <= c)
            return a;
        else if (b < a && b <= c)
            return b;
        else
            return c;
    }
    
    /**
     * 
     * @param num to floyd 
     */
    public static void ej_5(int num) {
        for (int i = 1; i <= num; i++) {
            for (int j = 1; j <= (i*2)-1; j++) {
                System.out.print("*");
            }
            System.out.println("");
        }
    }
    
    /**
     * 
     * @param a num
     * @param b num
     * @param c num
     * 
     * print who is the biggest number
     */
    public static void ej_6(int a, int b, int c) {
        int mayor = 0;
        if (a >= b && a >= c)
            mayor = a;
        else if (b > a && b >= c)
            mayor = b;
        else
            mayor = c;
        System.out.println("El mayor de " + a + ", " + b + ", " + c + " es: " + mayor);
    }
    
    /**
     * 
     * @param num
     * 
     * make a triangle with *
     */
    public static void ej_7(int num) {   
        for(int i = 1; i <= num; i++){
            //Espacios en blanco
            for(int j = 1; j <= num-i; j++){
                System.out.print(" ");
            }
             
            //Asteriscos
            for(int k = 1; k <= (i*2)-1; k++){
                System.out.print("*");
            }
            System.out.println();
        }
    }
    
    /**
     * 
     * @param num 
     * 
     * print the multiplication table of num
     */
    public static void ej_8(int num) {
        System.out.println("La tabla de multiplicar del " + num + " es:");
        for (int i = 0; i <= 10; i++) {
            System.out.println(num + " * " + i + " = " + (num*i));
        }
    }
    
    /**
     * 
     * @param num1
     * @param num2
     * @param num3
     * @return media aritemtica
     */
    public static float ej_9(float num1, float num2, float num3) {
        return ((num1 + num2 + num3) / 3);
    }
    
    /**
     * 
     * @param num
     * print factorial of num
     */
    public static void ej_10(int num) {
        int factorial = 0;
        for (int i = 0; i <= num; i++) {
            factorial += i;
        }
        System.out.println(factorial);
    }
    
    /**
     * 
     * @param num
     * 
     * make a rombo with *
     */
    public static void ej_11(int num) {   
        for(int i = 1; i <= (num/2)+1; i++){
            //Espacios en blanco
            for(int j = 1; j <= num-i; j++){
                System.out.print(" ");
            }
            //Asteriscos
            for(int k = 1; k <= (i*2)-1; k++){
                System.out.print("*");
            }
            System.out.println();
        }
        
        for(int i = (num/2); i >= 1; i--){
            //Espacios en blanco
            for(int j = 1; j <= num-i; j++){
                System.out.print(" ");
            }
            //Asteriscos
            for(int k = 1; k <= (i*2)-1; k++){
                System.out.print("*");
            }
            System.out.println();
        }
    }
    
    public static void menu() {
        int opcion = 0;
        Scanner keyboard = new Scanner(System.in);
        while (true) {
            System.out.println("--------------------");
            System.out.println("Elige una opción");
            System.out.println("--------------------");
            System.out.println("1.  Dibujar cuadrado");
            System.out.println("2.  Calcular número de dígitos");
            System.out.println("3.  Recoger opción válida en un rango de valores");
            System.out.println("4.  Calcular el menor de 3 números");
            System.out.println("5.  Dibujar triángulo de un nº de filas");
            System.out.println("6.  Calcular el mayor de 3 números");
            System.out.println("7.  Dibujar triangulo rectángulo de un nº de filas");
            System.out.println("8.  Mostrar tabla de multiplicar");
            System.out.println("9.  Calcular media de 3 notas");
            System.out.println("10. Calcular el sumatorio de un nº");
            System.out.println("11. Dibujar rombo");
            System.out.println("12. Salir");
            opcion = keyboard.nextInt();
            
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            switch (opcion) {

                case 1:
                    System.out.println("Dibujar cuadrado");
                    System.out.print("Dime el número de * por lado: ");
                    num1 = keyboard.nextInt();
                    ej_1(num1);
                    break;
                case 2:
                    System.out.println("Calcular número de dígitos");
                    System.out.print("Dime el número del que quieres calcular sus dígitos: ");
                    num1 = keyboard.nextInt();
                    System.out.println("El número " + num1 + " tiene " + ej_2(num1) + " cifras");
                    break;
                case 3:
                    System.out.println("Recoger opción válida en un rango de valores");
                    System.out.print("Rango mínimo: ");
                    num1 = keyboard.nextInt();
                    System.out.print("Rango máximo: ");
                    num2 = keyboard.nextInt();
                    System.out.println("El núemro es: " + ej_3(num1, num2));
                    break;
                case 4:
                    System.out.println("Calcular el menor de 3 números");
                    System.out.print("Dime el número 1");
                    num1 = keyboard.nextInt();
                    System.out.print("Dime el número 2");
                    num2 = keyboard.nextInt();
                    System.out.print("Dime el número 3");
                    num3 = keyboard.nextInt();
                    System.out.println("El número menor es: " + ej_4(num1, num2, num3));
                    break;
                case 5:
                    System.out.println("Dibujar triángulo de un nº de filas");
                    System.out.print("Dime la altura del triángulo");
                    num1 = keyboard.nextInt();
                    ej_5(num1);
                    break;
                case 6:
                    System.out.println("Calcular el mayor de 3 números");
                    System.out.print("Dime el número 1");
                    num1 = keyboard.nextInt();
                    System.out.print("Dime el número 2");
                    num2 = keyboard.nextInt();
                    System.out.print("Dime el número 3");
                    num3 = keyboard.nextInt();
                    ej_6(num1, num2, num3);
                    break;
                case 7:
                    System.out.println("Dibujar triangulo rectángulo de un nº de filas");
                    System.out.print("Dime la altura del triángulo");
                    num1 = keyboard.nextInt();
                    ej_7(num1);
                    break;
                case 8:
                    System.out.println("Mostrar tabla de multiplicar");
                    System.out.print("Dime de que número quieres la tabla de múltiplicar");
                    num1 = keyboard.nextInt();
                    ej_8(num1);
                    break;
                case 9:
                    System.out.println("Calcular media de 3 notas");
                    System.out.print("Dime la nota 1");
                    num1 = keyboard.nextInt();
                    System.out.print("Dime la nota 2");
                    num2 = keyboard.nextInt();
                    System.out.print("Dime la nota 3");
                    num3 = keyboard.nextInt();
                    System.out.println("La media es: " + ej_9(num1, num2, num3));
                    break;
                case 10:
                    System.out.println("Calcular el sumatorio de un nº");
                    System.out.print("Dime el número del que realizar el sumatorio");
                    num1 = keyboard.nextInt();
                    ej_10(num1);
                    break;
                case 11:
                    System.out.println("Dibujar rombo");
                    System.out.println("Dime de que tamaño quieres el rombo");
                    num1 = keyboard.nextInt();
                    ej_11(num1);
                    break;
                case 12:
                    System.out.println("Adiós");
                    System.exit(0);
                    break;
                default:
                    System.out.println("Opción incorrecta");
                    break;
            }
        }
    }
    
}

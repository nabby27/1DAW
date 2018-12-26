
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
public class Ejercicio14 {
    
    static String frase = "";
    
    public static void main(String[] args) {
        pedirFrase();
        do {        
            muestraMenu();
        } while(true);
    }
    
    private static void pedirFrase() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Escribe una frase:");
        frase = sc.nextLine();
    }
    
    private static void muestraMenu() {
        Scanner sc = new Scanner(System.in);
        int opcion = 0;
        System.out.println("");
        do {
            System.out.println("Elige una opción");
            System.out.println("----------------");
            System.out.println("1 - Suprimir espacios en blanco");
            System.out.println("2 - Cambiar las vocales por un carácter");
            System.out.println("3 - Cambiar la primera letra de cada palabra a mayúsculas");
            System.out.println("0 - Salir");
            opcion = sc.nextInt();
            if (opcion < 0 || opcion > 3)
                System.out.println("Opción no valida");
        } while(opcion < 0 || opcion > 3);
        
        ejecutarOpcion(opcion);
    }
    
    private static void ejecutarOpcion(int opcion) {
        switch (opcion) {
            case 1:
                suprimirBlancos(frase);
                break;
            case 2:
                cambiarVocalesACaracter(frase);
                break;
            case 3:
                primeraLetraMayuscula(frase);
                break;
            case 0:
                System.out.println("");
                System.out.println("Adiós . . .");
                System.exit(0);
                break;
        }
    }
    
    private static void suprimirBlancos(String frase) {
        String fraseCopia = "";
        System.out.println("");
        System.out.println("Frase original:");
        System.out.println(frase);        
        fraseCopia = frase.replaceAll(" ", "");        
        System.out.println("Frase sin espacios:");
        System.out.println(fraseCopia);
    }
    
    private static void cambiarVocalesACaracter(String frase) {
        Scanner sc = new Scanner(System.in);
        String fraseCopia = frase;
        String caracter = "";
        String[] vocales = {"a", "e", "i", "o", "u", "A", "E", "I", "O", "U"};
        System.out.println("");
        System.out.println("Dime el carácter por el cual quieres remplazar las vocales");
        caracter = sc.nextLine();
        System.out.println("");
        System.out.println("Frase original:");
        System.out.println(frase);
        for (String vocal : vocales) {
            fraseCopia = fraseCopia.replace(vocal, caracter);
        }
        System.out.println("Frase con las vocales cambiadas:");        
        System.out.println(fraseCopia);
    }
    
    private static void primeraLetraMayuscula(String frase) {
        String fraseCopia = frase;
        String[] palabras = fraseCopia.split(" ");
        String primeraLetraOriginal = "";
        String primeraLetra = "";
        System.out.println("");
        System.out.println("Frase original:");
        System.out.println(frase);
        System.out.println("Frase con la primera letra mayúscula:");
        for (String palabra : palabras) {
            primeraLetra = palabra.substring(0, 1);
            palabra = palabra.replaceFirst(primeraLetra, primeraLetra.toUpperCase());
            System.out.print(palabra + " ");
        }
        System.out.println("");
    }
    
}

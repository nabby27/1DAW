
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
public class Ejercicio05 {
    
    static Scanner sc = new Scanner(System.in);
    
    public static void main(String[] args) {
        
        String frase = "";
        int opcion = 0;
        
        System.out.println("Dime una frase");
        frase = sc.nextLine();
        
        opcion = menu();
       
        switch (opcion) {
            case 1:
                eliminarEspacios(frase);
                break;
            case 2:
                iniciales(frase);
                break;
            case 3:
                eliminarUltimaLetraPalabras(frase);
                break;
            case 4:
                palindromo(frase);
                break;
            case 5:
                contarVocales(frase);
                break;
            case 6:
                
                break;
            default:
                salir();
                break;
        }
    }

    private static int menu() {
        System.out.println("\t MENU DE CADENAS");
        System.out.println("1.- Eliminar espacios");
        System.out.println("2.- Iniciales");
        System.out.println("3.- Eliminar ultima letra de cada palabra");
        System.out.println("4.- Palindromo?");
        System.out.println("5.- Contar vocales");
        System.out.println("6.- Salir");
        System.out.println("\t ELIGE OPCION");
        return sc.nextInt();
    }
 
    private static void eliminarEspacios(String frase) {
        String[] palabras = frase.split(" ");
        for (String palabra : palabras) {
            System.out.print(palabra);
        }
        System.out.println("");
    }
    
    private static void iniciales(String frase) {
        String[] palabras = frase.split(" ");
        for (String palabra : palabras) {
            System.out.print(palabra.charAt(0) + ". ");
        }
        System.out.println("");
    }
    
    private static void eliminarUltimaLetraPalabras(String frase) {
        String[] palabras = frase.split(" ");
        for (int i = 0; i < palabras.length; i++) {
            System.out.print(palabras[i].substring(0, palabras[i].length()-1) + " ");
        }
        System.out.println("");
    }
    
    private static void palindromo(String frase) {
        String[] letras = frase.split("");
        boolean palindormo = true;
        for (int i = 0; i < letras.length; i++) {
            if (!letras[letras.length-1 - i].equalsIgnoreCase(letras[i])) {
                palindormo = false;
            }
        }
        if (palindormo)
            System.out.println("Es palindromo");
        else
            System.out.println("No es palindromo");
    }
    
    private static void contarVocales(String frase) {
        String[] letras = frase.split("");
        int cont = 0;
        for (int i = 0; i < letras.length; i++) {
            if (
                letras[i].equalsIgnoreCase("a") ||
                letras[i].equalsIgnoreCase("e") ||
                letras[i].equalsIgnoreCase("i") ||
                letras[i].equalsIgnoreCase("o") ||
                letras[i].equalsIgnoreCase("u")
                ) {
                cont++;
            }
        }
        System.out.println("Hay " + cont + " vocales");
    }
    
    private static void salir() {
        System.out.println("Adios");
        System.exit(0);
    }
}

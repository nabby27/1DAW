
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
public class Ejercicio10 {
    
    private static String language = "";
    public final static String valencian = "VAL";
    public final static String spanish = "CAS";
    public final static String english = "EN";
    
    public static void main(String[] args) {
        String name = "";
        Scanner keyboard = new Scanner(System.in);
        
        selectLanguage();
        
        System.out.println("Dime tu nombre:");
        name = keyboard.nextLine();
      
        hello(name);
    }
    
    private static void selectLanguage() {
        int option = 0;
        Scanner keyboard = new Scanner(System.in);
        do {
            System.out.println("Elige el idioma");
            System.out.println("---------------");
            System.out.println("1 - Valenciano");
            System.out.println("2 - Castellano");
            System.out.println("3 - Inglés");
            option = keyboard.nextInt();

            switch(option) {
                case 1:
                    System.out.println("Idioma elegido: " + valencian);
                    language = valencian;
                    break;
                case 2:
                    System.out.println("Idioma elegido: " + spanish);
                    language = spanish;
                    break;
                case 3:
                    System.out.println("Idioma elegido: " + english);
                    language = english;
                    break;
                default:
                    System.out.println("Opción no correcta");
                    break;
            }
        } while(option != 1 && option != 2 && option != 3);
    }
    
    private static void hello(String name) {
        switch(language){
            case valencian:
                System.out.println("Bon día " + name);
                break;
            case spanish:
                System.out.println("Buenos días " + name);
                break;
            case english:
                System.out.println("Good morning " + name);
                break;
        }
    }
    
}

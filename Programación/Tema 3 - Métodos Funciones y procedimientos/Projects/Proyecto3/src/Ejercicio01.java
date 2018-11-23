
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
public class Ejercicio01 {
    
    private static Scanner sc = new Scanner(System.in);
    
    public static void main(String[] args) {
        
        int opcion = 0;
        String oracion = "";
        
        System.out.println("Dime una oración:");
        oracion = sc.nextLine();
        
        opcion = menu();
        
        switch(opcion) {
            case 1:
                cambiarVocalA(oracion);
                break;
            case 2:
                mitadCadena(oracion);
                break;
            case 3:
                sustituirTexto(oracion);
                break;
            case 4:
                sustituirAsteriscos(oracion);
                break;
            case 5:
                contarVeces(oracion);
                break;
            default:
                System.out.println("Opcion no correcta");
                break;
        }
        
    }
    
    private static int menu() {
        System.out.println("1. Cambiar todas las vocales del original por la vocal 'a'.");
        System.out.println("2. Devolver la mitad de la cadena original.");
        System.out.println("3. Sustituir todas las palabras del texto “hola” por “adios”.");
        System.out.println("4. Sustituir todos los grupos de dígitos por un único carácter asterisco. La expresión regular significa un dígito o más.");
        System.out.println("5. Contar cuántas veces aparece una cadena de caracteres en el texto.");
        return sc.nextInt();
    }
    
    private static void cambiarVocalA(String oracion) {
        oracion = oracion.replace('e', 'a');
        oracion = oracion.replace('i', 'a');
        oracion = oracion.replace('o', 'a');
        oracion = oracion.replace('u', 'a');
        System.out.println(oracion);
    }
    
    private static void mitadCadena(String oracion) {
        oracion = oracion.substring(0, oracion.length()/2);
        System.out.println(oracion);
    }
    
    private static void sustituirTexto(String oracion) {
        oracion = oracion.replace("hola", "adios");
        System.out.println(oracion);
    }
    
    private static void sustituirAsteriscos(String oracion) {
        oracion = oracion.replaceAll("\\d+", "*");
        System.out.println(oracion);
    }
    
    private static void contarVeces(String oracion) {        
        int cont = 0;
        String palabras[] = oracion.split(" ");
        String pal = "";
        
        System.out.println("Que cadena quieres contar?");
        pal = sc.next();
        
        for (String palabra : palabras) {
            if (palabra.contains(pal))
                cont++;
        }
        System.out.println("Se repite " + cont + " veces");
    }
}

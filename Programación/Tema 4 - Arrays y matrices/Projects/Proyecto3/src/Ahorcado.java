
import java.util.ArrayList;
import java.util.Random;
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
public class Ahorcado {
    
    static int numMaximoIntentos = 3;
    static ArrayList<String> opcionesPalabras = new ArrayList<String>();
    
    public static void main(String[] args) {
        setOpcionesPalabrasInit();
        ahorcado();
    }
    
    private static void ahorcado() {
        int opcion = 0;
        do {
            opcion = menuPrincipal();
            cargarOpcionMenuPrincipal(opcion);
        } while(true);
    }
    
    private static int menuPrincipal() {
        Scanner sc = new Scanner(System.in);
        int num = 0;
        do {
            System.out.println("");
            System.out.println("Elige una opcón");
            System.out.println("---------------");
            System.out.println("1 - Gestionar palabras");
            System.out.println("2 - Jugar");
            System.out.println("3 - Salir");
            num = sc.nextInt();
            if (num != 1 && num != 2 && num != 3)
                System.out.println("Opción no valida");
        } while(num != 1 && num != 2 && num != 3);
        return num;
    }
    
    private static void cargarOpcionMenuPrincipal(int opcion) {
        switch (opcion) {
            case 1:
                gestionarPalabras();
                break;
            case 2:
                jugar();
                break;
            case 3:
                System.exit(0);
                break;
        }
    }
    
    private static void jugar() {
        Scanner sc = new Scanner(System.in);
        
        String palabra = elegirPalabra();
        palabra = palabra.toUpperCase();
        ArrayList<String> letrasPalabra = new ArrayList<String>();
        
        String letra = "";
        ArrayList<String> letrasAcertadas = new ArrayList<String>();
        ArrayList<String> letrasFalladas = new ArrayList<String>();
        
        int intentos = 0;
        boolean palabraAcertada = false;
        
        System.out.println("");
        System.out.println("Adivina la palabra!");
        
        for (int i = 0; i < palabra.length(); i++) {
            letrasPalabra.add(palabra.substring(i, i+1));
        }
        
        for (int i = 0; i < palabra.length(); i++) {
            System.out.print("_ ");
        }
        
        while (intentos < numMaximoIntentos && !palabraAcertada) {
            System.out.println("");
            do {
                System.out.println("Di una letra");
                letra = sc.nextLine();
                letra = letra.toUpperCase();
                if (letra.length() != 1)
                    System.out.println("Introduce una sola letra");
            } while(letra.length() != 1);
            
            if (letrasAcertadas.contains(letra) || letrasFalladas.contains(letra)) {
                System.out.println("Letra introducida anteriormente");
            }
            else if (palabra.contains(letra)) {
                System.out.println("Has acertado la letra");
                letrasAcertadas.add(letra);
                while (letrasPalabra.contains(letra)) {
                    letrasPalabra.remove(letra);
                }
            } else {
                System.out.println("No has acertado la letra");
                letrasFalladas.add(letra);
                intentos++;
                System.out.println("Error " + intentos + "/" + numMaximoIntentos);
            }
            
            pintarAhorcado(palabra, letrasAcertadas);
            
            if (letrasPalabra.size() < 1) {
                palabraAcertada = true;
            }
        }
        
        finalPartida(palabraAcertada, intentos);
    }
    
    private static void setOpcionesPalabrasInit() {
        opcionesPalabras.add("HOLA");
        opcionesPalabras.add("CARACOLA");
    }
    
    private static String elegirPalabra() {
        Random rnd = new Random();
        int num = rnd.nextInt(opcionesPalabras.size());
        return opcionesPalabras.get(num);
    }
    
    private static void finalPartida(boolean acertado, int intentos) {
        System.out.println("");
        if (acertado) {
            System.out.println("Has acertado toda la palabra con solo " + intentos + " fallos");
        }
        
        if (intentos >= numMaximoIntentos) {
            System.out.println("Se te acabaron los intentos");
        }
    }
    
    private static void pintarAhorcado(String palabraAdivinar, ArrayList<String> letrasAcertadas) {
        boolean letraPintada = false;
        for (int i = 0; i < palabraAdivinar.length(); i++) {
            letraPintada = false;
            for (String letr : letrasAcertadas) {
                if (palabraAdivinar.charAt(i) == letr.charAt(0)) {
                    System.out.print(letr + " ");
                    letraPintada = true;
                }
            }
            if (!letraPintada) {
                letraPintada = false;
                System.out.print("_ ");
            }
        }
    }
    
    private static void gestionarPalabras() {
        int opcion = 0;
        do {
            opcion = menuPalabras();
            cargarOpcionMenuPalabras(opcion);
        } while(true);
    }
    
    private static int menuPalabras() {
        Scanner sc = new Scanner(System.in);
        int num = 0;
        do{
            System.out.println("");
            System.out.println("Elige una opción");
            System.out.println("----------------");
            System.out.println("1 - Añadir palabra");
            System.out.println("2 - Listar palabras");
            System.out.println("3 - Buscar palabra");
            System.out.println("4 - Eliminar palabra");
            System.out.println("5 - Salir");
            num = sc.nextInt();
            if (num != 1 && num != 2 && num != 3 && num != 4 && num != 5)
                System.out.println("Opcion no valida");
        } while(num != 1 && num != 2 && num != 3 && num != 4 && num != 5);
        return num;
    }

    private static void cargarOpcionMenuPalabras(int opcion) {
        switch (opcion) {
            case 1:
                anadirPalabra();
                break;
            case 2:
                listarPalabra();
                break;
            case 3:
                buscarPalabra();
                break;
            case 4:
                eliminarPalabra();
                break;
            case 5:
                ahorcado();
                break;
        }
    }
    
    private static void anadirPalabra() {
        Scanner sc = new Scanner(System.in);
        String palabra = "";
        System.out.println("Escribe que palabra quieres añadir");
        palabra = sc.nextLine();
        palabra = palabra.toUpperCase();
        if (opcionesPalabras.contains(palabra)) {
            System.out.println("Esa palabra ya esta introducida");
        } else {
            opcionesPalabras.add(palabra);
            System.out.println("Palabra introducida correctamente");
        }
    }

    private static void listarPalabra() {
        for (String palabra : opcionesPalabras) {
            System.out.println(palabra);
        }
    }
    
    private static void buscarPalabra() {
        Scanner sc = new Scanner(System.in);
        String palabra = "";
        System.out.println("Que palabra quieres buscar?");
        palabra = sc.nextLine();
        palabra = palabra.toUpperCase();
        if (opcionesPalabras.contains(palabra)) {
            System.out.println("La palabra esta introducida en la posición " + opcionesPalabras.indexOf(palabra));
        } else {
            System.out.println("La palabra no esta introducida");
        }
    }
    
    private static void eliminarPalabra() {
        Scanner sc = new Scanner(System.in);
        String palabra = "";
        System.out.println("Que palabra quieres eliminar?");
        palabra = sc.nextLine();
        palabra = palabra.toUpperCase();
        if (opcionesPalabras.contains(palabra)) {
            opcionesPalabras.remove(palabra);
            System.out.println("Palabra eliminada correctamente");
        } else {
            System.out.println("La palabra no esta introducida");
        }
    }
    
}

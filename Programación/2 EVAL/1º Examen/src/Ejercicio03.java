
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
public class Ejercicio03 {
 
    static int opcion = 0;
    static String[] alumnos = new String[5];
    static String[] alumnosCopy = new String[alumnos.length];    
    static boolean encontrado = false;
    
    public static void main(String[] args) {
        
        do {
             menu();
        } while(true);   
        
    }
    
    private static void menu() {
        Scanner sc = new Scanner(System.in);

        do {
            System.out.println("Elige una opción");
            System.out.println("----------------");
            System.out.println("1 - Llenar");
            System.out.println("2 - Buscar");
            System.out.println("3 - Mostrar");
            System.out.println("4 - Caracteres");
            System.out.println("5 - Vocales");
            System.out.println("6 - Salir");
            opcion = sc.nextInt();
            if (opcion < 0 || opcion > 6)
                System.out.println("Opción erronea");
        } while(opcion < 0 || opcion > 6);
        
        switch (opcion) {
            case 1:
                llenar();
                break;
            case 2:
                buscar();
                break;
            case 3:
                mostrar();
                break;
            case 4:
                caracteres();
                break;
            case 5:
                vocales();
                break;
            case 6:
                System.out.println("Adiós...");
                System.exit(0);
                break;
        }
    }
    
    private static void llenar() {   
        Scanner sc = new Scanner(System.in);
        
        for (int i = 0; i < alumnos.length; i++) {
            System.out.println("(" + (i+1)+ "/" + alumnos.length + ") Dime el nombre y apellidos del alumno " + (i+1));
            alumnos[i] = sc.nextLine();
        }
    }
    
    private static void buscar() {
        Scanner sc = new Scanner(System.in);

        String alumnoBusar = "";
        System.out.println("Que alumno quieres buscar? (Introduce su nombre y primer apellido)");
        alumnoBusar = sc.nextLine();
        int posicionAlumno = 0;
        
        for (int i = 0; i < alumnos.length; i++) {
            for (int j = 0; j < alumnos[i].length(); j++) {
                if (alumnos[i].contains(alumnoBusar) ) {
                    posicionAlumno = i;
                    encontrado = true;
                }
            }
        }
        
        if (encontrado) {
            System.out.println("Se ha encontrado el alumno");
            System.out.println("La posición del alumno " + "'" + alumnoBusar + "' es: " + posicionAlumno);
        } else {
            System.out.println("No se ha encontrado");
        }
    }
    
    private static void mostrar() {
        for (String alumno : alumnos) {
            System.out.println(alumno);
        }
    }
    
    private static void caracteres() {
        for (String alumno : alumnos) {
            System.out.println(alumno + " tiene " + (alumno.length()-2) + " caracteres");
        }
    }
    
    private static void vocales() {
        int[] alumVocales = new int[alumnos.length];
        int indiceVocalesMenor = 0;
        int vocales = 0;
        
        for (int i = 0; i < alumVocales.length; i++){
            alumVocales[i] = 0;
        }
        
        for (int j = 0; j < alumnos.length; j++) {
            vocales = 0;
            for (int i = 0; i < alumnos[j].length(); i++) {
                if (alumnos[j].charAt(i) == 'A' || alumnos[j].charAt(i) == 'a' ||
                    alumnos[j].charAt(i) == 'E' || alumnos[j].charAt(i) == 'e' ||
                    alumnos[j].charAt(i) == 'I' || alumnos[j].charAt(i) == 'i' ||
                    alumnos[j].charAt(i) == 'O' || alumnos[j].charAt(i) == 'o' ||
                    alumnos[j].charAt(i) == 'U' || alumnos[j].charAt(i) == 'u')
                    vocales++;
            }
            alumVocales[j] = vocales;
        }
        
        for (int i = 0; i < alumVocales.length; i++) {
            if (alumVocales[i] > alumVocales[indiceVocalesMenor]) {
                indiceVocalesMenor = i;
            }
        }
        
        System.out.println("El alumno con mas vocales es: " + alumnos[indiceVocalesMenor] + " con " + alumVocales[indiceVocalesMenor] + " vocales");
    }
    
}

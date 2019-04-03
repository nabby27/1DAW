/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ02ArrayList.Agenda;

import java.io.File;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class GestionAgenda {

    static ArrayList<Contacto> agenda = new ArrayList<Contacto>();

    public static void main(String[] args) {
        do {
            menu();
        } while (true);
    }

    private static void menu() {
        Scanner sc = new Scanner(System.in);
        int opcion = 0;
        do {
            System.out.println("---MENÚ---");
            System.out.println("1. Crear contacto");
            System.out.println("2. Ver toda la agenda");
            System.out.println("3. Consultar contacto");
            System.out.println("4. Eliminar contacto");
            System.out.println("5.Salir");
            opcion = sc.nextInt();
            if (opcion < 1 || opcion > 5) {
                System.out.println("Opción invalida");
            }
            cargarOpcion(opcion);
        } while (opcion < 1 || opcion > 5);
    }

    private static void cargarOpcion(int opcion) {
        switch (opcion) {
            case 1:
                crearContacto();
                break;
            case 2:
                consultarAgenda();
                break;
            case 3:
                consultarContacto();
                break;
            case 4:
                eliminarContacto();
                break;
            case 5:
                System.out.println("Adiós :)");
                guardarAgendaEnFichero();
                System.exit(0);
                break;
        }
    }

    private static void crearContacto() {
        Scanner sc = new Scanner(System.in);

        String dni = dameAtributoParaContacto("DNI", true);
        String nombre = dameAtributoParaContacto("NOMBRE", false);
        String telefono = dameAtributoParaContacto("TELEFONO", false);

        Contacto contacto = new Contacto(nombre, telefono, dni);
        agenda.add(contacto);
    }

    private static void consultarAgenda()  {
        if (agenda.size() > 0) {
            for (Contacto contacto : agenda) {
                System.out.println(contacto.formatString(agenda.indexOf(contacto)));
            }
        } else {
            System.out.println("No existen contactos en la agenda");
        }
        System.out.println("");
    }

    private static void consultarContacto() {
        Scanner sc = new Scanner(System.in);
        String dni = "";
        do {
            System.out.println("Introduce el DNI a consultar");
            dni = sc.nextLine();
            if (dni.isEmpty()) {
                System.out.println("El DNI no puede ser vacio");
            } else if (!existeDniEnAgenda(dni)) {
                System.out.println("No existe ese usuario");
            } else if (existeDniEnAgenda(dni)) {
                mostrarContacto(dni);
            }
        } while (dni.isEmpty());
    }

    private static void eliminarContacto() {
        Scanner sc = new Scanner(System.in);
        String dni = "";
        do {
            System.out.println("Introduce el DNI a eliminar");
            dni = sc.nextLine();
            if (dni.isEmpty()) {
                System.out.println("El DNI no puede ser vacio");
            } else if (!existeDniEnAgenda(dni)) {
                System.out.println("No existe ese usuario");
            } else if (existeDniEnAgenda(dni)) {
                eliminarContacto(dni);
            }
        } while (dni.isEmpty());
    }
    
    /** METODOS AUXILIARES **/
    
    private static boolean existeDniEnAgenda(String dni) {
        boolean existeDniEnAgenda = false;
        for (Contacto contacto : agenda) {
            if (contacto.getDni().equalsIgnoreCase(dni)) {
                existeDniEnAgenda = true;
            }
        }
        return existeDniEnAgenda;
    }

    private static void mostrarContacto(String dni) {
        for (Contacto contacto : agenda) {
            if (contacto.getDni().equalsIgnoreCase(dni)) {
                System.out.println(contacto.formatString(agenda.indexOf(contacto)));
            }
        }
        System.out.println("");
    }

    private static void eliminarContacto(String dni) {
        Contacto contactoAEliminar = new Contacto();
        for (Contacto contacto : agenda) {
            if (contacto.getDni().equalsIgnoreCase(dni)) {
                contactoAEliminar = contacto;
            }
        }
        agenda.remove(contactoAEliminar);
    }
    
    private static void guardarAgendaEnFichero() {
        try {
            File ficheroURL = new File("MiAgenda.csv");
            if (ficheroURL.exists()) {
                ficheroURL.delete();
            } else {
                ficheroURL.createNewFile();
            }
            FileWriter fichero = new FileWriter(ficheroURL);
            System.out.println("DNI,NOMBRE,TELEFONO");
            for (Contacto contacto : agenda) {
                fichero.write(contacto.toString() + "\n");
            }
            fichero.close();
        } catch (Exception e) {
            System.out.println(e);
        }
    }
    
    private static String dameAtributoParaContacto(String atributo, boolean esUnico) {
        Scanner sc = new Scanner(System.in);
        String value = "";
        do {
            System.out.println("Introduce el " + atributo + ": ");
            value = sc.nextLine();
            if (value.isEmpty()) {
                System.out.println("El " + atributo + " no puede ser vacío");
            } else if (esUnico && existeDniEnAgenda(value)) {
                System.out.println("El " + atributo + " ya existe");
            }
        } while (value.isEmpty() || (esUnico && existeDniEnAgenda(value)));
        return value;
    }
    
}

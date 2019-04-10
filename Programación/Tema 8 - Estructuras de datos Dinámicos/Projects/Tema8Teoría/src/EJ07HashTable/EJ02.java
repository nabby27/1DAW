/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ07HashTable;

import java.util.Hashtable;
import java.util.Map;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class EJ02 {
    
    static Hashtable<String, Persona> personas = new Hashtable<String, Persona>();
    
    public static void main(String[] args) {
        rellenarPersonas();
        mostrarPersonas();
        consultarPersona();
    }
    
    private static void rellenarPersonas() {
        String nombre = "";
        do {
            Scanner sc = new Scanner(System.in);
            System.out.println("Introducir nueva persona ('Nombre: *' para salir)");
            System.out.print("Nombre: ");
            nombre = sc.nextLine();
            if (!nombre.equalsIgnoreCase("*")) {
                System.out.print("Edad: ");
                Integer edad = sc.nextInt();
                sc.skip("\n");
                System.out.print("Teléfono: ");
                String telefono = sc.nextLine();
                Persona persona = new Persona(nombre, edad, telefono);
                personas.put(telefono, persona);
            }
        } while(!nombre.equalsIgnoreCase("*"));
    }
    
    private static void mostrarPersonas() {
        System.out.println("Nombre \tEdad \tTeléfono");
        for (Map.Entry<String, Persona> entry : personas.entrySet()) {
            System.out.println(entry.getValue().toString());
        }
    }
    
    private static void consultarPersona() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Introduce el Telefono a buscar: ");
        String telBuscar = sc.nextLine();
        if (personas.containsKey(telBuscar)){
            System.out.println("Nombre \tEdad \tTeléfono");
            System.out.println(personas.get(telBuscar).toString());
        } else {
            System.out.println("No existe ningúna persona con ese teléfono");
        }
        
    }
    
}

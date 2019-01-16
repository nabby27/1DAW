
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
public class Main {
    
    static int numContactos;
    static Agenda agenda;
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
            
        System.out.println("Cuantos contactos quieres guardar en tu agenda?");
        numContactos = sc.nextInt();
        agenda = new Agenda(numContactos);
        
        do {
            menu();
        } while(true);
        
    }
    
    private static void menu() {
        Scanner sc = new Scanner(System.in);
        int opcion;
        String[] menu = {
            "0 - Salir",
            "1 - Añadir contacto a la agenda",
            "2 - Mostrar contactos"
        };
        
        do {
            for (String m : menu) {
                System.out.println(m);
            }
            opcion = sc.nextInt();
            if (opcion != 0 && opcion != 1 && opcion != 2)
                System.out.println("opción incorrecta");
        } while(opcion != 0 && opcion != 1 && opcion != 2);
        opcionMenu(opcion);
    }
    
    private static void opcionMenu(int opcion) {
        switch(opcion) {
            case 0:
                System.exit(0);
                break;
            case 1:
                if (agenda.isLimiteContactos()) {
                    System.out.println("La agenda esta llena");
                    menu();
                } else {
                    anadirContacto();
                }
                break;
            case 2:
                mostrarContacto();
                break;
        }
    }
    
    private static void anadirContacto() {
        Scanner sc = new Scanner(System.in);
        String nombre;
        String apellidos;
        String telefono;
        String email;
        System.out.println("Dime el nombre del contacto");
        nombre = sc.nextLine();
        System.out.println("Dime los apellidos del contacto");
        apellidos = sc.nextLine();
        System.out.println("Dime el telefono del contacto");
        telefono = sc.nextLine();
        System.out.println("Dime el email del contacto");
        email = sc.nextLine();
        
        Contacto contacto = new Contacto(nombre, apellidos, telefono, email);
        System.out.println("Añadiendo contacto...");
        agenda.addLista(contacto);
        System.out.println("Contacto añadido!");
        
    }
 
    private static void mostrarContacto() {
        System.out.println("Tu agenda");
        System.out.println("===================");
        for (Contacto c : agenda.getLista()) {
            System.out.println(c.getApellidos() + ", " + c.getNombre() + "; télf: " + c.getTelefono() + "; email: " + c.getEmail());
        }
        System.out.println("===================");
    }
    
}

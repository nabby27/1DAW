/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Main;

import DAO.DBConnection;
import java.sql.ResultSet;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) throws Exception {
        do {
            menu();
        } while(true);
    }
    
    private static void menu() throws Exception {
        int opcion = 0;
        Scanner sc = new Scanner(System.in);
        do {
            System.out.println("--------------------------");
            System.out.println("           MENU");
            System.out.println("--------------------------");
            System.out.println("1 - Insertar contacto");
            System.out.println("2 - Borrar contacto");
            System.out.println("3 - Mostrar contacto");
            System.out.println("4 - Mostrar todos contacto");
            System.out.println("5 - Salir");
            opcion = sc.nextInt();
            if (opcion < 1 || opcion > 5) {
                System.out.println("Opcion incorrecta");
            }
        } while (opcion < 1 || opcion > 5);
        runOption(opcion);
    }
    
    private static void runOption(int opcion) throws Exception {
        switch (opcion) {
            case 1:
                insertContact();
                break;
            case 2:
                deleteContact();
                break;
            case 3:
                showContact();
                break;
            case 4:
                showAllContacts();
                break;
            case 5:
                System.out.println("Adios... :)");
                System.exit(0);
                break;
        }
    }
    
    private static void insertContact() throws Exception {
        Scanner sc = new Scanner(System.in);
        String nombre = "";
        String correo = "";
        String telefono = "";
        String direccion = "";
        
        do {
            System.out.println("Nombre del contacto");
            nombre = sc.nextLine();
        } while(nombre.isEmpty());
        do {
            System.out.println("Correo del contacto");
            correo = sc.nextLine();
        } while(correo.isEmpty());
        do{
            System.out.println("Telefono del contacto");
            telefono = sc.nextLine();
        } while(telefono.isEmpty());
        do {
            System.out.println("Direccion del contacto");
            direccion = sc.nextLine();
        } while(direccion.isEmpty());
        
        Contact contact = new Contact(nombre, correo, telefono, direccion);
        
        DBConnection.insertContact(contact);
    }
    
    private static void deleteContact() throws Exception {
        Scanner sc = new Scanner(System.in);
        String nombre = "";
        
        do {
            System.out.println("Nombre del contacto a eliminar");
            nombre = sc.nextLine();
        } while(nombre.isEmpty());
        
        DBConnection.deleteContact(nombre);
    }
    
    private static void showContact() throws Exception {
        Scanner sc = new Scanner(System.in);
        String nombre = "";
        
        do {
            System.out.println("Nombre del contacto a consultar");
            nombre = sc.nextLine();
        } while(nombre.isEmpty());
        
        ResultSet contacts = DBConnection.selectContact(nombre);

        while (contacts.next()) {
            System.out.print(contacts.getString("nombre") + "\t" + contacts.getString("correo") + 
                        "\t" + contacts.getString("telefono") + "\t" + contacts.getString("direccion"));
            System.out.println("");
        }
        
    }
    
    private static void showAllContacts() throws Exception {
        ResultSet contacts = DBConnection.selectAllContacts();
        while (contacts.next()) {
            System.out.print(contacts.getString("nombre") + "\t" + contacts.getString("correo") + 
                        "\t" + contacts.getString("telefono") + "\t" + contacts.getString("direccion"));
            System.out.println("");
        }
    }
    
}

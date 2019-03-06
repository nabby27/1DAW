/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio01;

import java.util.Scanner;
import java.io.File;
import java.io.FileWriter;

/**
 *
 * @author Iván Córdoba Donet
 */
public class WriteFile {
        
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String nombre = "";
        Integer telefono = 0;
        try {
            File f = new File("Agenda.txt");
            if (f.exists()) {
                f.delete();
                f.createNewFile();
            }
            FileWriter fw = new FileWriter(f, true);
            fw.write("Nombre - Telefono\n");
            fw.write("=================\n");
            do {
                System.out.println("(Doble intro para salir)");
                System.out.println("Introduce un nombre");
                nombre = sc.nextLine();
                if (!nombre.isEmpty()) {
                    System.out.println("Introduce el telefono");
                    telefono = sc.nextInt();
                    fw.write(nombre + " - " + telefono + "\n");
                }
                sc.skip("\n");
            } while(!nombre.isEmpty());
            fw.close();
        } catch (Exception e) {
            System.out.println(e);
        }
    }
    
}

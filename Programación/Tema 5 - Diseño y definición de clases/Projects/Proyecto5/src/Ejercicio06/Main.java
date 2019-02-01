/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio06;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    static ArrayList<Empleado> empleados = new ArrayList<Empleado>();
    static int limitEmpleados = 10;
            
    public static void main(String[] args) {
        do {
            menu();
        } while(true);
    }
    
    private static void menu() {
        Scanner sc = new Scanner(System.in);
        int opcion = 0;
        
        do {
            System.out.println("Elige una opción");
            System.out.println("----------------");
            System.out.println("1. Añadir empleado");
            System.out.println("2. Incrementar sueldo a empleados con 10 años o más");
            System.out.println("3. Listar empleados");
            System.out.println("4. Salir");
            opcion = sc.nextInt();
            if (opcion < 1 || opcion > 4)
                System.out.println("Opción no valida");
        } while(opcion < 1 || opcion > 4);
        
        cargarOpcion(opcion);
    }
    
    private static void cargarOpcion(int opcion) {
        switch (opcion) {
            case 1:
                anadirEmpleado();
                break;
            case 2:
                incrementarSueldo();
                break;
            case 3:
                listarEmpleado();
                break;
            case 4:
                System.out.println("Adiós...");
                System.exit(0);
                break;
        }
    }
    
    private static void anadirEmpleado() {
        String repetir = "S";
        while(repetir.equalsIgnoreCase("S") && empleados.size() < limitEmpleados) {
            Scanner sc = new Scanner(System.in);
            String nombre;
            String dni;
            Character estadoCivil;
            int anoDeIngreso;
            float sueldoBrutoAnual;
            Empleado empleado;

            System.out.println("Dime el nombre:");
            nombre = sc.next();
            System.out.println("Dime el dni:");
            dni = sc.next();
            System.out.println("Dime el estadoCivil:");
            estadoCivil = sc.next().charAt(0);
            System.out.println("Dime el anoDeIngreso:");
            anoDeIngreso = sc.nextInt();
            System.out.println("Dime el sueldoBrutoAnual:");
            sueldoBrutoAnual = sc.nextFloat();

            empleado = new Empleado(nombre, dni, estadoCivil, anoDeIngreso, sueldoBrutoAnual);
            empleados.add(empleado);

            System.out.println("Quieres añadir otro empleado? (S/N)");
            repetir = sc.next();
        }
        if (empleados.size() >= limitEmpleados) {
            System.out.println("Ya tienes el limite de empleados");
        }
    }
    
    private static void incrementarSueldo() {
        for (Empleado empleado : empleados) {
            if (empleado.getAnoDeIngreso()+10 <= Calendar.getInstance().get(Calendar.YEAR)) {
                empleado.incrementarSueldo();
            }
        }
    }
 
    private static void listarEmpleado() {
        for (Empleado empleado : empleados) {
            System.out.println(empleado.toString());
        }
    }
    
}

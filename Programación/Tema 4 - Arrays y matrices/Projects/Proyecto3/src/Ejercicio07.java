
import java.util.HashMap;
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
public class Ejercicio07 {
    
    static double departamentoEmpleado[][] = {
        {7.30, 7.35, 9.30, 9.30, 9.30, 13.00},
        {7.30, 12.30, 13.06, 17.17, 19.00, 9.32},
        {7.30, 12.00, 13.27, 15.40, 17.07, 18.00},
        {9.00, 13.06, 7.30, 7.30, 9.30, 17.07},
        {9.14, 9.30, 17.07, 13.06, 15.40, 15.40},
        {12.30, 17.07, 7.30, 9.30, 15.40, 13.06},
        {9.00, 9.30, 13.06, 17.07, 7.30, 9.30},
    };
    
    static HashMap<Integer, String> departamentos = new HashMap<Integer, String>();
    
    public static void main(String[] args) {
        departamentos.put(0, "Panadería");
        departamentos.put(1, "Carnicería");
        departamentos.put(2, "Perfumería");
        departamentos.put(3, "Verdulería");
        departamentos.put(4, "Charcutería");
        departamentos.put(5, "Almacén");
        departamentos.put(6, "Ventas");
        do  {
            menu();
        } while(true);
    }
    
    private static void menu() {
        Scanner sc = new Scanner(System.in);
        int opcion = 0;
        do {
            System.out.println("Elige una opción");
            System.out.println("----------------");
            System.out.println("1. Empleados que llegaron antes de una hora");
            System.out.println("2. Número de empleados que llegaron entre un intervalo de tiempo");
            System.out.println("3. Número de empleados que llegaron entre un intervalo de tiempo por cada departamento");
            System.out.println("4. Salir");
            opcion = sc.nextInt();
            if (opcion < 1 || opcion > 4)
                System.out.println("La opción no es valida");
        } while(opcion < 1 || opcion > 4);
        cargarOpcion(opcion);
    }
    
    private static void cargarOpcion(int opcion) {
        switch (opcion) {
            case 1: 
                empleadosAntesDeUnaHora();
                break;
            case 2: 
                numeroEmpleadosTrabajandoEnUnIntervalo();
                break;
            case 3: 
                numeroEmpleadosPorDepartamentoAntesDeUnaHora();
                break;
            case 4: 
                System.out.println("Adiós...");
                System.exit(0);
                break;
        }
    }
 
    private static void empleadosAntesDeUnaHora() {
        Scanner sc = new Scanner(System.in);
        float hora;
        System.out.println("Dime la hora");
        hora = sc.nextFloat();
        
        System.out.println("Los empleados que estaban antes de esa hora son:");
        for (int departamento = 0; departamento < departamentoEmpleado.length; departamento++) {
            for (int empleado = 0; empleado < departamentoEmpleado[departamento].length; empleado++) {
                if (departamentoEmpleado[departamento][empleado] < hora) {
                    System.out.println("El empleado " + empleado + " del departamento " + departamento);
                }
            }
        }
    }
    
    private static void numeroEmpleadosTrabajandoEnUnIntervalo() {
        Scanner sc = new Scanner(System.in);
        float horaInicio;
        float horaFin;
        int sumador = 0;
        System.out.println("Dime la hora de inicio");
        horaInicio = sc.nextFloat();
        System.out.println("Dime la hora de fin");
        horaFin = sc.nextFloat();
        
        for (int departamento = 0; departamento < departamentoEmpleado.length; departamento++) {
            for (int empleado = 0; empleado < departamentoEmpleado[departamento].length; empleado++) {
                if (horaInicio < departamentoEmpleado[departamento][empleado] && departamentoEmpleado[departamento][empleado] < horaFin) {
                    sumador++;
                }
            }
        }
        
        System.out.println("El número de personas que trabajaban en el rango de horas de " + horaInicio + " a " + horaFin + " son:");
        System.out.println(sumador);
        
    }
    
    private static void numeroEmpleadosPorDepartamentoAntesDeUnaHora() {
        Scanner sc = new Scanner(System.in);
        float hora;
        int sumador = 0;
        System.out.println("Dime una hora");
        hora = sc.nextFloat();
        
        System.out.println("Los empleados que estaban antes de esa hora son:");
        for (int departamento = 0; departamento < departamentoEmpleado.length; departamento++) {
            sumador = 0;
            for (int empleado = 0; empleado < departamentoEmpleado[departamento].length; empleado++) {
                if (departamentoEmpleado[departamento][empleado] <= hora) {
                    sumador++;
                }
            }
            System.out.println(departamentos.get(departamento) + ": " + sumador);
        }        
    }
    
}

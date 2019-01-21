package Ejercicio02;

import java.util.ArrayList;
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
public class GestionaVehiculos {

    static ArrayList<Vehiculo> vehiculos = new ArrayList<Vehiculo>();

    public static void main(String[] args) {
        do {
            anadeVehiculo();
        } while (true);
    }

    private static void anadeVehiculo() {
        Scanner sc = new Scanner(System.in);
        String modelo = "";
        String traccionString = "";
        Double potencia = 0.0;
        boolean traccion = false;

        System.out.println("Dime el modelo");
        modelo = sc.next();
        modelo = modelo.toUpperCase();
        if (modelo.equalsIgnoreCase("FIN")) {
            salir();
        } else {
            System.out.println("Dime la potencia");
            potencia = sc.nextDouble();
            System.out.println("Tiene traccion a la 4 ruedas?");
            traccionString = sc.next();
            if (traccionString.equalsIgnoreCase("si")) {
                traccion = true;
            }
            Vehiculo vehiculo = new Vehiculo(modelo);
            vehiculo.setPotencia(potencia);
            vehiculo.setcRuedas(traccion);
            vehiculos.add(vehiculo);
        }
    }

    private static void salir() {
        for (Vehiculo vehiculo : vehiculos) {
            System.out.println(vehiculo.toString());
        }
        System.exit(0);
    }

}

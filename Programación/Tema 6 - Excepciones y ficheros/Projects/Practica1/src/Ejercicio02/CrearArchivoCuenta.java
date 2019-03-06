/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio02;

import java.io.File;
import java.io.FileWriter;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class CrearArchivoCuenta {
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String nombre = "";
        String apellido = "";
        Integer numeroCuenta = 0;
        Double saldo = 0.0;
        try {
            File f = new File("Cuentas.txt");
            if (f.exists()) {
                f.delete();
                f.createNewFile();
            }
            FileWriter fw = new FileWriter(f, true);
            do {
                System.out.println("(negativo para salir)");
                System.out.println("Introduce el numero de cuenta");
                numeroCuenta = sc.nextInt();
                if (numeroCuenta > 0) {
                    System.out.println("Introduce el nombre");
                    nombre = sc.next();
                    System.out.println("Introduce el apellido");
                    apellido = sc.next();
                    System.out.println("Introduce el saldo");
                    saldo = sc.nextDouble();
                    Cuenta cuenta = new Cuenta(numeroCuenta, nombre, apellido, saldo);
                    fw.write(cuenta.toString() + "\n");
                }
            } while (numeroCuenta > 0);
            fw.close();
        } catch (Exception e) {
            System.out.println(e);
        }
    }
    
}

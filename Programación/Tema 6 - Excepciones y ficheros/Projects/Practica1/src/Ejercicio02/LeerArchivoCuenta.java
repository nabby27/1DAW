/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio02;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;

/**
 *
 * @author Iván Córdoba Donet
 */
public class LeerArchivoCuenta {
    
    public static void main(String[] args) {
        try {
            File f = new File("Cuentas.txt");
            FileReader fr = new FileReader(f);
            BufferedReader bfr = new BufferedReader(fr);
            String linea = "";
            while((linea = bfr.readLine()) != null) {
                System.out.println(linea);
            }
        } catch (Exception e) {
            System.out.println(e);
        }
    }
    
}

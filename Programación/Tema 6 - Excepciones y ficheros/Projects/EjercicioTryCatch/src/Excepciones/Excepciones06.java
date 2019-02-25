/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Excepciones;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Excepciones06 {
    
    public static void main(String[] args) {
        try {
            String correo = "aaaa@aa.coad";
            System.out.println(correo);
            envairMensaje(correo);
            
            System.out.println("Correcto");
        } catch (Exception e) {
            System.out.println("Direccion incorrecta");
        }
    }
    
    public static void envairMensaje(String cadena) throws Exception {
        String cadenaVector[] = cadena.split("");
        boolean isCorrectArroba = false;
        boolean isCorrectPunto = false;
        boolean isCorrectLetras = true;
        int indexArroba = 0;
        int indexPunto = 0;
        
        for (int i = 0; i < cadenaVector.length; i++) {
            if (cadenaVector[i].equalsIgnoreCase("@")) {
                if (i > 0 && (cadenaVector[i-1] != null && !cadenaVector[i-1].equalsIgnoreCase(""))) {
                    if (i < cadenaVector.length-1 && (cadenaVector[i+1] != null && !cadenaVector[i+1].equalsIgnoreCase(""))) {
                        if (!cadenaVector[i-1].equalsIgnoreCase("@") && !cadenaVector[i-1].equalsIgnoreCase(".")) {
                            isCorrectArroba = true;
                            indexArroba = i;
                        }
                    }
                }
            }
            if (cadenaVector[i].equalsIgnoreCase(".")) {
                if (i > 0 && (cadenaVector[i-1] != null && !cadenaVector[i-1].equalsIgnoreCase(""))) {
                    if (i < cadenaVector.length-1 && (cadenaVector[i+1] != null && !cadenaVector[i+1].equalsIgnoreCase(""))) {
                        if (!cadenaVector[i-1].equalsIgnoreCase("@") && !cadenaVector[i-1].equalsIgnoreCase(".")) {
                            isCorrectPunto = true;
                            indexPunto = i;
                        }
                    }
                }
            }
        }
        
        for (String letra : cadenaVector) {
            if (letra.equalsIgnoreCase(" ") || letra.equalsIgnoreCase("!") || letra.equalsIgnoreCase("/") || letra.equalsIgnoreCase("$")
                    || letra.equalsIgnoreCase("#") || letra.equalsIgnoreCase("*") || letra.equalsIgnoreCase(","))
                isCorrectLetras = false;
        }
        
        if (!isCorrectLetras || !isCorrectArroba || !isCorrectPunto || (indexArroba >= indexPunto)) {
            throw new Exception("DirCorreoIncorrectoException");
        }
    }
    
}

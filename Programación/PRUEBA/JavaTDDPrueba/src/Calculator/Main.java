/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Calculator;

import java.util.ArrayList;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        calcular("");
    }
    
    public static int calcular(String text) {
        ArrayList<Integer> numeros = obtenerNumeros(text);
        ArrayList<String> operaciones = obtenerOperaciones(text);
        while (numeros.size() > 1) {
            int result = hacerOperacion(operaciones.get(0), numeros.get(0), numeros.get(1));
            numeros.remove(0);
            numeros.add(0, result);
            numeros.remove(1);
            operaciones.remove(0);
        }
        return numeros.get(0);
    }
    
    private static int hacerOperacion(String operacion, int num1, int num2) {
        Calculator calcular = new Calculator();
        int result = 0;
        switch (operacion) {
            case "*":
                result = calcular.multiplicar(num1, num2);
                break;
            case "/":
                result = calcular.dividir(num1, num2);
                break;
            case "+":
                result = calcular.sumar(num1, num2);
                break;
            case "-":
                result = calcular.restar(num1, num2);
                break;
        }
        return result;
    }
    
    public static ArrayList<Integer> obtenerNumeros(String text) {
        String[] caracteres = text.split(" ");
        ArrayList<Integer> numeros = new ArrayList<Integer>();
        for (String caracter : caracteres) {
            if (caracter.matches("-?\\d+?")) {
                numeros.add(Integer.parseInt(caracter));
            }
        }
        return numeros;
    }
    
    public static ArrayList<String> obtenerOperaciones(String text) {
        String[] caracteres = text.split("");
        ArrayList<String> operaciones = new ArrayList<String>();
        for (String caracter : caracteres) {
            if (isOperacion(caracter)) {
                operaciones.add(caracter);
            }
        }
        return operaciones;
    }
    
    private static boolean isOperacion(String operacion) {
        return  operacion.equalsIgnoreCase("+") ||
                operacion.equalsIgnoreCase("-") ||
                operacion.equalsIgnoreCase("*") ||
                operacion.equalsIgnoreCase("/");
    }
    
}

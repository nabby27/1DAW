/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Calculator;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    private static String MULTIPLICACION = "*";
    private static String DIVISION = "/";
    private static String SUMA = "+";
    private static String RESTA = "-";
    
    private static String EXP_REGULAR_OBTENER_NUMEROS = "-?\\d+?";
    
    private static ArrayList<ArrayList<String>> ordenOperaciones = new ArrayList<ArrayList<String>>();
    
    public static void main(String[] args) {
        calcular("");
    }
    
    public static int calcular(String text) {
        crearOrdenOperaciones();
        ArrayList<Integer> numeros = obtenerNumeros(text);
        ArrayList<String> operaciones = obtenerOperaciones(text);
        int resultado = realizarCalculo(numeros, operaciones);
        return resultado;
    }
    
    private static int realizarCalculo(ArrayList<Integer> numeros, ArrayList<String> operaciones) {
        while (numeros.size() > 1) {
            int indexOperacion = operacionARealizar(operaciones);
            int result = hacerOperacion(operaciones.get(indexOperacion), numeros.get(indexOperacion), numeros.get(indexOperacion + 1));
            limpiarOperacionesRealizadas(numeros, operaciones, result, indexOperacion);
        }
        return numeros.get(0);
    }
    
    private static int operacionARealizar(ArrayList<String> operaciones) {
        int i = 0;
        int j = 0;
        int indexOfOperation = 0;
        boolean encontradaOperacion = false;
        
        while (i < ordenOperaciones.size() && !encontradaOperacion) {
            j = 0;
            while (j < operaciones.size() && !encontradaOperacion) {
                if (operaciones.get(j).equalsIgnoreCase(ordenOperaciones.get(i).get(0)) || 
                    operaciones.get(j).equalsIgnoreCase(ordenOperaciones.get(i).get(1))) {
                    encontradaOperacion = true;
                    indexOfOperation = j;
                }                
                j++;
            }
            i++;
        }
        return indexOfOperation;
    }
    
    private static int hacerOperacion(String operacion, int num1, int num2) {
        Calculator calcular = new Calculator();
        int result = 0;
        
        HashMap<String, Integer> calculos = new HashMap<>();
        calculos.put(MULTIPLICACION, calcular.multiplicar(num1, num2));
        calculos.put(DIVISION, calcular.dividir(num1, num2));
        calculos.put(SUMA, calcular.sumar(num1, num2));
        calculos.put(RESTA, calcular.restar(num1, num2));
        
        for (Map.Entry<String, Integer> entry : calculos.entrySet()) {
            if (entry.getKey().equalsIgnoreCase(operacion)) {
                result = entry.getValue();
            }
        }
        
        return result;
    }
    
    private static void limpiarOperacionesRealizadas(ArrayList<Integer> numeros, ArrayList<String> operaciones, int result, int indexOperacion) {
        numeros.remove(indexOperacion);
        numeros.add(indexOperacion, result);
        numeros.remove(indexOperacion + 1);
        operaciones.remove(indexOperacion);
    }
    
    public static ArrayList<Integer> obtenerNumeros(String text) {
        String[] caracteres = text.split(" ");
        ArrayList<Integer> numeros = new ArrayList<Integer>();
        for (String caracter : caracteres) {
            if (caracter.matches(EXP_REGULAR_OBTENER_NUMEROS)) {
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
        return  operacion.equalsIgnoreCase(SUMA) ||
                operacion.equalsIgnoreCase(RESTA) ||
                operacion.equalsIgnoreCase(MULTIPLICACION) ||
                operacion.equalsIgnoreCase(DIVISION);
    }
    
    private static void crearOrdenOperaciones() {
        ArrayList<String> operacionesPrioridad1 = new ArrayList<String>(Arrays.asList(MULTIPLICACION, DIVISION));
        ArrayList<String> operacionesPrioridad2 = new ArrayList<String>(Arrays.asList(SUMA, RESTA));
        ordenOperaciones.add(operacionesPrioridad1);
        ordenOperaciones.add(operacionesPrioridad2);
    }
    
}

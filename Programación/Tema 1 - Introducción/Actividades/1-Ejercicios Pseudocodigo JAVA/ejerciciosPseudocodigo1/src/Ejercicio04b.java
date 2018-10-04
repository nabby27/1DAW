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
public class Ejercicio04b {
    
    static final int precioHora = 15;
    static final int horasSemanales = 40;
    
    public static void main(String[] args) {
        System.out.println("CALCULAR SALARIO");
        
        float salario = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime el número de horas semanales trabajadas: ");
        float horas = teclado.nextFloat();
        
        if (horas > horasSemanales) {
            horas -= horasSemanales;
            salario += horas * precioHora * 2;
        }
        salario += horasSemanales * precioHora;
        
        System.out.println("El salario calculado es: " + salario);
    }
    
}

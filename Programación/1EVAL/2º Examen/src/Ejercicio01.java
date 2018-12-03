
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
public class Ejercicio01 {
    
    public static void main(String[] args) {
        
        int nota = 0;
        Scanner sc = new Scanner(System.in);
        
        do {
            System.out.println("Dime la nota:");
            nota = sc.nextInt();
            if (nota < 0 || nota > 10)
                System.out.println("La nota introducida tiene que estar entre el 0 y el 10");
        } while (nota < 0 || nota > 10);
        
        mostrarNota(nota);
    }
    
    /**
     * método que califica (mediante un switch) la nota introducida en Insuficiente, Suficiente, Bien, Notable e Insuficiente
     * @param nota numerica entera del 0 al 10
     */
    /*
    private static void mostrarNota(int nota) {
        switch (nota) {
            case 1:
            case 2:
            case 3:
            case 4: 
                System.out.println("Insuficiente");
                break;
            case 5:
                System.out.println("Suficiente");
                break;
            case 6:
                System.out.println("Bien");
                break;
            case 7:
            case 8:
                System.out.println("Notable");
                break;
            case 9:
            case 10:
                System.out.println("Sobresaliente");
                break;
        }
    }
    */
    
    /**
     * método que califica (mediante ifs) la nota introducida en Insuficiente, Suficiente, Bien, Notable e Insuficiente
     * @param nota numerica entera del 0 al 10
     */
    private static void mostrarNota(int nota) {
        if (nota < 5)
            System.out.println("Insuficiente");
        else if (nota < 6)
            System.out.println("Suficiente");
        else if (nota < 7)
            System.out.println("Bien");
        else if (nota < 9)
            System.out.println("Notable");
        else
            System.out.println("Sobresaliente");
    }
    
}

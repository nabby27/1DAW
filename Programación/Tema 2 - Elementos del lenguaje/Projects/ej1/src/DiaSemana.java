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
public class DiaSemana {
    
    /**
     * Método principal
     * 
     * @param args 
     */
    public static void main(String[] args) {
        System.out.print("Introduce un número: ");
        Scanner teclado = new Scanner(System.in);
        int dia = teclado.nextShort();
        if (dia < 1)
            System.out.println("Día erróneo");
        else {
            switch (dia) {
                case 1:
                    System.out.println("Lunes");
                    break;
                case 2:
                    System.out.println("Martes");
                    break;
                case 3:
                    System.out.println("Miércoles");
                    break;
                case 4:
                    System.out.println("Jueves");
                    break;
                case 5:
                    System.out.println("Viernes");
                    break;
                case 6:
                    System.out.println("Sábado");
                    break;
                case 7:
                    System.out.println("Domingo");
                    break;
                default:
                    System.out.println("El día " + dia + " no existe");
                    break;
            }
        }  
    }

}

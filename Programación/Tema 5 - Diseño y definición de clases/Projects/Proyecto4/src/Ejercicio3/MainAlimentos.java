/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio3;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class MainAlimentos {
    
    static ArrayList<Alimento> alimentos = new ArrayList<>();
    
    public static void main(String[] args) {
        Alimento al1 = new Alimento("Melon", 18F, 15F, 67F, "Vegetal", 'M', 'A');
        Alimento al2 = new Alimento("Ternera", 32F, 56F, 12F, "Animal", 'A', 'M');
        Alimento al3 = new Alimento("Jabalí", 34F, 38F, 30F, "Animal", 'B', 'B');
        alimentos.add(al1);
        alimentos.add(al2);
        alimentos.add(al3);
        
        do{
            menu();
        } while(true);
        
    }
    
    private static void menu() {
        Scanner sc = new Scanner(System.in);
        int opcion = 0;
        do {
            System.out.println("Elige una opción");
            System.out.println("----------------");
            System.out.println("1. Datos de los alimentos");
            System.out.println("2. Contenido energético");
            System.out.println("3. Recomendable para deportistas");
            System.out.println("4. Es dietetico");
            System.out.println("5. Es animal");
            System.out.println("6. Cantidad de alimentos según su origen");
            System.out.println("7. Salir");
            opcion = sc.nextInt();
            if (opcion < 1 || opcion > 7)
                System.out.println("Opción incorrecta");
        } while(opcion < 1 || opcion > 7);
        cargaOpcion(opcion);
    }
    
    private static void cargaOpcion(int opcion) {
        switch (opcion){
            case 1:
                System.out.println("");
                for (Alimento alimento : alimentos) {
                    System.out.println(alimento.muestraAlimento());
                }
                System.out.println("");
                break;
            case 2:
                System.out.println("");
                for (Alimento alimento : alimentos) {
                    System.out.println(alimento.getNombre() + ": " + alimento.calculaContenidoEnergetico());
                }
                System.out.println("");
                break;
            case 3:
                System.out.println("");
                for (Alimento alimento : alimentos) {
                    System.out.println(alimento.getNombre() + ": " + alimento.esRecomendableParaDeportistas());
                }
                System.out.println("");
                break;
            case 4:
                System.out.println("");
                for (Alimento alimento : alimentos) {
                    System.out.println(alimento.getNombre() + ": " + alimento.esDietetico());
                }
                System.out.println("");
                break;
            case 5:
                System.out.println("");
                for (Alimento alimento : alimentos) {
                    if (alimento.getOrigien().equalsIgnoreCase("Animal"))
                        System.out.println(alimento.getNombre() + ": Sí");
                    else {
                        System.out.println(alimento.getNombre() + ": No");
                    }
                }
                System.out.println("");
                break;
            case 6:
                System.out.println("");
                int animal = 0;
                int vegetal = 0;
                for (Alimento alimento : alimentos) {
                    if (alimento.getOrigien().equalsIgnoreCase("Animal"))
                        animal++;
                    else
                        vegetal++;
                }
                System.out.println("De origien animal: " + animal);
                System.out.println("De origien vegetal: " + vegetal);
                System.out.println("");
                break;
            case 7:
                System.exit(0);
                break;
        }
    }
    
}

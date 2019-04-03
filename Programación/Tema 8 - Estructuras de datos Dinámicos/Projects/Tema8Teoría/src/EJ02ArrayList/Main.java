package EJ02ArrayList;

import java.util.ArrayList;
import java.util.Iterator;

public class Main {

    public static void main(String argm[]) {
        String[] colores = {"MAGENTA", "ROJO", "BLANCO", "AZUL", " VERDE"};
        String[] eliminarColores = {"ROJO", "BLANCO", "AZUL"};
        ArrayList<String> lista = new ArrayList<>();
        ArrayList<String> eliminarLista = new ArrayList<>();

        for (String color : colores) {
            lista.add(color);
        }

        for (String color : eliminarColores) {
            eliminarLista.add(color);
        }
        System.out.println("ArrayList con todos los colores: ");

        for (String color : lista) {
            System.out.print(color + " ");
        }
        System.out.println("");

        for (String color : eliminarColores) {
            System.out.print(color + " ");
        }
        System.out.println("");

        Iterator<String> it = lista.iterator();
        while (it.hasNext()) {
            if (eliminarLista.contains(it.next())) {
                it.remove();
            }
        }
        
        System.out.println("Lista original sin los colores de eliminar lista");
        for (String color : lista) {
            System.out.print(color + " ");
        }
        System.out.println("");

        
        
    }
}

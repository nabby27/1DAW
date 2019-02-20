/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio02;

import java.util.ArrayList;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Libreria {
    
    static int capacidadLibreria = 10;
    static ArrayList<Libro> libros = new ArrayList<Libro>(capacidadLibreria);
    
    public static void main(String[] args) {
        setLibros();
        System.out.println("A continuación el listado de libros");
        System.out.println("");
        listarLibros();
        precioLibros();
        System.out.println("");
        System.out.println("El indice del libro con menor precio es : " + posMenorPrecio(libros));
        System.out.println("");
        System.out.println("Borrado el libro de menor precio");
        System.out.println("");
        eliminar(libros, posMenorPrecio(libros));
        System.out.println("Rebajado los libros de categoria Cocina o Economía");
        System.out.println("");
        rebajar();
        listarLibros();
    }
    
    private static void setLibros() {
        libros.add(new Libro("Libro Genérico", "Anónimo", 100, "Sin clasificar"));
        libros.add(new Libro("La Odisea", "Homero", 23.5, "Clásicos"));
        libros.add(new Libro("Kentucky Fried Chicken, la historia", "Clark Hobston", 12, "Aventuras"));
        libros.add(new Libro("No hay dos sin tres", "Futbolistas varios", 57, "Cocina"));
        libros.add(new Libro("hipotecas variables", "Nueva orden", 200, "Economía"));
    }
    
    private static void listarLibros() {
        for (Libro libro : libros) {
            System.out.println(libro.toString());
        }
    }
    
    private static void precioLibros() {
        double sumaPrecios = 0;
        for (Libro libro : libros) {
            sumaPrecios += libro.getPrecio();
        }
        System.out.println("El precio total de todos los libros es: " + sumaPrecios);
    }
    
    private static int posMenorPrecio(ArrayList<Libro> libros) {
        int indiceMenorPrecio = 0;
        for (int i = 0; i < libros.size(); i++) {
            if (libros.get(i).getPrecio() < libros.get(indiceMenorPrecio).getPrecio()) {
                indiceMenorPrecio = i;
            }
        }
        return indiceMenorPrecio;
    }
    
    private static void eliminar(ArrayList<Libro> libros, int indiceAEliminar) {
        libros.remove(indiceAEliminar);
        listarLibros();
    }
    
    private static void rebajar() {
        for (Libro libro : libros) {
            if (libro.getCategoria().equalsIgnoreCase("Cocina") || libro.getCategoria().equalsIgnoreCase("Economía")) {
                libro.setPrecio(libro.getPrecio() - (libro.getPrecio() * 15 / 100));
            }
        }
    }
    
}

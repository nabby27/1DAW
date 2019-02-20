/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio02;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Libro {
    
    private String titulo;
    private String autor;
    private double precio;
    private String categoria;

    public Libro(String titulo, String autor, double precio, String categoria) {
        this.titulo = titulo;
        this.autor = autor;
        this.precio = precio;
        this.categoria = categoria;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getAutor() {
        return autor;
    }

    public void setAutor(String autor) {
        this.autor = autor;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public String getCategoria() {
        return categoria;
    }

    public void setCategoria(String categoria) {
        this.categoria = categoria;
    }

    @Override
    public String toString() {
        return    "Titulo: " + titulo + "\n"
                + "Autor: " + autor + "\n"
                + "Precio: " + precio + "\n"
                + "Categoria: " + categoria + "\n";
    }
    
}

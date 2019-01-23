package Ejercicio1;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class DVDCine {
    
    private String titulo;
    private String actores;
    private String director;
    private String genero;
    private Integer duracion;
    private String resumen;

    public DVDCine() {
    
    }
    
    public DVDCine(String titulo, String actores, String director, String genero, Integer duracion, String resumen) {
        this.titulo = titulo;
        this.actores = actores;
        this.director = director;
        this.genero = genero;
        this.duracion = duracion;
        this.resumen = resumen;
    }
    
    public boolean esThriller() {
        return this.genero.equalsIgnoreCase("thriller");
    }
    
    public boolean tieneResumen() {
        return !this.resumen.isEmpty();
    }
    
    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getActores() {
        return actores;
    }

    public void setActores(String actores) {
        this.actores = actores;
    }

    public String getDirector() {
        return director;
    }

    public void setDirector(String director) {
        this.director = director;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public Integer getDuracion() {
        return duracion;
    }

    public void setDuracion(Integer duracion) {
        this.duracion = duracion;
    }

    public String getResumen() {
        return resumen;
    }

    public void setResumen(String resumen) {
        this.resumen = resumen;
    }
    
    public String muestraDVDCine() {
        return this.titulo.toUpperCase() + "\n"
                + "Del director: " + this.director + "\n"
                + "Con: " + this.actores + "\n"
                + this.genero + " - " + this.duracion + " min. \n"
                + "Resumen: " + this.resumen;
    }
    
}

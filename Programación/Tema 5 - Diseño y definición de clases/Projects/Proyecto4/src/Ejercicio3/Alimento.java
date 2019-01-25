/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio3;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Alimento {
    
    private String nombre;
    private float lipidos;
    private float  hidratos;
    private float proteinas;
    private String origien;
    private Character vitaminas;
    private Character minerales;

    public Alimento() {
    }

    public Alimento(String nombre) {
        this.nombre = nombre;
    }

    public Alimento(String nombre, float lipidos, float hidratos, float proteinas, String origien, Character vitaminas, Character minerales) {
        this.nombre = nombre;
        this.lipidos = lipidos;
        this.hidratos = hidratos;
        this.proteinas = proteinas;
        this.origien = origien;
        this.vitaminas = vitaminas;
        this.minerales = minerales;
    }
    
    public boolean esDietetico() {
        if (this.vitaminas == 'B' && this.lipidos < 20)
            return true;
        return false;
    }
    
    public String muestraAlimento() {
        return "Nombre: " + this.nombre + "\t"
                + "Lipidos " + this.lipidos + "%\t"
                + "Hidratos " + this.hidratos + "%\t"
                + "Proteinas " + this.proteinas + "%\t"
                + "Origen " + this.origien + "\t"
                + "Vitaminas " + this.vitaminas + "\t"
                + "Minerales " + this.minerales + "\t";
    }
    
    public float calculaContenidoEnergetico() {
        return 9.4F * (this.lipidos/100) + 5.3F * (this.proteinas/100) + 4.1F * (this.hidratos/100);
    }
    
    public boolean esRecomendableParaDeportistas() {
        return this.proteinas > 10 && this.proteinas < 15 && this.lipidos > 30 && this.lipidos < 35 && this.hidratos > 55 && this.hidratos < 65;
    }
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public float getLipidos() {
        return lipidos;
    }

    public void setLipidos(float lipidos) {
        this.lipidos = lipidos;
    }

    public float getHidratos() {
        return hidratos;
    }

    public void setHidratos(float hidratos) {
        this.hidratos = hidratos;
    }

    public float getProteinas() {
        return proteinas;
    }

    public void setProteinas(float proteinas) {
        this.proteinas = proteinas;
    }

    public String getOrigien() {
        return origien;
    }

    public void setOrigien(String origien) {
        this.origien = origien;
    }

    public Character getVitaminas() {
        return vitaminas;
    }

    public void setVitaminas(Character vitaminas) {
        this.vitaminas = vitaminas;
    }

    public Character getMinerales() {
        return minerales;
    }

    public void setMinerales(Character minerales) {
        this.minerales = minerales;
    }
    
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio2;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Pantano {
    
    private String nombreEmbalse;
    private Integer capacidadTotal;
    private Integer aguaAlmacenada;

    public Pantano() {
    }

    public Pantano(String nombreEmbalse) {
        this.nombreEmbalse = nombreEmbalse;
    }

    public Pantano(String nombreEmbalse, Integer capacidadTotal, Integer aguaAlmacenada) {
        this.nombreEmbalse = nombreEmbalse;
        this.capacidadTotal = capacidadTotal;
        this.aguaAlmacenada = aguaAlmacenada;
    }

    public void incrementarCantidad(Integer num) {
        this.aguaAlmacenada += num;
    }
    
    public Integer redProcentaje() {
        return (aguaAlmacenada * 100) / capacidadTotal;
    }
    
    public String getNombreEmbalse() {
        return nombreEmbalse;
    }

    public void setNombreEmbalse(String nombreEmbalse) {
        this.nombreEmbalse = nombreEmbalse;
    }

    public Integer getCapacidadTotal() {
        return capacidadTotal;
    }

    public void setCapacidadTotal(Integer capacidadTotal) {
        this.capacidadTotal = capacidadTotal;
    }

    public Integer getAguaAlmacenada() {
        return aguaAlmacenada;
    }

    public void setAguaAlmacenada(Integer aguaAlmacenada) {
        this.aguaAlmacenada = aguaAlmacenada;
    }

    @Override
    public String toString() {
        return nombreEmbalse + "\t" + aguaAlmacenada + "\t" + capacidadTotal + "\t" + this.redProcentaje()+ "%";
    }

}

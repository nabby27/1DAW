/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio04;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Reloj {
    
    private int horas;
    private int minutos;
    private int segundos;
    private int formato;
    
    public Reloj() {
        this.horas = 0;
        this.minutos = 0;
        this.segundos = 0;
        this.formato = 24;
    }

    public Reloj(int horas, int minutos, int segundos) {
        this.horas = horas;
        this.minutos = minutos;
        this.segundos = segundos;
        this.formato = 24;
    }
    
    public void ponerEnHora(int hora, int min) {
        this.horas = hora;
        this.minutos = min;
        this.segundos = 0;
    }
    
    public void ponerEnHora(int hora, int min, int seg) {
        this.horas = hora;
        this.minutos = min;
        this.segundos = seg;
    }
    
    public String dameHoraCompleta() {
        return this.horas + ":" + this.minutos + ":" + this.segundos;
    }
    
    public String dameHoraEn24h() {
        return this.horas + ":" + this.minutos + ":" + this.segundos;
    }
    
    public String dameHora() {
        int hora = this.horas;
        String amPm = "am";
        if (formato == 12 && hora > 12) {
            amPm = "pm";
            hora -= 12;
            return hora + ":" + this.minutos + ":" + this.segundos + " " + amPm;
        }
        return this.horas + ":" + this.minutos + ":" + this.segundos;
    }

    public void setFormato(int formato) {
        this.formato = formato;
    }
    
}

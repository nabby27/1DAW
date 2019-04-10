/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package FECHAS;

import java.text.SimpleDateFormat;
import java.util.Date;

/**
 *
 * @author AlumMati
 */
public class ManejarFechas {

    public static void main(String[] args) {
        String fecha, hora, diaDeSemana;
        diaDeSemana = getDiaDeLaSemana();
        fecha = getFechaActual();
        hora = getHoraActual();
        System.out.println(diaDeSemana + " " + fecha + " " + hora);
    }

    public static String getDiaDeLaSemana() {
        Date ahora = new Date();
        SimpleDateFormat formateador = new SimpleDateFormat("EEEE");
        return formateador.format(ahora);
    }
    
    public static String getFechaActual() {
        Date ahora = new Date();
        SimpleDateFormat formateador = new SimpleDateFormat("dd/MM/yyyy");
        return formateador.format(ahora);
    }

    public static String getHoraActual() {
        Date ahora = new Date();
        SimpleDateFormat formateador = new SimpleDateFormat("hh:mm:ss");
        return formateador.format(ahora);
    }

}

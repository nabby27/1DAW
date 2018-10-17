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
public class Ejercicio12 {
    
    static final int horaMinima = 10;
    static final int horaMaxima = 20;
    static final int minutoMinimo = 0;
    static final int minutoMaximo = 59;
    
    static final int precioMenos1horaEnMinutos = 8;
    static final int precioEntre1y2horaEnMinutos = 6;
    static final int precioEntre2y4horaEnMinutos = 4;
    static final int precioMas4horaEnEuros = 12;
    
    public static void main(String[] args) {
        
        int horaEntrada = 0;
        int horaSalida = 0;
        int minutosEntrada = 0;
        int minutosSalida = 0;
        
        int horasEnCentro = 0;
        int minutosEnCentro = 0;
        int minutosTotales = 0;
        int precioTotalEnCentimos = 0;
        int precioTotalEnEuros = 0;
        String precioFinal = "";
        Scanner teclado = new Scanner(System.in);
        
        horaEntrada = pedirHora(horaMinima, horaMaxima, "entrada");
        minutosEntrada = pedirMinutos(minutoMinimo, minutoMaximo, "entrada");
        horaSalida = pedirHora(horaMinima, horaMaxima, "salida");
        minutosSalida = pedirMinutos(minutoMinimo, minutoMaximo, "salida");
        
        horasEnCentro = (horaSalida - horaEntrada);
        minutosEnCentro = (minutosSalida - minutosEntrada);
        
        minutosTotales = (minutosEnCentro + (horasEnCentro * 60));
        
        if (minutosTotales / 60 < 1)
            precioTotalEnCentimos = minutosTotales * precioMenos1horaEnMinutos;
        else if ((minutosTotales / 60 >= 1) && (minutosTotales / 60 < 2)) 
            precioTotalEnCentimos = minutosTotales * precioEntre1y2horaEnMinutos;
        else if ((minutosTotales / 60 >= 2) && (minutosTotales / 60 < 4))
            precioTotalEnCentimos = minutosTotales * precioEntre2y4horaEnMinutos;
        else 
            precioTotalEnEuros = precioMas4horaEnEuros;
        
        precioFinal = calcularPrecioTotal(precioTotalEnEuros, precioTotalEnCentimos);
        
        System.out.println("Ha permanecido " + minutosTotales + " minutos en el parque");
        System.out.println("El precio total son " + precioFinal);
    }
    
    public static int pedirHora(int horaInicial, int horaFinal, String tipo) {
        int hora = 0;
        Scanner teclado = new Scanner(System.in);
        do {
            System.out.print("¿Hora de " + tipo + "? (desde las " + horaInicial + " a las " + (horaFinal-1) + "): ");
            hora = teclado.nextInt();
            if (hora < horaInicial || hora >= horaFinal) 
                System.out.println("El centro no esta abierto a esa hora");
        } while(hora < horaInicial || hora >= horaFinal); 
        return hora;
    }
    
    public static int pedirMinutos(int minInicial, int minFinal, String tipo) {
        int minutosEntrada = 0;
        Scanner teclado = new Scanner(System.in);
        do {
            System.out.print("¿Minutos de " + tipo + "? (desde las " + minInicial + " a las " + minFinal + "): ");
            minutosEntrada = teclado.nextInt();
            if (minutosEntrada < minInicial || minutosEntrada > minFinal) 
                System.out.println("No es un minuto valido");
        } while(minutosEntrada < minInicial || minutosEntrada > minFinal); 
        return minutosEntrada;
    }
    
    public static String calcularPrecioTotal(int precioEnEuros, int precioEnCentimos) {
        
        if (precioEnCentimos % 100 >= 0) {
            precioEnEuros += precioEnCentimos / 100;
            precioEnCentimos %= 100;
        }
        return precioEnEuros + "€ y " + precioEnCentimos + " centimos";
    }
    
}

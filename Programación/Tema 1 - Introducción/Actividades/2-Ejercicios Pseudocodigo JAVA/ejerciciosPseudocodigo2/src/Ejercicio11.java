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
public class Ejercicio11 {
    
    static final int porcentajeIVA = 21;
    static final int porcentajeDescuento = 5;
    static final int precioMinimoDescuento = 500;    
    
    public static void main(String[] args) {
        System.out.println("FACTURA");
        
        int precioTotalBruto = 0;
        int precioTotalNeto = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("¿Cuanto vale el producot?");
        int precio = teclado.nextInt();
        System.out.println("¿Cuantos has comprado?");
        int cantidad = teclado.nextInt();
        precioTotalBruto = (precio * cantidad);
        precioTotalNeto = (precioTotalBruto + ((precioTotalBruto * porcentajeIVA) / 100));
        if (precioTotalNeto > precioMinimoDescuento) {
            precioTotalNeto = (precioTotalNeto - ((precioTotalNeto * porcentajeDescuento) / 100));
            System.out.println("Tienes descuento, el precio total es: " + precioTotalNeto + "€");
        } else
            System.out.println("No tiene descuento, el precio total es: " + precioTotalNeto + "€");
    }
}

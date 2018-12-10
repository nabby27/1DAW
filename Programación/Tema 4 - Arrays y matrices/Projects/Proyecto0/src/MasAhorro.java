
import java.util.ArrayList;
import java.util.HashMap;
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
public class MasAhorro {
    
    static Scanner sc = new Scanner(System.in);
    static int codProducto = 0;
    static HashMap lineaProducto = new HashMap<>();
    static ArrayList<HashMap> totalCompra = new ArrayList<HashMap>(); 
        
    public static void main(String[] args) {
        
        introducirProductos();
        System.out.println("-----------------");
        calcularPrecio();
        descuentos();
    }
    
    private static void introducirProductos() {
        do {
            lineaProducto = new HashMap<>();
            System.out.println("Nº producto - 0 para salir");
            codProducto = sc.nextInt();
            if (codProducto != 0) {
                lineaProducto.put("codProducto", codProducto);
                System.out.println("Nº de unidades del producto");
                lineaProducto.put("cantidad", sc.nextInt());
                System.out.println("Precio Unitario");
                lineaProducto.put("precio", sc.nextFloat());
                totalCompra.add(lineaProducto);
            } else {
                System.out.println("Calculando compra...");
            }
        } while (codProducto != 0);
    }
    
    private static void calcularPrecio() {
        float total = 0;
        float totalLinea = 0;
        for (HashMap linea : totalCompra) {
            System.out.print(linea.get("cantidad") + " * " + linea.get("precio") + " = ");
            totalLinea = Integer.parseInt(linea.get("cantidad").toString()) * Float.parseFloat(linea.get("precio").toString());
            System.out.println(totalLinea);
            total += totalLinea;
            linea.replace("precio", totalLinea);
        }
        System.out.println("Total: " + total + " €");
    }
    
    private static void descuentos() {
        String firstDigitCod = "";
        Integer porcentajeDescuento = 0;
        Float precioDescuento = 0F;
        Float precioConDescuento = 0F;
        Float totalIVADescuento = 0F;
        Float totalPrecioDescontado = 0F;
        System.out.println("Descuentos: ");
        for (HashMap linea : totalCompra) {
            firstDigitCod = calcularUltimoDigitoCodigo(linea);
            porcentajeDescuento = calcularPorcentajeDescuento(firstDigitCod);
            precioConDescuento = Float.parseFloat(linea.get("precio").toString()) - ((Float.parseFloat(linea.get("precio").toString()) * porcentajeDescuento) / 100)*100/100;
            precioDescuento = (Float.parseFloat(linea.get("precio").toString()) - precioConDescuento)*100/100;
            totalIVADescuento += precioDescuento;
            totalPrecioDescontado += precioConDescuento;
            System.out.printf("Base " + porcentajeDescuento + " : %.2f descuento: %.2f \n", precioConDescuento, precioDescuento);
        }
        System.out.printf("Total iva descontado: %.2f \n", totalIVADescuento);
        System.out.printf("Total descontado: %.2f \n", totalPrecioDescontado);
    }
    
    private static String calcularUltimoDigitoCodigo(HashMap linea) {
        String fisrstNumber = "";
        fisrstNumber = linea.get("codProducto").toString();
        fisrstNumber = fisrstNumber.substring(0, 1);
        return fisrstNumber;
    }
    
    private static Integer calcularPorcentajeDescuento(String firstDigitCod) {
        switch (firstDigitCod){
            case "1":
            case "2":
            case "3":
                return 4;
            case "4":
            case "5":
            case "6":
                return 10;
            case "7":
            case "8":
            case "9":
                return 21;
        }
        return null;
    }
}

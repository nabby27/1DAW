/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Main;

import DAO.DBConnection;
import java.io.File;
import java.io.FileWriter;
import java.sql.ResultSet;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) throws Exception {
        do {
            menu();
        } while(true);
    }
    
    private static void menu() throws Exception {
        int opcion = 0;
        Scanner sc = new Scanner(System.in);
        do {
            System.out.println("--------------------------");
            System.out.println("     Gestión libreria");
            System.out.println("--------------------------");
            System.out.println("1 - Insertar Libro");
            System.out.println("2 - Borrar Libro");
            System.out.println("3 - Mostrar Libros");
            System.out.println("4 - Buscar Libro");
            System.out.println("5 - Cambiar Stock");
            System.out.println("6 - Insertar Venta");
            System.out.println("7 - Crear fichero venta");
            System.out.println("8 - Salir");
            opcion = sc.nextInt();
            if (opcion < 1 || opcion > 8) {
                System.out.println("Opcion incorrecta");
            }
        } while (opcion < 1 || opcion > 8);
        runOption(opcion);
    }
    
    private static void runOption(int opcion) throws Exception {
        switch (opcion) {
            case 1:
                insertBook();
                break;
            case 2:
                deleteBook();
                break;
            case 3:
                showAllBook();
                break;
            case 4:
                showBook();
                break;
            case 5:
                changeStock();
                break;
            case 6:
                insertSale();
                break;
            case 7:
                createSaleFile();
                break;
            case 8:
                System.out.println("Adiós... :)");
                System.exit(0);
                break;
        }
    }
    
    private static String getFromScanner(String textToShow) {
        Scanner sc = new Scanner(System.in);
        String text = "";
        do {
            System.out.println(textToShow);
            text = sc.nextLine();
            if (text.equals("") || text.isEmpty()) {
                System.out.println("El campo no puede ser vacío");
            }
        } while(text.equals("") || text.isEmpty());
        return text;
    }
    
    private static void insertBook() throws Exception {
        String cod = getFromScanner("Introduce el codigo del libro");
        String author = getFromScanner("Introduce el autor del libro");
        String title = getFromScanner("Introduce el titulo del libro");
        String price = getFromScanner("Introduce el precio del libro");
        String stock = getFromScanner("Introduce el stock del libro");
        
        Book book = new Book(cod, author, title, price, stock);
        DBConnection.insertBook(book);
    }
    
    private static void deleteBook() throws Exception {
        String cod = getFromScanner("Introduce el codigo del libro");
        
        DBConnection.deleteBook(cod);
    }
    
    private static void showAllBook() throws Exception {
        ResultSet books = DBConnection.selectAllBooks();
        System.out.println("Codigo \t Autor \t Titulo \t Precio \t Stock");
        while (books.next()) {
            System.out.println(books.getString(1) + "\t" + books.getString(2) + "\t" + books.getString(3) + "\t" +
                                books.getString(4) + "\t\t" + books.getString(5));
            System.out.println("");
        }
    }
    
    private static void showBook() throws Exception {
        String cod = getFromScanner("Introduce el codigo del libro");
        ResultSet books = DBConnection.selectBook(cod);
        System.out.println("Codigo \t Autor \t Titulo \t Precio \t Stock");
        while (books.next()) {
            System.out.println(books.getString(1) + "\t" + books.getString(2) + "\t" + books.getString(3) + "\t" +
                                books.getString(4) + "\t\t" + books.getString(5));
            System.out.println("");
        }
    }
    
    private static void changeStock() throws Exception {
        String cod = getFromScanner("Introduce el codigo del libro");
        String stock = getFromScanner("Introduce el stock del libro");
        DBConnection.changeStock(cod, stock);
    }
    
    private static void insertSale() throws Exception {
        Scanner sc = new Scanner(System.in);
        int option = 0;
        ArrayList<String> cods = new ArrayList<String>();
        String codSale = getFromScanner("Introduce el codigo de venta");
        do {
            System.out.println("0 - Insertar Libro");
            System.out.println("1 - Terminar Venta");
            option = sc.nextInt();
            if (option < 0 || option > 1) {
                System.out.println("Opcion incorrecta");
            }
            if (option == 0) {
                String codBook = getBookToList();
                if (codBook != null) {
                   cods.add(codBook);
                }
            }
        } while (option != 1);
        
        String totalPrice = "0.0";
        for (String codBook : cods) {
            ResultSet book = DBConnection.selectBook(codBook);
            while(book.next()) {
                totalPrice = (Float.parseFloat(totalPrice) + Float.parseFloat(book.getString(4))) + "";
            }
        }
        
        Sale sale = new Sale(codSale, LocalDate.now().toString(), totalPrice, cods.toString());
        
        int insertSucces = DBConnection.insertSale(sale);
        if (insertSucces > 0) {
            for (String codBook : cods) {
                ResultSet book = DBConnection.selectBook(codBook);
                while(book.next()) {
                    DBConnection.changeStock(codBook, (Integer.parseInt(book.getString(5)) - 1) + "");
                }
            }   
        }
    }
    
    private static String getBookToList() throws Exception {
        String cod = getFromScanner("Introduce el codigo del libro");
        if (DBConnection.existBook(cod)) {
            return cod;
        } else {
            System.out.println("El libro no existe");
            return null;
        }
    }
    
    private static void createSaleFile() throws Exception {
        File file = new File("registroDeVentas.txt");
        if (file.exists()) {
            file.delete();
        }
        file.createNewFile();
        FileWriter fileW = new FileWriter(file, true);
        ResultSet sales = DBConnection.selectAllSales();
        fileW.write("Codigo \t Fecha Venta \t Importe Total \t Libros Adquiridos");
        fileW.write("\n");
        while (sales.next()) {
            fileW.write(sales.getString(1) + "\t" + sales.getString(2) + "\t" + 
                        sales.getString(3) + "\t" + sales.getString(4) + "\t");
            fileW.write("\n");
        }
        fileW.close();
    }
    
}

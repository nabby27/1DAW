/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Main.Book;
import Main.Sale;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 *
 * @author Iván Córdoba Donet
 */public class DBConnection {
    
    public static Connection openConnection() throws Exception {
        Connection connection = null;
        String urlODBC = "jdbc:mysql://localhost/";
        String userDB = "root";
        String passDB = "";
        String dbName = "libreria";
        try {
            Class.forName("com.mysql.jdbc.Driver");
            urlODBC += dbName;
            connection = java.sql.DriverManager.getConnection(urlODBC, userDB, passDB);
            return connection;
        } catch (ClassNotFoundException | SQLException e) {
            throw  new Exception("Ha sido imposible establecer la conexion" + e.getMessage());
        }
    }
    
    public static void closeConnection(Connection connection) throws Exception {
        try {
            if (connection != null) {
                connection.close();
            }
        } catch (Exception e) {
            throw  new Exception("Ha sido imposible cerrar la conexion" + e.getMessage());
        }
    }
    
    public static void insertBook(Book book) throws Exception {
        Connection con = openConnection();
        try {
            PreparedStatement pstat = con.prepareStatement("INSERT INTO libros (codigo, autor, titulo, precio, stock) values (?, ?, ?, ?, ?)");
            pstat.setString(1, book.getCod());
            pstat.setString(2, book.getAuthor());
            pstat.setString(3, book.getTitle());
            pstat.setString(4, book.getPrice());
            pstat.setString(5, book.getStock());
            pstat.execute();
            System.out.println("Libro insertado");
        } catch (Exception e) {
            System.out.println("Algo ha fallado");
        }
        closeConnection(con);
    }
    
    public static void deleteBook(String cod) throws Exception {
        Connection con = openConnection();
        try {
            PreparedStatement pstat = con.prepareStatement("DELETE FROM libros WHERE codigo = ?");
            pstat.setString(1, cod);
            int row = pstat.executeUpdate();
            if (row > 0) {
                System.out.println("Libro eliminado");
            } else {
                System.out.println("El libro no existe");
            }
        } catch (Exception e) {
            System.out.println("Algo ha fallado");
        }
        closeConnection(con);
    }
    
    public static ResultSet selectBook(String cod) throws Exception {
        Connection con = openConnection();
        try {
            PreparedStatement pstat = con.prepareStatement("SELECT * FROM libros WHERE codigo = ?");
            pstat.setString(1, cod);
            return pstat.executeQuery();
        } catch (Exception e) {
            return null;
        }
    }
    
    public static ResultSet selectAllBooks() throws Exception {
        Connection con = openConnection();
        ResultSet result = null;
        try {
            Statement pstat = con.createStatement();
            return pstat.executeQuery("SELECT * FROM libros");
        } catch (Exception e) {
            return null;
        }
    }
    
    public static void changeStock(String cod, String stock) throws Exception {
        Connection con = openConnection();
        try {
            PreparedStatement pstat = con.prepareStatement("UPDATE libros SET stock = ? WHERE codigo = ?");
            pstat.setString(1, stock);
            pstat.setString(2, cod);
            pstat.execute();
            System.out.println("Stock cambiado");
        } catch (Exception e) {
            System.out.println("Algo ha fallado");
        }
        closeConnection(con);
    }
    
    public static int insertSale(Sale sale) throws Exception {
        Connection con = openConnection();
        try {
            PreparedStatement pstat = con.prepareStatement("INSERT INTO ventas (codigoventa, fechaventa, importetotal, librosadquiridos) values (?, ?, ?, ?)");
            pstat.setString(1, sale.getCodSale());
            pstat.setString(2, sale.getDateSale());
            pstat.setString(3, sale.getTotalPrice());
            pstat.setString(4, sale.getNumOfBooks());
            System.out.println("Insertando venta");
            return pstat.executeUpdate();
        } catch (Exception e) {
            System.out.println("Algo ha fallado");
            return 0;
        }
    }
    
    public static ResultSet selectAllSales() throws Exception {
        Connection con = openConnection();
        ResultSet result = null;
        try {
            Statement pstat = con.createStatement();
            return pstat.executeQuery("SELECT * FROM ventas");
        } catch (Exception e) {
            return null;
        }
    }
    
    public static Boolean existBook(String cod) throws Exception {
        Connection con = openConnection();
        try {
            PreparedStatement pstat = con.prepareStatement("SELECT * FROM libros WHERE codigo = ?");
            pstat.setString(1, cod);
            ResultSet res = pstat.executeQuery();
            return res.next();
        } catch (Exception e) {
            return null;
        }
    }
    
}

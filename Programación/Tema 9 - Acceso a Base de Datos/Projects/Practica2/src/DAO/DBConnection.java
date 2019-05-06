/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Main.Contact;
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
        String dbName = "bbddprueba";
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
    
    public static void insertContact(Contact contact) throws Exception {
        Connection con = openConnection();
        try {
            PreparedStatement pstat = con.prepareStatement("INSERT INTO contacto (nombre, correo, telefono, direccion) values (?, ?, ?, ?)");
            pstat.setString(1, contact.getNombre());
            pstat.setString(2, contact.getCorreo());
            pstat.setString(3, contact.getTelefono());
            pstat.setString(4, contact.getDireccion());
            pstat.execute();
            System.out.println("Contacto insertado");
        } catch (Exception e) {
            System.out.println("Algo ha fallado");
        }
        closeConnection(con);
    }
    
    public static void deleteContact(String name) throws Exception {
        Connection con = openConnection();
        try {
            PreparedStatement pstat = con.prepareStatement("DELETE FROM contacto WHERE nombre = ?");
            pstat.setString(1, name);
            pstat.execute();
            System.out.println("Contacto eliminado");
        } catch (Exception e) {
            System.out.println("Algo ha fallado");
        }
        closeConnection(con);
    }
    
    public static ResultSet selectContact(String name) throws Exception {
        Connection con = openConnection();
        try {
            PreparedStatement pstat = con.prepareStatement("SELECT * FROM contacto WHERE nombre = ?");
            pstat.setString(1, name);
            return pstat.executeQuery();
        } catch (Exception e) {
            return null;
        }
    }
    
    public static ResultSet selectAllContacts() throws Exception {
        Connection con = openConnection();
        ResultSet result = null;
        try {
            Statement pstat = con.createStatement();
            return pstat.executeQuery("SELECT * FROM contacto");
        } catch (Exception e) {
            return null;
        }
    }
    
}

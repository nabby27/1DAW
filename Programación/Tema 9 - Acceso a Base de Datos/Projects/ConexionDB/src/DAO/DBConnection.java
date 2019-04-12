/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import java.sql.Connection;
import java.sql.SQLException;

/**
 *
 * @author Iván Córdoba Donet
 */public class DBConnection {
    
    public static Connection openConnection() throws Exception {
        Connection connection = null;
        String urlOBDC = "";
        String userDB = "root";
        String passDB = "";
        try {
            Class.forName("com.mysql.jdbc.Driver");
            urlOBDC = ("jdbc:mysql://localhost/tienda");
            connection = java.sql.DriverManager.getConnection(urlOBDC, userDB, passDB);
            System.out.println("Conexion realizada");
            return connection;
        } catch (ClassNotFoundException | SQLException e) {
            throw  new Exception("Ha sido imposible establecer la conexion" + e.getMessage());
        }
    }
    
    public static void closeConnection(Connection connection) throws Exception {
        try {
            if (connection != null) {
                connection.close();
                System.out.println("Conexion cerrada");
            }
        } catch (Exception e) {
            throw  new Exception("Ha sido imposible cerrar la conexion" + e.getMessage());
        }
    }
    
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ClientesDB;

import DAO.DBConnection;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        Integer rowsUpdated = 0;
        ResultSet rs = null;
        try {
            Connection con = DBConnection.openConnection();
            
            rowsUpdated = update(con);
            System.out.println(rowsUpdated + " rows updated");
            
            rowsUpdated = staticUpdate(con);
            System.out.println(rowsUpdated + " rows updated");
            
            rs = select(con);
            while (rs.next()) {
                System.out.println(rs.getString("IdCategoria") + "\t" + rs.getString("NomCategoria") + "\t\t" + rs.getString("Descripcion"));
            }
            rs.close();
            
            insert(con);
            staticInsert(con);
            
            delete(con);
            staticDelete(con);
            
            DBConnection.closeConnection(con);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
    
    private static Integer update(Connection con) {
        Integer idCategory = 1;
        String newName = "Liquidos";
        try {
            System.out.println("UPDATE a la tabla categorias");
            String query = "UPDATE categorias SET NomCategoria = ? WHERE IdCategoria = ?";
            PreparedStatement pstmt = con.prepareStatement(query);
            pstmt.setString(1, newName);
            pstmt.setInt(2, idCategory);
            return pstmt.executeUpdate();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return null;
        }
    }
    
    private static Integer staticUpdate(Connection con) {
        try {
            System.out.println("UPDATE a la tabla categorias");
            String query = "UPDATE categorias SET NomCategoria = 'Bebidas' WHERE IdCategoria = 1";
            Statement stmt = con.createStatement();
            return stmt.executeUpdate(query);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return null;
        }
    }
    
    private static ResultSet select(Connection con) {
        Integer idCategory = 1;
        try {
            System.out.println("SELECT categorias");
            String query = "SELECT * FROM categorias WHERE IdCategoria = ?";
            PreparedStatement pstmt = con.prepareStatement(query);
            pstmt.setInt(1, idCategory);
            return pstmt.executeQuery();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return null;
        }
    }
    
    private static ResultSet staticSelect(Connection con) {
        try {
            System.out.println("SELECT categorias");
            String query = "SELECT * FROM categorias WHERE IdCategoria = 1";
            Statement stmt = con.createStatement();
            return stmt.executeQuery(query);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return null;
        }
    }
    
    private static Boolean insert(Connection con) {
        Integer idCateogry = 10;
        String nomCategory = "Otros";
        String description = "Categoria sin identificar";
        try {
            System.out.println("INSERT a la tabla categorias");
            String query = "INSERT INTO categorias (IdCategoria, NomCategoria, Descripcion) values(?, ?, ?)";
            PreparedStatement pstmt = con.prepareStatement(query);
            pstmt.setInt(1, idCateogry);
            pstmt.setString(2, nomCategory);
            pstmt.setString(3, description);
            return pstmt.execute();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return null;
        }
    }
    
    private static Boolean staticInsert(Connection con) {
        try {
            System.out.println("INSERT a la tabla categorias");
            String query = "INSERT INTO categorias (IdCategoria, NomCategoria, Descripcion) values(11, 'Ferreteria', 'productos de ferreteria')";
            Statement stmt = con.createStatement();
            return stmt.execute(query);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return null;
        }
    }
    
    private static Boolean delete(Connection con) {
        Integer idCategory = 10;
        try {
            System.out.println("DELETE a la tabla categorias");
            String query = "DELETE FROM categorias WHERE IdCategoria = ?";
            PreparedStatement pstmt = con.prepareStatement(query);
            pstmt.setInt(1, idCategory);
            return pstmt.execute();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return null;
        }
    }
    
    private static Boolean staticDelete(Connection con) {
        try {
            System.out.println("DELETE a la tabla categorias");
            String query = "DELETE FROM categorias WHERE IdCategoria = 11";
            Statement stmt = con.createStatement();
            return stmt.execute(query);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return null;
        }
    }
    
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ClientesDB;

import DAO.DBConnection;
import java.sql.Connection;
import java.sql.PreparedStatement;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        try {
            Connection con = DBConnection.openConnection();
            
            Integer rowsUpdated = update(con);
            
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
    
}

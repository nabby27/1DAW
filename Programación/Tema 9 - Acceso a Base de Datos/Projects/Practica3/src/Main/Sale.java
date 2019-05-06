/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Main;

/**
 *
 * @author Iván Córdoba Donet   
 */
public class Sale {

    private String codSale;
    private String dateSale;
    private String totalPrice;
    private String numOfBooks;

    public Sale(String codSale, String dateSale, String totalPrice, String numOfBooks) {
        this.codSale = codSale;
        this.dateSale = dateSale;
        this.totalPrice = totalPrice;
        this.numOfBooks = numOfBooks;
    }

    public String getCodSale() {
        return codSale;
    }

    public void setCodSale(String codSale) {
        this.codSale = codSale;
    }

    public String getDateSale() {
        return dateSale;
    }

    public void setDateSale(String dateSale) {
        this.dateSale = dateSale;
    }

    public String getTotalPrice() {
        return totalPrice;
    }

    public void setTotalPrice(String totalPrice) {
        this.totalPrice = totalPrice;
    }

    public String getNumOfBooks() {
        return numOfBooks;
    }

    public void setNumOfBooks(String numOfBooks) {
        this.numOfBooks = numOfBooks;
    }
    
}

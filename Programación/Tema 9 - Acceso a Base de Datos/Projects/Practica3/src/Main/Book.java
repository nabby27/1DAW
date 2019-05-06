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
public class Book {
    
    private String cod;
    private String author;
    private String title;
    private String price;
    private String stock;

    public Book() {
    }

    public Book(String cod, String author, String title, String price, String stock) {
        this.cod = cod;
        this.author = author;
        this.title = title;
        this.price = price;
        this.stock = stock;
    }

    public String getCod() {
        return cod;
    }

    public void setCod(String cod) {
        this.cod = cod;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getPrice() {
        return price;
    }

    public void setPrice(String price) {
        this.price = price;
    }

    public String getStock() {
        return stock;
    }

    public void setStock(String stock) {
        this.stock = stock;
    }
    
}

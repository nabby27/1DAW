/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Comprueba {
    
    public static void main(String[] args) {
        System.out.println();
    }
    
    public static boolean capicua(int num) {
        String numString = Integer.toString(num);
        String[] numStringList = numString.split("");
        boolean capicua = true;
        int i = 0;
        while (capicua && i < (numStringList.length / 2)) {
            if (!numStringList[numStringList.length - i - 1].equalsIgnoreCase(numStringList[i])) {
                capicua = false;
            }
            i++;
        }
        return capicua;
    }
    
}

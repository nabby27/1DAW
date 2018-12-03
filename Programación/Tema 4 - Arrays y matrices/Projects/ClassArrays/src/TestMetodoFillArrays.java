
import java.util.Arrays;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class TestMetodoFillArrays {

    public static void main(String[] Args) {
        int[] miArray = new int[10];
        Arrays.fill(miArray, 33);
        for (int tmp : miArray) {
            System.out.print(tmp + ",");
        }
    }
    
}

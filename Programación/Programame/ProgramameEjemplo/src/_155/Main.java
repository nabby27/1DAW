/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package _155;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {

    public static void main(String[] args) {
        int[] pointVector = new int[]{0, 0};
        Scanner sc = new Scanner(System.in);
        while (pointVector[0] >= 0 && pointVector[1] >= 0) {
            String pointString = sc.nextLine();
            pointVector[0] = (Integer.parseInt(pointString.split(" ")[0]));
            pointVector[1] = (Integer.parseInt(pointString.split(" ")[1]));
            if (pointVector[0] >= 0 && pointVector[1] >= 0) {
                System.out.println(pointVector[0] * 2 + pointVector[1] * 2);
            }
        }
    }

}

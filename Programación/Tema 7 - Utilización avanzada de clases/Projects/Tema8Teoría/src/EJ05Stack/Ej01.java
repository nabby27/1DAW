/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ05Stack;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.Stack;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ej01 {
    
    public static void main(String[] args) {
        Stack<Integer> stack = new Stack<Integer>();
        
        stack = saveItemsInStack(stack, 4);
        System.out.println("Average: " + getAverage(stack));
        System.out.println("Bigger than average: " + getBiggerThanAverage(stack));
        System.out.println("How many numbers smaller than average: " + getSmallerThanAverage(stack).size());
        System.out.println("Num of items to pop item: " + getNumItemsToPopItemInStack(stack, 2));
    }
    
    private static Stack<Integer> saveItemsInStack(Stack<Integer> stack, int numOfItems) {
        Scanner sc = new Scanner(System.in);
        for (int i = 0; i < numOfItems; i++) {
            System.out.println("Elemento " + (i+1) + ": " );
            stack.push(sc.nextInt());
        }
        return stack;
    }
    
    private static float getAverage(Stack<Integer> stack) {
        float sum = 0;
        for (Integer number : stack) {
            sum += number;
        }
        return sum/stack.size();
    }
    
    private static Stack<Integer> getBiggerThanAverage(Stack<Integer> stack) {
        Stack<Integer> biggerThanAverage = new Stack<Integer>();
        float average = getAverage(stack);
        
        for (Integer number : stack) {
            if (number > average)
                biggerThanAverage.push(number);
        }
        return biggerThanAverage;
    }
    
    private static Stack<Integer> getSmallerThanAverage(Stack<Integer> stack) {
        Stack<Integer> smallerThanAverage = new Stack<Integer>();
        float average = getAverage(stack);
        
        for (Integer number : stack) {
            if (number < average)
                smallerThanAverage.push(number);
        }
        return smallerThanAverage;
    }
    
    private static Integer getNumItemsToPopItemInStack(Stack<Integer> stack, Integer item) {
        return stack.search(item);
    }
    
}

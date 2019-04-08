/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ06HashSet;


/**
 *
 * @author Iván Córdoba Donet
 */
public class TreeSet {
    
    public static void main(String[] args) {
        java.util.TreeSet<String> ts1 = new java.util.TreeSet<String>();

        ts1.add("1");
        ts1.add("2");
        ts1.add("6");
        ts1.add("4");
        ts1.add("5");
        
        System.out.println("TreeSet 1");
        ver(ts1);
        
        // System.out.println(ts1.headSet("4"));
        // System.out.println(ts1.subSet("2", "5"));
        System.out.println(ts1.tailSet("5"));
    }
    
    private static void ver(java.util.TreeSet<String> ts) {
        for (String t : ts) {
            System.out.println(t);
        }
    }
    
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author AlumMati
 */
public class Catorce {
    
    public static void main(String[] args) {
        
        ej1();
        System.err.println("");
        System.err.println("");
        ej2();
        System.err.println("");
        System.err.println("");
        ej3();
        System.err.println("");
        System.err.println("");
        ej4();
        
        
    }
    
    public static void ej1() {
        System.err.println("TABLA 1");
        int a, b, c;
        System.err.println("------------------------------------");
        System.err.println("\t\tA \tB \tC");
        System.err.println("------------------------------------");
        a = 3;
        System.err.println("a=3; \t\t" + a);
        b = 4;
        System.err.println("b=4; \t\t" + a + "\t" + b);
        c = a + 2 * --b;
        System.err.println("c=a+2*--b; \t" + a + "\t" + b + "\t" + c);
        c += b;
        System.err.println("c+=b; \t\t" + a + "\t" + b + "\t" + c);
        b = c - a++;
        System.err.println("b=c-a++; \t" + a + "\t" + b + "\t" + c);
        a = b * c;
        System.err.println("a=b*c; \t\t" + a + "\t" + b + "\t" + c);
        System.err.println("------------------------------------");
    }
    
    public static void ej2() {
        System.err.println("TABLA 2");
        int c;
        float x;
        System.err.println("------------------------------------");
        System.err.println("\t\tC \tX");
        System.err.println("------------------------------------");
        c = 6;
        System.err.println("c=6; \t\t" + c);
        c /= 4;
        System.err.println("c/=4; \t\t" + c);
        x = ++c;
        System.err.println("x=++C; \t\t" + c + "\t" + x);
        System.err.println("------------------------------------");
    }
    
    public static void ej3() {
        System.err.println("TABLA 3");
        int c;
        float x;
        System.err.println("------------------------------------");
        System.err.println("\t\tC \tX");
        System.err.println("------------------------------------");
        c = 6;
        System.err.println("c=6; \t\t" + c);
        c /= 4;
        System.err.println("c/=4; \t\t" + c);
        x = c++;
        System.err.println("x=++C; \t\t" + c + "\t" + x);
        System.err.println("------------------------------------");
    }
    
    public static void ej4() {
        System.err.println("TABLA 4");
        int c;
        float x;
        System.err.println("------------------------------------");
        System.err.println("\t\tC \tX");
        System.err.println("------------------------------------");
        x = 6;
        System.err.println("c=6; \t\t\t" + x);
        x /= 4;
        System.err.println("c/=4; \t\t\t" + x);
        c = (int) x++;
        System.err.println("x=++C; \t\t" + c + "\t" + x);
        System.err.println("------------------------------------");
    }
}

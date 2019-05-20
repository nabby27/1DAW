/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Calculator;

import java.util.ArrayList;
import java.util.Arrays;
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Iván Córdoba Donet
 */
public class MainTest {
    
    public MainTest() {
    }
    
    @Before
    public void setUp() {
    }
    
    @Test
    public void testObtenerNumerosDetexto() {
        ArrayList<Integer> expResult = new ArrayList<Integer>(
            Arrays.asList(2, 3)
        );
        
        ArrayList<Integer> result = Main.obtenerNumeros("2 + 3");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testObtenerNumerosDetexto2() {
        ArrayList<Integer> expResult = new ArrayList<Integer>(
            Arrays.asList(2, 3, 4, 6, 7)
        );
        
        ArrayList<Integer> result = Main.obtenerNumeros("2 + 3 * 4 / 6 - 7");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testObtenerNumerosDetexto3() {
        ArrayList<Integer> expResult = new ArrayList<Integer>(
            Arrays.asList(12, 43)
        );
        
        ArrayList<Integer> result = Main.obtenerNumeros("12 + 43");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testObtenerOperaciones() {
        ArrayList<String> expResult = new ArrayList<String>(
            Arrays.asList("+")
        );
        
        ArrayList<String> result = Main.obtenerOperaciones("2 + 3");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testObtenerOperaciones2() {
        ArrayList<String> expResult = new ArrayList<String>(
            Arrays.asList("+", "-", "*", "/")
        );
        
        ArrayList<String> result = Main.obtenerOperaciones("2 + 3 - 5 * 3 / 7");
        
        checkAssert(expResult, result);
    }
     
    @Test
    public void testCalcularDesdeTexto() {
        int expResult = 5;
        
        int result = Main.calcular("2 + 3");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testCalcularDesdeTexto2() {
        int expResult = 9;
        
        int result = Main.calcular("12 - 3");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testCalcularDesdeTexto3() {
        int expResult = 24;
        
        int result = Main.calcular("12 * 2");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testCalcularDesdeTexto4() {
        int expResult = 6;
        
        int result = Main.calcular("12 / 2");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testCalcularDesdeTexto5() {
        int expResult = 3;
        
        int result = Main.calcular("12 / 2 - 3");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testCalcularDesdeTexto6() {
        int expResult = 11;
        
        int result = Main.calcular("5 * 4 / 2 + 2 - 1");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testCalcularDesdeTexto7() {
        int expResult = 8;
        
        int result = Main.calcular("5 + 4 / 2 * 2 - 1");
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testCalcularDesdeTexto8() {
        int expResult = 10;

        int result = Main.calcular("5 + 4 / 2 * 2 - 1 * 6 / 6 + 5 * 2 - 8 / 2 * 2");
        
        checkAssert(expResult, result);
    }
    
    private void checkAssert(int expResult, int result) {
        assertEquals(expResult, result);
        if (expResult != result) {
            fail("El resultado no es el esperado");
        }
    }
    
    private void checkAssert(ArrayList expResult, ArrayList result) {
        assertEquals(expResult, result);
        if (!expResult.equals(result)) {
            fail("El resultado no es el esperado");
        }
    }
    
}

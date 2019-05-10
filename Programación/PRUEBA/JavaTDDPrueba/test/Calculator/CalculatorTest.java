/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Calculator;

import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Iván Córdoba Donet
 */
public class CalculatorTest {
    
    private Calculator calculator = null;
        
    public CalculatorTest() {
    } 
        
    @Before
    public void setUp() {
        this.calculator = new Calculator();
    }

    @Test
    public void testSuma() {
        int expResult = 2;
        
        int result = this.calculator.sumar(1, 1);
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testSuma2() {
        int expResult = 13;
        
        int result = this.calculator.sumar(10, 3);
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testResta() {
        int expResult = 3;
        
        int result = this.calculator.restar(4, 1);
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testResta2() {
        int expResult = 4;
        
        int result = this.calculator.restar(7, 3);
        
        checkAssert(expResult, result);
    }   
    
    @Test
    public void testMultiplicacion() {
        int expResult = 4;
        
        int result = this.calculator.multiplicar(4, 1);
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testMultiplicacion2() {
        int expResult = 8;
        
        int result = this.calculator.multiplicar(4, 2);
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testDivision() {
        int expResult = 2;
        
        int result = this.calculator.dividir(4, 2);
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testDivision2() {
        int expResult = 1;
        
        int result = this.calculator.dividir(2, 2);
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testDivision3() {
        int expResult = 0;
        
        int result = this.calculator.dividir(2, 0);
        
        checkAssert(expResult, result);
    }
    
    @Test
    public void testDivision4() {
        int expResult = 0;
        
        int result = this.calculator.dividir(0, 3);
        
        checkAssert(expResult, result);
    }
    
    private void checkAssert(int expResult, int result) {
        assertEquals(expResult, result);
        if (result != expResult) {
            fail("El resultado no es el esperado");
        }
    }
    
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ascensor;

import java.util.ArrayList;

/**
 *
 * @author teProgramo
 */
public class Main {
    
    private static ArrayList<ArrayList<Integer>> recorridos = new ArrayList<ArrayList<Integer>>();
    
    public static void main(String[] args) {
        setDatos();
        calcularTrayectos();
    }
    
    private static void setDatos() {
        ArrayList<Integer> dia = new ArrayList<Integer>(){{add(0);add(1);add(5);add(2);add(0);add(3);add(9);}};
        recorridos.add(dia);
        dia = new ArrayList<Integer>(){{add(5);add(5);add(4);}};
        recorridos.add(dia);
        dia = new ArrayList<Integer>(){{add(1);add(2);add(3);add(4);add(5);}};
        recorridos.add(dia);
    }
    
    private static void calcularTrayectos() {
        int espacioRecorrido = 0;
        for (ArrayList<Integer> dia : recorridos) {
            espacioRecorrido = 0;
            for (int i = 0; i < dia.size()-1; i++) {
                espacioRecorrido += Math.abs(dia.get(i)-dia.get(i+1));
            }
            System.out.println(espacioRecorrido);
        }
    }
    
}

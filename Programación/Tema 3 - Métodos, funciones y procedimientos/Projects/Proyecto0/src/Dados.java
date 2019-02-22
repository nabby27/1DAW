/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Random;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Dados {
    
    static int maxPt = 500;
    static String[] players;
    static Integer[] playersPts;
    static int[] playersTotalPts;
    
    public static void main(String[] args) throws InterruptedException, IOException {
       menu(); 
    }
    
    private static void menu() {
        clear();
        int option = 0;
        Scanner keyboard = new Scanner(System.in);

        System.out.println("Elige una opción");
        System.out.println("1 - Configurar");
        System.out.println("2 - Jugar");
        System.out.println("3 - Salir");
        option = keyboard.nextInt();
        switch (option) {
            case 1: settings();
                    break;
            case 2: play();
                    break;
            case 3: exit();
                    break;
        }
    }
    
    private static void settings() {
        clear();
        int option = 0;
        Scanner keyboard = new Scanner(System.in);

        System.out.println("Elige que configuracion cambiar");
        System.out.println("0 - Ir a la pantalla principal");
        System.out.println("1 - Cambiar la puntuación máxima");
        option = keyboard.nextInt();
        switch (option) {
            case 0: menu();
                    break;
            case 1: changeMaxPts();
                    break;
        }
    }
    
    private static void play() {
        identifyPlayers();
        shoot();
    }
    
    private static void changeMaxPts() {
        try {
            clear();
            int newMaxPt = 0;
            Scanner keyboard = new Scanner(System.in);

            System.out.println("Actualmente la puntuación máxima es: " + maxPt);
            System.out.println("¿Cuanto quieres que sea la puntuación máxima?");
            newMaxPt = keyboard.nextInt();
            maxPt = newMaxPt;
            System.out.println("Puntuación máxima cambiada a " + maxPt);
            Thread.sleep(3000);
            settings();
        } catch (InterruptedException ex) {
            Logger.getLogger(Dados.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    private static void identifyPlayers() {
        clear();
        int numPlayers = 0;
        Scanner keyboard = new Scanner(System.in);
        
        System.out.println("¿Cuantos jugadores van a jugar?");
        numPlayers = keyboard.nextInt();
        players = new String[numPlayers];
        playersPts = new Integer[numPlayers];
        playersTotalPts = new int[numPlayers];
        
        for (int i = 1; i <= numPlayers; i++) {
            System.out.println("¿Como se llama el jugador " + i + "?");
            players[i-1] = keyboard.next();
        }
    }
    
    private static void shoot() {
        clear();
        int dice1 = 0;
        int dice2 = 0;
        Scanner keyboard = new Scanner(System.in);
        for (int i = 1; i <= players.length; i++) {
            clear();
            System.out.println("Tira los dados: " + players[i-1]);
            if (keyboard.nextLine().length() < 1){
                dice1 = (int) (Math.random() * 6) + 1;
                dice2 = (int) (Math.random() * 6) + 1;
                System.out.println("Dado 1: " + dice1);
                System.out.println("Dado 2: " + dice2);
                calculateRoundPointOf(i-1, dice1, dice2);
            }
        }
        calculatePoints();
        checkWinner();
    }
    
    private static void calculateRoundPointOf(int player, int dice1, int dice2) {
        switch (dice2){
            case 1: playersPts[player] = factorial(dice1);
                    System.out.println("Has obtenido esta ronda " + factorial(dice1) + " pts");
                    break;
            case 2: playersPts[player] = sum(dice1);
                    System.out.println("Has obtenido esta ronda " + sum(dice1) + " pts");
                    break;
            case 3: playersPts[player] = (dice1*dice1);
                    System.out.println("Has obtenido esta ronda " + (dice1*dice1) + " pts");
                    break;
            case 4: playersPts[player] = 1;
                    System.out.println("Has obtenido esta ronda 1 pt");
                    break;
            case 5: playersPts[player] = dice1;
                    System.out.println("Has obtenido esta ronda " + dice1 + " pt");
                    break;
            case 6: playersPts[player] = 0;
                    System.out.println("Has obtenido esta ronda 0 pts");
                    break;
        }
        try {
            Thread.sleep(3000);
        } catch (InterruptedException ex) {
            Logger.getLogger(Dados.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    private static int factorial(int num) {
        int result = 1;
        for (int i = 1; i <= num; i++) {
            result *= i;
        }
        return result;
    }
    
    private static int sum(int num) {
        int result = 0;
        for (int i = 1; i <= num; i++) {
            result += i;
        }
        return result;
    }
    
    private static void checkWinner() {
        boolean finish = false;
        for (int i = 0; i < players.length; i++) {
            if (playersTotalPts[i] >= maxPt){
                clear();
                System.out.println(players[i] + " a llegado ya a " + maxPt);
                finish = true;   
            }
        }
        try {
            if (finish) {
                Thread.sleep(5000);
                menu();
            } else {
                shoot();
            }
        } catch (InterruptedException ex) {
            Logger.getLogger(Dados.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    private static void calculatePoints() {
        List<Integer> playerWinnerOfRound = new ArrayList<Integer>();
        List<Integer> playerLooserOfRound = new ArrayList<Integer>();
        int sumWinnerPoints = 0;
        int sumLooserPoint = 0;

        /* Extraigo los jugadores que han ganado y perdido esta ronda*/
        for (int i = 0; i < players.length; i++) {
            playerLooserOfRound.add(i);
            playerWinnerOfRound.add(i);
        }
        
        for (int j = 1; j < playerLooserOfRound.size(); j++) {
            if (playersPts[playerLooserOfRound.get(j-1).intValue()] > playersPts[playerLooserOfRound.get(j).intValue()]) {
                playerLooserOfRound.remove(j-1);
                j--;
            } else if (playersPts[playerLooserOfRound.get(j-1).intValue()] < playersPts[playerLooserOfRound.get(j).intValue()]) {
                playerLooserOfRound.remove(j);
                j--;
            }
        }
        
        for (int j = 1; j < playerWinnerOfRound.size(); j++) {
            if (playersPts[playerWinnerOfRound.get(j-1).intValue()] < playersPts[playerWinnerOfRound.get(j).intValue()]) {
                playerWinnerOfRound.remove(j-1);
                j--;
            } else if (playersPts[playerWinnerOfRound.get(j-1).intValue()] > playersPts[playerWinnerOfRound.get(j).intValue()]) {
                playerWinnerOfRound.remove(j);
                j--;
            }
        }
        
        /*sumo los puntos de los perdedores (si ha habido empate)*/
        for (int i = 0; i < playerLooserOfRound.size(); i++){
            sumLooserPoint += playersPts[playerLooserOfRound.get(i).intValue()];
            sumWinnerPoints += playersPts[playerLooserOfRound.get(i).intValue()];
        }
        
        
        /*sumo los puntos de los ganadores (si ha habido empate)*/
        for (int i = 0; i < playerWinnerOfRound.size(); i++) {
            sumWinnerPoints += playersPts[playerWinnerOfRound.get(i).intValue()];
        }
        
        
        for (int i = 0; i < players.length; i++) {
            if (playerLooserOfRound.contains(i)) {
                playersTotalPts[i] -= sumLooserPoint;
            } else if (playerWinnerOfRound.contains(i)) {
                playersTotalPts[i] += sumWinnerPoints;
            } else {
                playersTotalPts[i] += playersPts[i];
            }
        }
                
        clear();
        
        /*saco por pantalla la puntuacion de esta ronda*/
        for (int i = 0; i < players.length; i++) {
            System.out.println("El jugador " + players[i] + " ha obtenido esta ronda: " + playersPts[i]);
        }
        
        try {
            Thread.sleep(3000);
        } catch (InterruptedException ex) {
            Logger.getLogger(Dados.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        clear();
        
        /*saco por pantalla la puntuacion total hasta el momento*/
        for (int i = 0; i < players.length; i++) {
            System.out.println("El jugador " + players[i] + " tiene: " + playersTotalPts[i]);
        }
        
        try {
            Thread.sleep(3000);
        } catch (InterruptedException ex) {
            Logger.getLogger(Dados.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    private static void exit() {
        clear();
        System.out.println("Adiós");
        System.exit(0);
    }
    
    private static void clear() {
        for (int y = 0; y < 50; y++)
            System.out.println("");
    }
    
}

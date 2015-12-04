package com.company;

import com.company.elements.Element;
import com.company.elements.Player;
import com.company.maps.MapReader;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Game {

    private Player playerOne;
    private Player playerTwo;

    private Player currentPlayer;

    private List<List<Element>> map;

    private boolean running;

    private String output;

    private boolean turnChanged;

    public Game() {
        this.playerOne = new Player(0, "Player One", this);
        this.playerTwo = new Player(0, "Player Two", this);
        this.currentPlayer = this.playerOne;
        this.map = new ArrayList<List<Element>>();
        this.setRunning(true);
        this.setTurnChanged(true);
    }

    public Player getPlayerOne() {
        return playerOne;
    }

    public void setPlayerOne(Player playerOne) {
        this.playerOne = playerOne;
    }

    public Player getPlayerTwo() {
        return playerTwo;
    }

    public void setPlayerTwo(Player playerTwo) {
        this.playerTwo = playerTwo;
    }

    public Player getCurrentPlayer() {
        return currentPlayer;
    }

    public List<List<Element>> getMap() {
        return map;
    }

    public void switchTurn() {
        if (this.currentPlayer == this.getPlayerOne()) {
            this.currentPlayer = this.getPlayerTwo();
        } else {
            this.currentPlayer = this.getPlayerOne();
        }

    }

    public boolean isRunning() {
        return running;
    }

    public void setRunning(boolean running) {
        this.running = running;
    }

    public void start() {
        Scanner sc = new Scanner(System.in);

        while(this.isRunning()) {
            if (this.isTurnChanged()) {
                System.out.println(this.currentPlayer.getType() + " is on turn");
                this.setTurnChanged(false);
            }
            String cmd = sc.nextLine();

            switch (cmd) {
                case "map":
                    for (int i = 0; i < this.map.size(); i++) {
                        for (int j = 0; j < this.map.get(i).size(); j++) {
                            System.out.printf("%s : %s -> ", i, j);
                            System.out.println(this.map.get(i).get(j).getType());
                        }
                    }
                    break;
                case "move up":
                    try {
                        this.currentPlayer.moveUp();
                        this.printOutput();
                    } catch (Exception e) {
                        System.out.println(e.getMessage());
                    }
                    break;
                case "move right":
                    try {
                        this.currentPlayer.moveRight();
                        this.printOutput();
                    } catch (Exception e) {
                        System.out.println(e.getMessage());
                    }
                    break;
                case "move left":
                    try {
                        this.currentPlayer.moveLeft();
                        this.printOutput();
                    } catch (Exception e) {
                        System.out.println(e.getMessage());
                    }
                    break;
                case "move down":
                    try {
                        this.currentPlayer.moveDown();
                        this.printOutput();
                    } catch (Exception e) {
                        System.out.println(e.getMessage());
                    }
                    break;
                default:
                    break;
            }


        }
    }

    public boolean isTurnChanged() {
        return turnChanged;
    }

    public void setTurnChanged(boolean turnChanged) {
        this.turnChanged = turnChanged;
    }

    public void setOutput(String output) {
        this.output += "\n" + output;
    }

    private void printOutput() {
        System.out.println(this.output);
        this.output = "";
    }

    public static void main(String[] args) throws Exception {

        Game game = new Game();

        MapReader mr = new MapReader(game);
        mr.read();

        game.start();

    }
}

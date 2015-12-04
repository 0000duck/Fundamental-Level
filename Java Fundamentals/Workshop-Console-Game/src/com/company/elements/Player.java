package com.company.elements;

import com.company.Game;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by RoYaL on 11/6/2015.
 */
public class Player extends Element {

    private static final int HEALTH = 8000;

    private int gold;
    private List<Village> villages;
    private String type;
    private int damage;
    private int health;


    public Player(int gold, String type, Game game) {
        super(game);
        this.gold = gold;
        this.villages = new ArrayList<Village>();
        this.type = type;
        this.health = HEALTH;
    }

    public void addVilage(Village v) {
        this.villages.add(v);
    }


    @Override
    public String getType() {
        return this.type;
    }

    @Override
    public boolean moveTo(Player from) throws Exception {
        int round = 0;

        while (round < 3 && from.isAlive() && this.isAlive()) {
            from.health -= this.damage;
            this.health -= from.damage;
            round++;
        }

        if (!from.isAlive() && !this.isAlive()) {
            this.game.setOutput("Game ended draw");
            this.game.setRunning(false);
        } else if (!from.isAlive()) {
            this.game.setOutput(this.getType() + " is a winner");
            this.game.setRunning(false);
        } else if (!this.isAlive()) {
            this.game.setOutput(from.getType() + " is a winner");
            this.game.setRunning(false);
        }

        this.game.setTurnChanged(true);

        return false;
    }


    public void moveUp() throws Exception {
        if (this.row == 0) {
            throw new Exception("Cannot move up");
        }

        Element e = this.game.getMap().get(this.row - 1).get(this.col);

        if (e.moveTo(this)) {
            this.move(this.row-1, this.col);
            this.row--;
            this.game.setOutput("Successfully moved up");
        }
    }

    public void moveRight() throws Exception {
        if (this.col >= this.game.getMap().get(this.row).size() - 1) {
            throw new Exception("Cannot move right");
        }

        Element e = this.game.getMap().get(this.row).get(this.col + 1);

        if (e.moveTo(this)) {
            this.move(this.row, this.col + 1);
            this.col++;
            this.game.setOutput("Successfully moved right");
        }
    }

    public void moveDown() throws Exception {
        if (this.row >= this.game.getMap().size() - 1) {
            throw new Exception("Cannot move down");
        }

        Element e = this.game.getMap().get(this.row + 1).get(this.col);

        if (e.moveTo(this)) {
            this.move(this.row + 1, this.col);
            this.row++;
            this.game.setOutput("Successfully moved down");
        }
    }

    public void moveLeft() throws Exception {
        if (this.col == 0) {
            throw new Exception("Cannot move left");
        }

        Element e = this.game.getMap().get(this.row).get(this.col- 1);

        if (e.moveTo(this)) {
            this.move(this.row, this.col - 1);
            this.col--;
            this.game.setOutput("Successfully moved left");
        }

    }

    private void move(int newRow, int newCol) {
        this.game.getMap().get(newRow).set(newCol, this);
        this.game.getMap().get(this.row).set(this.col, new EmptyElement(this.game));
        this.game.switchTurn();
        this.game.setTurnChanged(true);
    }

    public void addGold(Gold g) {
        this.gold += g.getCount();
    }

    public void addDamage(Gold g) {
        this.damage += g.getCount() / 10;
    }

    public void tryAddHealth(Gold g) {
        final int chance = 20;
        int chanceDropped = (int)(100 * Math.random());

        if (chanceDropped <= chance) {
            this.health += g.getCount() / 5;
        }
    }

    public boolean isAlive() {
        return this.health > 0;
    }



}

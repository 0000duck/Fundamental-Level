package com.company.elements;

import com.company.Game;

/**
 * Created by RoYaL on 11/6/2015.
 */
public class Gold extends Element {

    private int count;

    public Gold(Game game, int count) {
        super(game);
        this.count = count;
    }

    public int getCount() {
        return this.count;
    }

    @Override
    public String getType() {
        return "Gold";
    }

    @Override
    public boolean moveTo(Player from) throws Exception {
        from.addGold(this);
        from.addDamage(this);
        from.tryAddHealth(this);
        this.game.setOutput("Successfully collected " + this.getCount() + " Gold");
        return true;
    }


}

package com.company.elements;

import com.company.Game;

/**
 * Created by RoYaL on 11/6/2015.
 */
public class Obstacle extends Element {

    public Obstacle(Game game) {
        super(game);
    }

    @Override
    public String getType() {
        return "Obstacle";
    }

    @Override
    public boolean moveTo(Player player) throws Exception {
        throw new Exception("Cannot move to an obstacle");
    }


}

package com.company.elements;

import com.company.Game;

/**
 * Created by RoYaL on 11/6/2015.
 */
public class EmptyElement extends Element {


    public EmptyElement(Game game) {
        super(game);
    }

    @Override
    public String getType() {
        return "Empty Element";
    }

    @Override
    public boolean moveTo(Player from) throws Exception {
        return true;
    }


}

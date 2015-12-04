package states;

import game.entities.Player;
import gfx.Assets;

import java.awt.*;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class GameState extends State {
    private static int GRAVITY = 2;
    public static Player player;

    public GameState() {
        init();
        player = new Player("Pesho", 95, 130, 100, 400);
    }

    private void init() {
        Assets.init();
    }

    @Override
    public void tick() {
        player.tick();
    }

    @Override
    public void render(Graphics g) {
        player.render(g);
    }
}

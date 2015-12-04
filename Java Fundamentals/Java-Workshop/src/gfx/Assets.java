package gfx;

import java.awt.image.BufferedImage;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class Assets {
    public static BufferedImage background;
    public static BufferedImage player;

    public static void init() {
        background = ImageLoader.LoadImage("/textures/bckg.jpg");
        player = ImageLoader.LoadImage("/textures/player.png");
    }
}

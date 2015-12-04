package game.entities;

import gfx.Assets;
import gfx.SpriteSheet;

import java.awt.*;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class Player {
    private static int CHUCK_NORRIS = Integer.MAX_VALUE;

    private String name;
    private int width, height, x, y, velocityX, velocityY, health;
    public static boolean isMovingLeft, isMovingRight;

    private SpriteSheet playerImage;
    private Rectangle boundixBox;

    private int row;

    public Player(String name, int width, int height, int x, int y) {
        this.name = name;
        this.width = width;
        this.height = height;
        this.x = x;
        this.y = y;
        this.velocityX = this.velocityY = 4;
        this.health = CHUCK_NORRIS;

        this.boundixBox = new Rectangle(x, y, width, height);
        this.playerImage = new SpriteSheet(Assets.player, width, height);
        this.row = 0;
    }

    public void tick() {
        if (isMovingRight) {
            row++;
            row %= 7;
        } else if (isMovingLeft) {
            row--;
            if (row < 0) row = 6;
        }

        this.boundixBox.setBounds(this.x, this.y, width, height);

        if (isMovingLeft) {
            this.x -= this.velocityX;
        } else if (isMovingRight) {
            this.x += this.velocityX;
        }
    }

    public void render(Graphics g) {
        if (isMovingLeft || isMovingRight) {
            g.drawImage(this.playerImage.crop(row, 0), this.x, this.y, null);
        } else {
            g.drawImage(this.playerImage.crop(0, 0), this.x, this.y, null);
        }
    }

    public boolean intersects(Rectangle enemy) {
        if (this.boundixBox.contains(enemy.x, enemy.y) || enemy.contains(this.boundixBox.x, this.boundixBox.y)) {
            return true;
        }
        return false;
    }
}

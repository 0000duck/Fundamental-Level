package states;

import java.awt.*;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public abstract class State {
    public abstract void tick();

    public abstract void render(Graphics g);
}

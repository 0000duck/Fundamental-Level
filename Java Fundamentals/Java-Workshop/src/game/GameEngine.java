package game;

import display.Display;
import states.GameState;
import states.MenuState;
import states.StateManager;

import java.awt.*;
import java.awt.image.BufferStrategy;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class GameEngine implements Runnable {
    private String title;

    private Display display;
    private BufferStrategy bs;
    private Graphics g;

    private Thread thread;
    private boolean isRunning;

    private GameState gameState;
    private MenuState menuState;

    private InputHandler inputHandler;

    /*Testing*/

    public GameEngine(String name) {
        this.title = name;
    }

    private void init() {
        this.display = new Display(this.title);

        gameState = new GameState();
        menuState = new MenuState();

        this.inputHandler = new InputHandler(this.display);
        StateManager.setCurrentState(new GameState());
    }

    private void tick() {
        if (StateManager.getCurrentState() != null) {
            StateManager.getCurrentState().tick();
        }
    }

    private void render() {
        this.bs = this.display.getCanvas().getBufferStrategy();

        if (this.bs == null) {
            this.display.getCanvas().createBufferStrategy(2);
            return;
        }

        this.g = this.bs.getDrawGraphics();

        g.clearRect(0, 0, Display.WIDTH, Display.HEIGHT);
        //Start drawing

        if (StateManager.getCurrentState() != null) {
            StateManager.getCurrentState().render(g);
        }

        //End drawing
        this.g.dispose();
        this.bs.show();
    }

    @Override
    public void run() {
        this.init();

        int fps = 30;
        double timePerTick = 1_000_000_000.0 / fps;

        double delta = 0;

        long now;
        long lastTime = System.nanoTime();

        while (isRunning) {
            now = System.nanoTime();

            delta += (now - lastTime) / timePerTick;
            lastTime = now;

            if (delta >= 1) {
                this.tick();
                this.render();
                delta--;
            }
        }

        this.stop();
    }

    public synchronized void start() {
        if (!isRunning) {
            this.thread = new Thread(this);

            this.isRunning = true;
            this.thread.start();
        }
    }

    public synchronized void stop() {
        if (!isRunning) {
            try {
                this.isRunning = false;
                this.thread.join();
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}

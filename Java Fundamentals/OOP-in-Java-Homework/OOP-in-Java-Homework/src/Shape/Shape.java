package Shape;

import Shape.interfaces.AreaMeasurable;

/**
 * Created by ivailojordanov on 11/1/15.
 */
public class Shape implements AreaMeasurable {
    private double x = 0;
    private double y = 0;

    public Shape(double x, double y) {
        this.setX(x);
        this.setY(y);
    }

    public double getX() {
        return x;
    }

    public void setX(double x) {
        this.x = x;
    }

    public double getY() {
        return y;
    }

    public void setY(double y) {
        this.y = y;
    }

    @Override
    public String toString() {
        String toString = String.format("%14s (%6.2f, %6.2f",
                this.getClass()
                        .getSimpleName(),
                this.getX(),
                this.getY());
        return toString;
    }

    @Override
    public double getArea() {
        return 0;
    }
}

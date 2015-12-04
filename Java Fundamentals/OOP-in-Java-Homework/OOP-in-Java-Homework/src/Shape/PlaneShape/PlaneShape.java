package Shape.PlaneShape;

import Shape.Shape;
import Shape.interfaces.PerimeterMeasurable;

/**
 * Created by ivailojordanov on 11/1/15.
 */
public abstract class PlaneShape extends Shape implements PerimeterMeasurable {

    public PlaneShape(double x, double y) {
        super(x, y);
    }

    @Override
    public abstract double getPerimeter();

    @Override
    public abstract double getArea();

    @Override
    public String toString() {
        String addededMethodInfo = String.format("%s), Area: (%6.2f), Perimeter: (%6.2f)",
                super.toString(),
                this.getArea(),
                this.getPerimeter());
        return addededMethodInfo;
    }
}

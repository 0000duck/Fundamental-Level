package Shape.SpaceShape;

import Shape.Shape;
import Shape.interfaces.VolumeMeasurable;

/**
 * Created by ivailojordanov on 11/1/15.
 */
public abstract class SpaceShape extends Shape implements VolumeMeasurable {
    private double z = 0;

    public SpaceShape(double x, double y, double z) {
        super(x, y);
        this.setZ(z);
    }

    public double getZ() {
        return z;
    }

    public void setZ(double z) {
        this.z = z;
    }

    @Override
    public abstract double getArea();

    @Override
    public abstract double getVolume();

    @Override
    public String toString() {
        String addededMethodInfo = String
                .format("%s, %6.2f), Area: (%6.2f), Volume: (%6.2f)",
                        super.toString(),
                        this.getZ(),
                        this.getArea(),
                        this.getVolume());
        return addededMethodInfo;
    }
}

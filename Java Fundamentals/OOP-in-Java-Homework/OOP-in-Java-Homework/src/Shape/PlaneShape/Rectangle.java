package Shape.PlaneShape;

/**
 * Created by ivailojordanov on 11/1/15.
 */
public class Rectangle extends PlaneShape {
    private double width;
    private double height;

    public Rectangle(double x, double y, double width, double height) {
        super(x, y);
        this.setWidth(width);
        this.setHeight(height);
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    @Override
    public double getPerimeter() {
        return 2 * (this.getWidth() + this.getHeight());
    }

    @Override
    public double getArea() {
        return this.getWidth() * this.getHeight();
    }
}

public abstract class Shape {
    float side1, side2;

    Shape(float side1, float side2) {
        this.side1 = side1;
        this.side2 = side2;
    }

    abstract float area();
}

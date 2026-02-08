public class Triangle extends Shape {

    Triangle(float side1, float side2) {
        super(side1, side2);
    }

    @Override
    float area() {
        return side1 * side2 / 2;
    }
}

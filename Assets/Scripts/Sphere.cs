using UnityEngine;

public class Sphere : Shape
{
    private void Start()
    {
        Initialize("Cube", Color.green);
    }

    // POLYMORPHISM: Different behavior
    public override void DisplayText()
    {
        Debug.Log($"I am a {ShapeName}! My color is {ShapeColor}.");
    }
}

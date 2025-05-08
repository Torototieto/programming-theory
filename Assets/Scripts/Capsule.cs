using UnityEngine;

public class Capsule : Shape
{
    private void Start()
    {
        Initialize("Cube", Color.blue);
    }

    // POLYMORPHISM: Different behavior
    public override void DisplayText()
    {
        Debug.Log($"I am a {ShapeName}! My color is {ShapeColor}"); 
    }
}

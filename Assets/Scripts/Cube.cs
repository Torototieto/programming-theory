using UnityEngine;
public class Cube : Shape
{
    private void Start()
    {
        Initialize("Cube", Color.red);
    }

    // POLYMORPHISM: Overriding base method
    public override void DisplayText()
    {
        Debug.Log($"I am a {ShapeName}! My color is {ShapeColor}.");
    }
}
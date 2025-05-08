using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    private string shapeName;
    private Color color;

    public string ShapeName
    {
        get => shapeName;
        set => shapeName = value;
    }

    public Color ShapeColor
    {
        get => color;
        set => color = value;
    }

    // POLYMORPHISM: Virtual method to be overridden
    public virtual void DisplayText()
    {
        Debug.Log("I am a shape.");
    }

    // ABSTRACTION: Common click behavior
    private void OnMouseDown()
    {
        DisplayText();
    }

    protected void Initialize(string name, Color color)
    {
        ShapeName = name;
        ShapeColor = color;
        GetComponent<Renderer>().material.color = color;
    }
}
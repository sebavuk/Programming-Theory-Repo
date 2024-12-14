using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField]
    private string shapeName;
   
    [SerializeField]
    private Color shapeColor;
    
    public string ShapeName { get => shapeName; set => shapeName = value; }
    public Color ShapeColor { get => shapeColor; set => shapeColor = value; }


    public virtual void ShowMessage()
    {

    }
}

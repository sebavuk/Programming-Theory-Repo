using TMPro;
using UnityEngine;

public class Cylinder :Shape
{
  
    private void Start()
    {
        GetComponent<Renderer>().material.color = ShapeColor;
    }

    public override void ShowMessage()
    {
        GameObject.Find("InfoText").GetComponent<TextMeshProUGUI>().text = $"Hi {GameManager.Instance.PlayerName}. I am a {ShapeName}";
    }

    private void OnMouseDown()
    {
        ShowMessage();
    }
}

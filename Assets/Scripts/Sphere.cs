using TMPro;
using UnityEngine;

public class Sphere : Shape
{

    private void Start()
    {
        GetComponent<Renderer>().material.color = ShapeColor;
    }

    public override void ShowMessage()
    {

        GameObject.Find("InfoText").GetComponent<TextMeshProUGUI>().text = $"Hallo {GameManager.Instance.PlayerName}. I am a {ShapeName}";
    }

    private void OnMouseDown()
    {
        ShowMessage();
    }
}

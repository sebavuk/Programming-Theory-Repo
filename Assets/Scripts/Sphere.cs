using TMPro;
using UnityEngine;

public class Sphere : Shape // INHERITANCE
{

    private void Start()
    {
        GetComponent<Renderer>().material.color = ShapeColor;
    }

    public override void ShowMessage()// POLYMORPHISM
    {

        GameObject.Find("InfoText").GetComponent<TextMeshProUGUI>().text = $"Hallo {GameManager.Instance.PlayerName}. I am a {ShapeName}";
    }

    private void OnMouseDown()
    {
        ShowMessage();
    }
}

using System;
using TMPro;
using UnityEngine;

public class Cube : Shape
{
   
    private void Start()
    {
        GetComponent<Renderer>().material.color = ShapeColor;
    }

    public override void ShowMessage()
    {
        GameObject.Find("InfoText").GetComponent<TextMeshProUGUI>().text = $"Aloha Mr. {GameManager.Instance.PlayerName}. I am a {ShapeName}";
        //Debug.Log($"Aloha Mr. {GameManager.Instance.PlayerName}. I am a {ShapeName}");
    }

    private void OnMouseDown()
    {
        ShowMessage();
    }
}

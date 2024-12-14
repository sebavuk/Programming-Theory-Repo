using System;
using UnityEngine;

public class Cube : Shape
{
    [SerializeField]
    private string message;


    private void Start()
    {
        GetComponent<Renderer>().material.color = ShapeColor;
    }

    public override void ShowMessage()
    {
        Debug.Log($"{message} I am a {ShapeName}");
    }
}

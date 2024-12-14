using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private string playerName;
    public string PlayerName
    {
        get
        {
            return playerName;
        }
        set
        {
            value.ToLower().FirstCharacterToUpper();
            playerName = value;
        }
    }



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }


    private void OnMouseDown()
    {
        Debug.Log("Mouse clicked!");
    }


}

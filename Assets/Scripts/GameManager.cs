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

            playerName = value.ToLower().FirstCharacterToUpper();
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

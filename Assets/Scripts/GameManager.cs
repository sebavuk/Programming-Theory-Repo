using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private string playerName;
    public string PlayerName // ENCAPSULATION
    {
        get
        {
            return playerName;
        }
        set
        {

            playerName = CorrectName(value);// ABSTRACTION
        }
    }

    private string CorrectName(string name)
    {
        return name.ToLower().FirstCharacterToUpper();
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


}

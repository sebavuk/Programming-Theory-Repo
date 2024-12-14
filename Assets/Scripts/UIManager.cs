using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textEntry;

    public void SetPlayerName()
    {
        GameManager.Instance.PlayerName = textEntry.text;
        SceneManager.LoadScene(1);
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField inputField;

    public void StartGame()
    {
        MainManager.Instance.playerName = inputField.text;
        SceneManager.LoadScene(1);
    }
}

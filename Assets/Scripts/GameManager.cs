using UnityEngine;
using UnityEngine.UI;  // Required for InputField
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}

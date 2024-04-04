using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadGameScene()
    {
        SceneManager.LoadSceneAsync("GameScene");
    }

    public void LoadDialogScene()
    {
        SceneManager.LoadSceneAsync("DialogScene");
    }

    public void LoadLoseScene()
    {
        SceneManager.LoadSceneAsync("LoseScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

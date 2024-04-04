using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    int step = 0;
    List<string> repls;
    public TMP_Text tmp;
    // Start is called before the first frame update
    void Start()
    {
        repls =
        @"- Привет, игрок
- Привет
- Хорошо, что ты появился...
- Что-то случилось?
- Да, на нашу поляну напал страшный красный квадрат
- О боже, я могу чем-то помочь?
- Да, попробуй победить его
- Хорошо, я попытаюсь..."
        .Split("\n").ToList();
        UpdateText();
    }

    public void Next()
    {
        step++;
        if (step < repls.Count)
            UpdateText();
        else SceneManager.LoadSceneAsync("GameScene");
    }

    public void Prev()
    {
        step = Math.Max(step - 1, 0);
        UpdateText();
    }

    public void UpdateText()
    {
        tmp.SetText(repls[step]);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

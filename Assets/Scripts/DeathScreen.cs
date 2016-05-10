using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathScreen : MonoBehaviour {

    public Text label;
    public string labelText;

    void Awake()
    {
        gameObject.SetActive(false);

        if (label != null && labelText == "")
            labelText = label.text;
    }

    public void Dead()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;

        if (label != null && label.text != "")
        {
            int score = Score.instance.score;
            label.text = string.Format(labelText, score);
        }
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;
    }
}

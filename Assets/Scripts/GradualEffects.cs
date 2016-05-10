using UnityEngine;
using System.Collections;

public class GradualEffects : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(GainScore());
        StartCoroutine(GradualSpeedUp());
    }

    IEnumerator GainScore()
    {
        Score score = Score.instance;

        while (true)
        {
            score.score += 1;
            yield return new WaitForSeconds(0.25f);
        }
    }

    IEnumerator GradualSpeedUp()
    {
        float step = 0.01f;

        while (Time.timeScale < 100 - step)
        {
            Time.timeScale += step;
            yield return new WaitForSeconds(1f / Time.timeScale);
        }
    }
}

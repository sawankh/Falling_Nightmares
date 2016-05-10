using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public static Score instance { get; private set; }


    public int score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            UpdateLabel();
        }
    }
    private int _score;

    public Text label;
    [Tooltip("Gets the value on the actual Text component if this is empty.")]
    public string labelText;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
        {
            Destroy(instance);
            instance = this;
        }


        if (label == null)
            label = GetComponent<Text>();

        if (label == null)
            Debug.LogError("No Text component is referenced to use as label!");

        if (labelText == "")
            labelText = label.text;
    }

    void UpdateLabel()
    {
        label.text = labelText + score;
    }
}
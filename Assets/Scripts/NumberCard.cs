using TMPro;
using UnityEngine;

public class NumberCard : MonoBehaviour
{
    public int value;
    private string expression;
    [SerializeField] private TMP_Text topLeftText;
    [SerializeField] private TMP_Text bottomRightText;
    void Start()
    {
        // maybe do something
    }

    public void SetValue(int val)
    {
        value = val;
        // this will most likely be changed
        expression = value.ToString();
        topLeftText.SetText(" " + value.ToString());
        bottomRightText.SetText(" " + value.ToString());
    }
}

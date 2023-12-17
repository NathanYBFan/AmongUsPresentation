using UnityEngine;
using System.Collections;
using TMPro;

// attach to UI Text component (with the full text already there)

public class UITextTypeWriter: MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI displayedText;
    
    [SerializeField]
    private float delayTime = 2f;

    [SerializeField]
    private float delayBetweenLetters = 0.125f;

    private string story;

    void Awake()
    {
        story = displayedText.text;
        displayedText.text = "";

        StartCoroutine("PlayText");
    }

    IEnumerator PlayText()
    {
        yield return new WaitForSeconds(delayTime);

        foreach (char c in story)
        {
            displayedText.text += c;
            yield return new WaitForSeconds(delayBetweenLetters);
        }
    }
}
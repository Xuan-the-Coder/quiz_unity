using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    private Answer answer = null;
    private Text answerText = null;

    private void Awake()
    {
        answerText = this.transform.GetComponentInChildren<Text>();
    }

    public void SetAnswer(Answer answer)
    {
        this.answer = answer;
        answerText.text = answer.answer;
    }

    public void Pressed()
    {
        // Check if the answer is correct
        if (answer.isCorrect)
        {
            Debug.Log("This is the correct answer");
        }
        else
        {
            Debug.Log("This is the wrong answer");
        }
    }
}

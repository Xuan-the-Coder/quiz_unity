using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text questionText = null;
    [SerializeField] private Question[] questions = null;
    private int questionIndex = 0;
    [SerializeField] private AnswerButton[] answerButtons;
    [SerializeField] private SceneChanger sceneChanger = null;

    private void Start()
    {
        Debug.Log("GameManager Start");
        AskQuestion();
    }    
    private void AskQuestion()
    {
        // Setting question text with question string
        questionText.text = questions[questionIndex].question;

        // Setting answers
        // Array are zero based, the first value starts at index 0
        // For loop
        for (int i = 0; i < questions[questionIndex].answers.Length; i++)
        {
            answerButtons[i].SetAnswer(questions[questionIndex].answers[i]);
        }
    }
    public void NextQuestion()
    {
        if(questionIndex < questions.Length - 1)
        {
            questionIndex++;
            Debug.Log($"Now asking question {questionIndex}");
            AskQuestion();
        }
        else
        {
            Debug.Log("No more questions to ask. Changing scene to Menu");
            sceneChanger.SetScene(0);
        }
    }
}
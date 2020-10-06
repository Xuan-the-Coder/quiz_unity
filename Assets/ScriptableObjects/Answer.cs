using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Answer")]
public class Answer : ScriptableObject
{
    public string answer = "This is an answer";
    public bool isCorrect = false;    
}

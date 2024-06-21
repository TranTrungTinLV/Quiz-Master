using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{ 
    int correctAnswer = 0;
    int questionsSeen = 0;

    public int GetCorrectAnswers()
    {
        return correctAnswer;
    }

    public void IncrementCorrectAnswer()
    {
        correctAnswer++;
    }
    public int GetQuestionSeen()
    {
        return questionsSeen;
    }

    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswer / (float)questionsSeen * 100);
    }
}

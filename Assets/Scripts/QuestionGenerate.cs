using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
 

    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 3);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Na co dělíme hlásky?";
                QuestionDisplay.newA = "Slabiky";
                QuestionDisplay.newB = "Souhlásky a samohlásky";
                QuestionDisplay.newC = "Dvojhlásky";
                QuestionDisplay.newD = "Holky a kluky";
                actualAnswer = "B";
            }


            if (questionNumber != 1)
            {
                QuestionDisplay.newQuestion = "Co jsou to antonyma?";
                QuestionDisplay.newA = "Slova stejného významu";
                QuestionDisplay.newB = "Slova podobného významu";
                QuestionDisplay.newC = "Slova zvláštního významu";
                QuestionDisplay.newD = "Slova opačného významu";
                actualAnswer = "D";
            }

          
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}

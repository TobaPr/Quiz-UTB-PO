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
            questionNumber = Random.Range(1, 21);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Na co dělíme hlásky?";
                QuestionDisplay.newA = "Slabiky";
                QuestionDisplay.newB = "Souhlásky a samohlásky";
                QuestionDisplay.newC = "Dvojhlásky";
                QuestionDisplay.newD = "Holky a kluky";
                actualAnswer = "B";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Co jsou to antonyma?";
                QuestionDisplay.newA = "Slova stejného významu";
                QuestionDisplay.newB = "Slova podobného významu";
                QuestionDisplay.newC = "Slova zvláštního významu";
                QuestionDisplay.newD = "Slova opačného významu";
                actualAnswer = "D";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Kolik je 12 + 9 ?";
                QuestionDisplay.newA = "20";
                QuestionDisplay.newB = "21";
                QuestionDisplay.newC = "22";
                QuestionDisplay.newD = "23";
                actualAnswer = "B";
            }
            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Kolik je 48 / 8 ?";
                QuestionDisplay.newA = "6";
                QuestionDisplay.newB = "4";
                QuestionDisplay.newC = "5";
                QuestionDisplay.newD = "7";
                actualAnswer = "A";
            }
            if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Jaké je hlavní město České Republiky?";
                QuestionDisplay.newA = "Bratislava";
                QuestionDisplay.newB = "Brno";
                QuestionDisplay.newC = "Praha";
                QuestionDisplay.newD = "Ostrava";
                actualAnswer = "C";
            }
            if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Jaké je druhé největší město České Republiky?";
                QuestionDisplay.newA = "Brno";
                QuestionDisplay.newB = "Olomouc";
                QuestionDisplay.newC = "Ostrava";
                QuestionDisplay.newD = "Praha";
                actualAnswer = "A";
            }
            if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "Který pták neumí létat?";
                QuestionDisplay.newA = "Orel";
                QuestionDisplay.newB = "Vrabec";
                QuestionDisplay.newC = "Holub";
                QuestionDisplay.newD = "Pštros";
                actualAnswer = "D";
            }
            if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "Jak se jmenuje náš prezident?";
                QuestionDisplay.newA = "Petr Pavel";
                QuestionDisplay.newB = "Miloš Zeman";
                QuestionDisplay.newC = "Andrej Babiš";
                QuestionDisplay.newD = "Petr Fiala";
                actualAnswer = "A";
            }
            if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Kolik je měsíců v roce?";
                QuestionDisplay.newA = "10";
                QuestionDisplay.newB = "11";
                QuestionDisplay.newC = "12";
                QuestionDisplay.newD = "13";
                actualAnswer = "C";
            }
            if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "Které zvíře je býložravec?";
                QuestionDisplay.newA = "Lev";
                QuestionDisplay.newB = "Kráva";
                QuestionDisplay.newC = "Prase";
                QuestionDisplay.newD = "Myš";
                actualAnswer = "B";
            }
            if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "Které zvíře je masožravec?";
                QuestionDisplay.newA = "Lev";
                QuestionDisplay.newB = "Kráva";
                QuestionDisplay.newC = "Prase";
                QuestionDisplay.newD = "Myš";
                actualAnswer = "A";
            }
            if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "Které zvíře je všežravec?";
                QuestionDisplay.newA = "Lev";
                QuestionDisplay.newB = "Kráva";
                QuestionDisplay.newC = "Prase";
                QuestionDisplay.newD = "Koza";
                actualAnswer = "C";
            }
            if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "Kolik má kráva žaludků?";
                QuestionDisplay.newA = "1";
                QuestionDisplay.newB = "8";
                QuestionDisplay.newC = "2";
                QuestionDisplay.newD = "4";
                actualAnswer = "D";
            }
            if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "Kolik planet je v naší sluneční soustavě?";
                QuestionDisplay.newA = "7";
                QuestionDisplay.newB = "4";
                QuestionDisplay.newC = "8";
                QuestionDisplay.newD = "9";
                actualAnswer = "C";
            }
            if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "Kolik je 12 * 3 ?";
                QuestionDisplay.newA = "36";
                QuestionDisplay.newB = "24";
                QuestionDisplay.newC = "15";
                QuestionDisplay.newD = "48";
                actualAnswer = "A";
            }
            if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "Která země nesousedí s Českou Republikou?";
                QuestionDisplay.newA = "Slovensko";
                QuestionDisplay.newB = "Polsko";
                QuestionDisplay.newC = "Ukrajina";
                QuestionDisplay.newD = "Německo";
                actualAnswer = "C";
            }
            if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "Jaké písmeno nepatří mezi samohlásky?";
                QuestionDisplay.newA = "E";
                QuestionDisplay.newB = "A";
                QuestionDisplay.newC = "U";
                QuestionDisplay.newD = "R";
                actualAnswer = "D";
            }
            if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "Jak se anglicky píše červená?";
                QuestionDisplay.newA = "Blue";
                QuestionDisplay.newB = "Červená";
                QuestionDisplay.newC = "Red";
                QuestionDisplay.newD = "Black";
                actualAnswer = "C";
            }
            if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "Co znamená v angličtině: My name is?";
                QuestionDisplay.newA = "Tvoje jméno není";
                QuestionDisplay.newB = "Moje jméno je";
                QuestionDisplay.newC = "Tvoje jméno je ";
                QuestionDisplay.newD = "Moje jméno není";
                actualAnswer = "B";
            }
            if (questionNumber == 20)
            {
                QuestionDisplay.newQuestion = "V jakém světadílu se nachází Česká Republika?";
                QuestionDisplay.newA = "Amerika";
                QuestionDisplay.newB = "Asie";
                QuestionDisplay.newC = "Evropa";
                QuestionDisplay.newD = "Afrika";
                actualAnswer = "C";
            }






            QuestionDisplay.pleaseUpdate = false;
        }
    }
}

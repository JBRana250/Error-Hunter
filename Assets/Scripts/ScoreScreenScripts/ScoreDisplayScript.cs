using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// this script will handle both score and the grade since both are related.

public class ScoreDisplayScript : MonoBehaviour
{
    //dictionary containing all grades and corrosponding score range. Initialize dictionary with values.
    private Dictionary<string,List<int>> gradeBoundaries = new Dictionary<string,List<int>>
    {
        { "F-", new List<int>{0, 5} },
        { "F", new List<int>{6, 10} },
        { "F+", new List<int>{11, 15} },
        { "D-", new List<int>{16, 25} },
        { "D", new List<int>{26, 35} },
        { "D+", new List<int>{36, 45} },
        { "C-", new List<int>{46, 60} },
        { "C", new List<int>{61, 75} },
        { "C+", new List<int>{76, 100} },
        { "B-", new List<int>{101, 125} },
        { "B", new List<int>{126, 150} },
        { "B+", new List<int>{151, 175} },
        { "B++", new List<int>{176, 200} },
        { "A-", new List<int>{201, 300} },
        { "A", new List<int>{301, 400} },
        { "A+", new List<int>{401, 500} },
        { "A++", new List<int>{501, 750} },
        { "S--", new List<int>{751, 1000} },
        { "S-", new List<int>{1001, 1250} },
        { "S", new List<int>{1251, 1500} },
        { "S+", new List<int>{1501, 2000} },
        { "S++", new List<int>{2001, 2500} },
        { "SS", new List<int>{2501, 10000} } 
    };
    private string Score;
    public GameObject gradeDisplayTextGO;
    private int parsedScore;


    
    void Start()
    {
        Score = CrossSceneManager.CrossSceneScore;
        gameObject.GetComponent<TextMeshProUGUI>().text = string.Concat("Score: ", Score);
        bool success = int.TryParse(Score, out parsedScore);
        if(success)
        {
            gradeDisplayTextGO.GetComponent<TextMeshProUGUI>().text = DetermineGrade(parsedScore);
        }
    }

    // based on an integer score value, iterate through every key-value pair in the dictionary. Get the grades and the boundaries associated with them. Then, check if the score is within the bounds. If so, return the grade. If not, keep iterating.
    string DetermineGrade(int Score)
    {
        foreach(var GradeBoundaries in gradeBoundaries)
        {
            string grade = GradeBoundaries.Key;
            List<int> boundaries = GradeBoundaries.Value;

            int lowerBound = boundaries[0];
            int upperBound = boundaries[1];

            if(Score >= lowerBound && Score <= upperBound)
            {
                return grade;
            }
        }
        return "How?!?";
    }
}

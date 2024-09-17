using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class _ScoreController : MonoBehaviour
{

    public TextMeshProUGUI _ScoreText;
    private int score;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")) score += 1 ;

        _ScoreText.text =  score.ToString(); 
    }

    public void ResetScore()
    {
        score = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

    public Text score;

    private void FixedUpdate()
    {
        GetComponent<Text>().text = Score.score.ToString();
    }
}

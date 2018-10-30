using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTutorial : MonoBehaviour {

    float timer = 0f;
	
	void Update () {
        timer += Time.deltaTime;
        if(timer > 5f)
        {
            this.gameObject.GetComponent<Image>().enabled = false;
        }
	}
}

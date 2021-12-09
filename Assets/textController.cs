using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textController : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text;

    void Start()
    {
       text = GetComponent<Text>();
       text.text = ""; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showText() {
    	text.text = "GAME OVER";
    }
}

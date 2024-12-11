using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    //declare button
    private Button button;
    

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        //when clicked set difficulty
        button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty()
    {
        //show what mode is on
        Debug.Log(gameObject.name + " mode is on");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

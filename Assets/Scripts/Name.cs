using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{

    public string inputName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void DisplayName()
    {

        inputName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Good Luck " + inputName + "!";
    }

}

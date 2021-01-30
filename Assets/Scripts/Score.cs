
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z); // may have to change player pos to 0 from the gui
        scoreText.text = player.position.z.ToString("0"); // "0" to display whole numbers only
    }
}

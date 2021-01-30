
using UnityEngine;
using UnityEngine.SceneManagement; // included for restart function

public class GameManager : MonoBehaviour
{

    public float restartDelay = 1f;
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        //Debug.Log("Level Won!");
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            //Restart();
            Invoke("Restart", restartDelay); // calls restart function and delays by restartDelay var, can change in menu
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}

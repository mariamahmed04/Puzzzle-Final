using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartPuzzle : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

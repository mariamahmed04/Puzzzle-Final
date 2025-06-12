using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public static PuzzleManager instance;
    private int cubesPlaced = 0;

    public GameObject successCanvas;

    void Awake()
    {
        instance = this;
    }

    public void CubePlaced()
    {
        cubesPlaced++;
        if (cubesPlaced >= 3)
        {
            Debug.Log("Puzzle Completed!");
            successCanvas.SetActive(true);
        }
    }
}

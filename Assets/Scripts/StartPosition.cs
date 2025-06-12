using UnityEngine;

public class StartPosition : MonoBehaviour
{
    public Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }
}

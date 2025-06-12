using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;

public class CubePlacement : MonoBehaviour
{
    public string requiredTag;
    private bool isOccupied = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isOccupied) return;

        if (other.CompareTag(requiredTag))
        {
            // Correct cube placed
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.GetComponent<XRGrabInteractable>().enabled = false;
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
            isOccupied = true;

            PuzzleManager.instance.CubePlaced();
        }
        else
        {
            // Wrong cube placed — move it back
            StartCoroutine(ReturnToStart(other.gameObject));
        }
    }

    IEnumerator ReturnToStart(GameObject cube)
    {
        yield return new WaitForSeconds(0.5f);
        cube.transform.position = cube.GetComponent<StartPosition>().startPos;
        cube.transform.rotation = Quaternion.identity;
    }
}

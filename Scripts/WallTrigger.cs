using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public GameObject groundSection;
    float xPosition = 260.1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerWall")
        {
            Instantiate(groundSection, new Vector3(xPosition, 0.7f, 0.06f), Quaternion.identity);
        }
        xPosition += 210;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracking : MonoBehaviour {

    private void OnTrackingFound()
    {
        Renderer[] rendererComponents = GetComponentsInChildren<Renderer>();

        // Enable rendering:
        foreach (Renderer component in rendererComponents)
        {
            component.enabled = true;
        }


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NetworkCamera : NetworkBehaviour
{
    Camera baseplateCam;

    public override void OnStartClient()
    {
        base.OnStartClient();
        baseplateCam = GetComponentInChildren<Camera>();
        if (isLocalPlayer)
        {
            baseplateCam.rect = new Rect(0.068f, 0.025f, 0.24f, 0.33f);
        }
        else
        {
            baseplateCam.rect = new Rect(0.655f, 0.025f, 0.24f, 0.33f);
        }
    }
}
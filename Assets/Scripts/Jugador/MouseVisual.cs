using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseVisual : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}

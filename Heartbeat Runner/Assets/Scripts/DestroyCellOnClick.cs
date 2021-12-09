using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCellOnClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}

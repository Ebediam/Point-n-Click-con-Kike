using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.OnRightClickEvent += UpdatePosition;
        UpdatePosition();
    }

    // Update is called once per frame
    void UpdatePosition()
    {
        transform.position = GameManager.MousePosition();
    }
}

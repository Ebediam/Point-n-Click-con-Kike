using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MouseFollow : MonoBehaviour
{
    public bool active;
    public float speed;
    public Vector3 goal;
    public float proximitySensitivity;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.OnRightClickEvent += MoveTowards;
    }

    // Update is called once per frame
    void Update()
    {


    }



    void MoveTowards()
    {
        goal = GameManager.MousePosition();

        if (active)
        {
            return;
        }

        active = true;
        StartCoroutine(MoveTowardsCoroutine());
    }

    IEnumerator MoveTowardsCoroutine()
    {
        while((Vector3.Distance(transform.position, goal) > proximitySensitivity))
        {
            transform.position += (goal - transform.position).normalized * speed*Time.deltaTime;
                
                //Vector3.Lerp(transform.position, goal, speed);

            yield return null;

        }

        active = false;

    }
}

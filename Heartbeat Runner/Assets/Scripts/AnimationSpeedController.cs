using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //If the player taps the heart x time the animator speed goes up a level, if the player misses it goes down a level
        //animator.speed += Time.deltaTime / 10;
    }
}

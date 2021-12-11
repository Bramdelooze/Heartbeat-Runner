using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedController : MonoBehaviour
{
    private Animator animator;
    private DistanceToDesk distanceToDesk;
    public int speedLevel = 1;
    public int maxSpeed = 4;
    // Start is called before the first frame update
    void OnEnable()
    {
        animator = GetComponent<Animator>();
        distanceToDesk = FindObjectOfType<DistanceToDesk>();
    }

    public void ChangeSpeed()
    {
        //If the player taps the heart x time the animator speed goes up a level, if the player misses it goes down a level
        animator.speed = (float)speedLevel;
        distanceToDesk.ChangeSubtractSpeed(speedLevel);
    }
}

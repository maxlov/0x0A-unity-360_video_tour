using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourChange : MonoBehaviour
{
    public GameObject player;
    public GameObject tourCurrent;
    public GameObject tourNext;

    public Animator animator;

    public void TourTransition()
    {
        animator.SetTrigger("FadeOut");
        tourNext.SetActive(true);
        player.transform.position = tourNext.transform.position;
        player.transform.position -= new Vector3(0f, 2f);
        tourCurrent.SetActive(false);
    }
}

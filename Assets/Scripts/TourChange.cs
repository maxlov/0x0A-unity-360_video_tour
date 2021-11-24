using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourChange : MonoBehaviour
{
    public GameObject player;
    public GameObject tourCurrent;
    public GameObject tourNext;

    public void TourTransition()
    {
        tourNext.SetActive(true);
        player.transform.position = tourNext.transform.position;
        tourCurrent.SetActive(false);
    }
}

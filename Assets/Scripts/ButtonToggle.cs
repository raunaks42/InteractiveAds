using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonToggle : MonoBehaviour,
                                            ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    //public GameObject[] inactive;
    public GameObject[] active;
    public GameObject slider;
    public GameObject button;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            foreach (GameObject go in active)
            {
                go.SetActive(true);
            }
            slider.SetActive(true);
            button.SetActive(true);
        }
        else
        {
            foreach (GameObject go in active)
            {
                go.SetActive(false);
            }
            slider.SetActive(false);
            button.SetActive(false);
        }
    }
}

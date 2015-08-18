﻿using UnityEngine;
using System.Collections;

public class TrackerVicon : Tracker
{
    // Update is called once per frame
    void Update()
    {
        if (trackPosition)
        {
            transform.position = ViconVRPN.vrpnTrackerPos(obj + "@" + host, channel);
        }
        if (trackRotation)
        {
            transform.rotation = ViconVRPN.vrpnTrackerQuat(obj + "@" + host, channel);
        }
    }
}

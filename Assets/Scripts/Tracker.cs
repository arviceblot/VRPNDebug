using UnityEngine;
using System.Collections;

public class Tracker : MonoBehaviour
{
    public string host = "localhost";
    public string obj;
    public int channel = 0;

    public bool trackPosition = true;
    public bool trackRotation = true;

    // Update is called once per frame
    void Update()
    {
        if (trackPosition)
        {
            transform.position = VRPN.vrpnTrackerPos(obj + "@" + host, channel);
        }
        if (trackRotation)
        {
            transform.rotation = VRPN.vrpnTrackerQuat(obj + "@" + host, channel);
        }
    }
}

using UnityEngine;
using System.Collections;

public static class ViconVRPN
{
    public static Vector3 vrpnTrackerPos(string address, int channel)
    {
        Vector3 pos = VRPN.vrpnTrackerPos(address, channel);
        return new Vector3(pos.x, pos.z, pos.y);
    }
	
    public static Quaternion vrpnTrackerQuat(string address, int channel)
    {
        Quaternion quat = VRPN.vrpnTrackerQuat(address, channel);
        return new Quaternion(quat.x, quat.z, quat.y, -quat.w);
    }
}

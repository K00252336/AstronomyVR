using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{

    public Transform player;
    public Transform spawnLocation;
    public Transform rocketLocation;
    public Transform voyager1Location;

    public void NavSpawn()
    {
        player.transform.position = spawnLocation.transform.position;
    }

    public void NavRocketLocation()
    {
        player.transform.position = rocketLocation.transform.position;
    }

    public void NavVoyager1Location()
    {
        player.transform.position = voyager1Location.transform.position;
    }
}

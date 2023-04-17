using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{

    public Transform player;
    public Transform spawnLocation;

    //Human Objects
    public Transform apollo11Location;
    public Transform voyager1Location;
    public Transform voyager2Location;

    //Planets
    public Transform earthLocation;
    public Transform marsLocation;
    public Transform venusLocation;


    public void NavSpawn()
    {
        player.transform.position = spawnLocation.transform.position;
    }

    public void NavApollo11Location()
    {
        player.transform.position = apollo11Location.transform.position;
    }

    public void NavVoyager1Location()
    {
        player.transform.position = voyager1Location.transform.position;
    }

    public void NavVoyager2Location()
    {
        player.transform.position = voyager2Location.transform.position;
    }

    public void NavEarthLocation()
    {
        player.transform.position = earthLocation.transform.position;
    }

    public void NavMarsLocation()
    {
        player.transform.position = marsLocation.transform.position;
    }

    public void NavVenusLocation()
    {
        player.transform.position = venusLocation.transform.position;
    }
}
/*
 * Author: AshenTales
 * Day/Night controller script for GGJ jam project Voided(warranty)
 * Uses set limits to select a random amount of customers to control the day and night cycle of the game.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    // init vars
    [SerializeField] private int[] dayCustomerMinMax = {3,5};
    [SerializeField] private int[] nightCustomerMinMax = {1,2};
    [SerializeField] private float timePerDay = 8f; // Time per day in hours
    [SerializeField] private float timePerHour = 60f; // Time in seconds per game hour

    public int currentDayCustomers = 0; 
    public int currentNightCustomers = 0;
    public float currentTime = 0f;

    void Start()
    {
        GenerateCustomerCounts(dayCustomerMinMax[0], dayCustomerMinMax[1], nightCustomerMinMax[0], nightCustomerMinMax[1]);
    }

    void Update()
    {
        KeepTime();
    }

    void GenerateCustomerCounts(int dayMin, int dayMax, int nightMin, int nightMax) // Generate customer counts based on given min and max values
    {
        currentDayCustomers = Random.Range(dayMin, dayMax);
        currentNightCustomers = Random.Range(nightMin, nightMax);
    }

    void KeepTime()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timePerDay * timePerHour)
        {
            //insert code here to end day.
        }
    }
}
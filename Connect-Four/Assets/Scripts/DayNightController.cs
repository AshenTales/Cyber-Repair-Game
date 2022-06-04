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
    [SerializeField] int dayCustomersMax = 5;
    [SerializeField] int dayCustomerMin = 3;
    [SerializeField] int nightCustomerMax = 2;
    [SerializeField] int nightCustomerMin = 1;

    [SerializeField]int dayCustomers = 0; //serialized for easy debug
    [SerializeField]int nightCustomers = 0; //serialized for easy debug

    void Start()
    {
        GenerateCustomerCounts(dayCustomerMin, dayCustomersMax, nightCustomerMin, nightCustomerMax);
    }

    void Update()
    {
        
    }

    void GenerateCustomerCounts(int dayMin, int dayMax, int nightMin, int nightMax)
    {
        dayCustomers = Random.Range(dayMin, dayMax);
        nightCustomers = Random.Range(nightMin, nightMax);
    }
}
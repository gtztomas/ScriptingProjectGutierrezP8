using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If it isn't, but the coffee temperaature is less than the hottest drink
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it is'nt, but the coffee temperature is less than the coldest drink
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //...do this...
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            //...do this.
            print("Coffee is just right");
        }
    }
}


   
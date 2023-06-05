using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class LevelTransitionTest
{
   


    [UnityTest]
    public IEnumerator OnTriggerEnter2D_WhenCollisionWithPlayer_ShouldSetActivePanel()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }

    [UnityTest]
    public IEnumerator LoadDelay_WaitsForGivenTime_ThenCallsTransitionNextLevel()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

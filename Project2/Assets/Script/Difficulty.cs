using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficulty
{

    // Use this for initialization
    public static float secondsToMaxDifficulty = 60f;

    public static float GetDifficultyPercent()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    }
}

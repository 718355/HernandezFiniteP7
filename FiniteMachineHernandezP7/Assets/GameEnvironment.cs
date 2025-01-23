using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class GameEnviorment
{
    private static GameEnviorment instance;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return checkpoints; } }

    public static GameEnviorment Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new GameEnviorment();
                instance.checkpoints.AddRange(
                    GameObject.FindGameObjectsWithTag("Checkpoint"));
            }
            return instance;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    //THIS IS SUPPOSED TO HOLD FUNDAMENTAL PIECES OF THE GAME.

    public static GameHandler instance;


    private void Awake()
    {
        instance = this;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinLogic : MonoBehaviour
{
   public void SimulateGameWin()
    {
        EventBus.Publish(EventType.WIN);
    }
}

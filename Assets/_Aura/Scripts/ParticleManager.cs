using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    void Start()
    {
        EventBus.Subsribe(EventType.WIN, PlayWinParticleFX);
    }
    
    public void PlayWinParticleFX()
    {
        Debug.Log("Playing Win Particle Fx!");
    }
}

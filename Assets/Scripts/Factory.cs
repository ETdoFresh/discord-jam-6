using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] private GameEvents gameEvents;
    [SerializeField] private int cost;
    [SerializeField] private AudioClip buildSound;
    
    private void Start()
    {
        FindObjectOfType<CurrencyManager>().AddReward(-cost);
        var factories = FindObjectsOfType<Factory>();
        if (buildSound) AudioPlayer.PlaySound(buildSound);
        //disabled for now, I'd like the snowman being placed to start the wave
        if (factories.Length == 1)
            gameEvents.startWave.Invoke(1);
    }
}

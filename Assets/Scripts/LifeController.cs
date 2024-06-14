using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public static LifeController instance;
    private void Awake()
    {
        instance = this;
    }

    private PlayerController thePlayer;

    public float respawnDelay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindFirstObjectByType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn()
    {
        //thePlayer.transform.position = FindFirstObjectByType<CheckpointManager>().respawnPosition;

        //PlayerHealthController.instance.AddHealth(PlayerHealthController.instance.maxHealth);

        thePlayer.gameObject.SetActive(false);

        StartCoroutine(RespawnCo());


    }

    public IEnumerator RespawnCo()
    {
        yield return new WaitForSeconds(respawnDelay);

        thePlayer.transform.position = FindFirstObjectByType<CheckpointManager>().respawnPosition;

        PlayerHealthController.instance.AddHealth(PlayerHealthController.instance.maxHealth);

        thePlayer.gameObject.SetActive(true);
    }
}

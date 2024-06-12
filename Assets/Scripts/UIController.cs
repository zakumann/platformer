using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    private void Awake()
    {
        instance = this;
    }

    public Image[] heartIcons;

    public Sprite heartFull, heartEmpty;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthDisplay(int health, int maxHealth)
    {
        for(int i = 0; i < heartIcons.Length; i++)
        {
            heartIcons[i].enabled = true;

            /*if(health <= i)
            {
                heartIcons[i].enabled = false;
            }*/

            if(health > i)
            {
                heartIcons[i].sprite = heartFull;
            } else
            {
                heartIcons[i].sprite = heartEmpty;

                if (maxHealth <= i)
                {
                    heartIcons[i].enabled = false;
                }
            }
        }
    }
}

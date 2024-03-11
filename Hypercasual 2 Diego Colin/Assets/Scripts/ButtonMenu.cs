using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenu : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject menu;

   
    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);
    }


    public void StartGame()
    {
        player.SetActive(true);
        enemy.SetActive(true);
        menu.SetActive(false);
    }

    public void QuitGame()
    {
        QuitGame();
    }
}

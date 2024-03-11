using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class FloorDead : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject spawner;

    [SerializeField] private TMP_Text texto;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            player.SetActive(false);
            menu.SetActive(true);
            spawner.SetActive(false);

            texto.text = "";
        }
    }
}

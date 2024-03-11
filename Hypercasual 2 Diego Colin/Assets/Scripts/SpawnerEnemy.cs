using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    private float minx, maxx, miny, maxY;

    [SerializeField] private Transform[] puntos;

    [SerializeField] private GameObject enemigos;

    [SerializeField] private float tiempoEnemigos;

    private float tiempoSiguienteEnemigo;



    private void Start()
    {
        maxx = puntos.Max(punto => punto.position.x);
        minx = puntos.Min(punto => punto.position.x);
        maxY = puntos.Max(punto => punto.position.y);
        miny = puntos.Min(punto => punto.position.y);

        
    }

    private void Update()
    {

        tiempoSiguienteEnemigo += Time.deltaTime;

        if (tiempoSiguienteEnemigo >= tiempoEnemigos)
        {
            tiempoSiguienteEnemigo = 0;
            Debug.Log("EnemigoSpawn");
            CreateEnemy();
        }
    }

    private void CreateEnemy()
    {
        Vector2 posicionAleatoria = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxY));
        Instantiate(enemigos, posicionAleatoria, Quaternion.identity);
    }


    //Codigo sacado de: https://youtu.be/ccY78OsPIN0?si=YTtq-zrv_ZSflqEU
}

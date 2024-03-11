using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pont : MonoBehaviour
{

    [SerializeField] GameObject enemy;
    [SerializeField] private float tiempoEnemigos;
    private float tiempoSiguienteEnemigo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {

        tiempoSiguienteEnemigo += Time.deltaTime;

        if (tiempoSiguienteEnemigo >= tiempoEnemigos)
        {
            tiempoSiguienteEnemigo = 0;
            Instantiate(enemy, transform.TransformPoint(transform.position.y, transform.position.x, transform.position.z) , Quaternion.identity);
        }
    }
}

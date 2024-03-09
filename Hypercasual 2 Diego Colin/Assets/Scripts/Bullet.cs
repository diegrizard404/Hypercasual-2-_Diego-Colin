using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int damage;

    Vector3 dir;


    // Update is called once per frame
    void Update()
    {
        //"Translate" es el movimiento en posicionamiento LOCAL"
       transform.Translate(dir.normalized * speed * Time.deltaTime); //Movimiento hacia la derecha local del objeto
    }

    public void ChangeDirection(Vector2 mousePosition)
    {
        dir = Camera.main.ScreenToWorldPoint(mousePosition);// Cambia el Vector 2 mousePosition a un Vector3 y cambia las cordenadas de la camara
        dir.z = 0;
        dir = dir - transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)//Entrando a un trigger se activa
    {
      

        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Disparo");
            collision.GetComponent<Enemy>().Hit(damage);
            Destroy(gameObject);
        }

        if (collision.CompareTag("Wall"))
        {
           
            Destroy(gameObject);
        }
    }
}

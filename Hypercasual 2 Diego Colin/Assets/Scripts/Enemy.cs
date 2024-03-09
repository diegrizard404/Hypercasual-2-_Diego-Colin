using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float pushForce;
    [SerializeField] private int maxHp;

    private Rigidbody2D rb;
    private int hp;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        hp = maxHp;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        //"posicion inicial menos posicion final" = a Direccion
        Vector3 direction = new Vector3(0, -1, 0); //para perseguir al jugador se restan sus posiciones 

        rb.AddForce(direction * speed);//ponerle la direcion y la velocidad a la que se mueve
    }

    public void Hit(int damage)
    {
        
        hp -= damage;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            Push();
        }
    }

    private void Push()
    {
        Vector3 direction = new Vector3(-1, 0, 0);

        rb.AddForce(direction * pushForce, ForceMode2D.Impulse);
    }

}

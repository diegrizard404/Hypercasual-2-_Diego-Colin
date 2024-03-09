using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletPrefab;

    private PlayerInputActions playerInputActions; //referencia al mapa de controles
    private Rigidbody2D rb;


    private void Awake() //Se ejecuta antes que la Funcion Start
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }


        playerInputActions = new PlayerInputActions(); //Agregamos PlayerINPUT como funcion por los "()" lo que lo crea como un componente
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        playerInputActions.Enable(); //Activa el PlayerInputActions
        playerInputActions.BasicMovement.Shooting.performed += Shoot; //Para poder disparar una vez por tecla pulsada
                                                                      //Shoot es una Funcion que se le asigna a una Accion y se ejecuta cuando se active la accion


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Sucede cada dos Frames =D
    private void FixedUpdate()
    {
        //Se mete en FixedUpdate para ahorrar recursos (Todo lo que calcule Rigidbody se mete en FixedUodate)
        Move();
    }

    private void Move() //Nueva funcion para cuando sea llamada mueva al jugador
    {
        // Movimiento por Rigidbody es mas preciso pero a la vez mas costoso en recursos
        Vector3 direction = new Vector3(playerInputActions.BasicMovement.Movement.ReadValue<Vector2>().x, playerInputActions.BasicMovement.Movement.ReadValue<Vector2>().y, 0).normalized;
        rb.AddForce(direction * speed);

    }

    private void Shoot(InputAction.CallbackContext context)//Siempre que se use una Funcion con el INPUT System se ingresara lo que hay entre parentecis
    {
        string buttonName = context.control.name; //primero se busca la informacion del boton presionado en Context y se guarda como String

        switch (buttonName) //Switch funciona como un IF pero ordena de mejor manera los Else
        {
            case "upArrow"://"Case" es la commparacion con lo que hay entre parentesis en Switch
                Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0,0,90)); // Quaternion.Euler es una funcion para hacer Rotaciones
                break;//Necesario para romper la cadena de acciones cuando la comparacion es correcta
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this); 
        }
    }
}

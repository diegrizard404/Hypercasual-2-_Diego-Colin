using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowPlayer : MonoBehaviour
{
    private PlayerInputActions actions;

    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] GameObject player;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject spawner;

    [SerializeField] private TMP_Text texto;
    public int score = 0;

    private bool canShoot;
    private float timer;

    private void Awake()
    {
        actions = new PlayerInputActions();
        
    }

    private void Start()
    {
        actions.Enable();
        actions.Standard.Fire.performed += FireBullet;
        canShoot = true;
    }

    private void Update()
    {
        Move();

        
        if (!canShoot)
        {
            timer += Time.deltaTime;

            if (timer >= .3)
            {
                canShoot = true;
                timer = 0;
            }
        }

        texto.text = "" + score;

        if (score == 10 && score > 10)
        {
            player.SetActive(false);
            menu.SetActive(true);
            spawner.SetActive(false);

          
        }
    }

    private void Move()
    {
        Vector3 dir = actions.Standard.Movement.ReadValue<Vector2>();
        transform.Translate(dir * speed * Time.deltaTime);
    }

    private void FireBullet(InputAction.CallbackContext ctx)
    {
        if (canShoot)
        {
            if (Camera.main.ScreenToWorldPoint(actions.Standard.MousePossition.ReadValue<Vector2>()).y > transform.position.y)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                bullet.GetComponent<Bullet>().ChangeDirection(actions.Standard.MousePossition.ReadValue<Vector2>());

                canShoot = false;
            }
        }
        
    }

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

    public void Puntos()
    {
        score++;

        Debug.Log(score);
        texto.text = "" + score;
    }
}

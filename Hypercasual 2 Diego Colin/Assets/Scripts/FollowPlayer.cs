using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowPlayer : MonoBehaviour
{
    private PlayerInputActions actions;

    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletPrefab;

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
}

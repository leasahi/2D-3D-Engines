using UnityEngine;

public class Cannon : MonoBehaviour
{
    private BulletPool pool;

    //Gets the attached BulletPool component and saves it to its "pool" property
    private void Awake()
    {
        pool = GetComponent<BulletPool>();
    }

    //Gets a "bullet" from the "pool" and sets its position, rotation and velocity
    public void OnShoot()
    {
        Rigidbody bullet = pool.GetObject().GetComponent<Rigidbody>();
        bullet.transform.position = gameObject.transform.position;
        bullet.transform.rotation = gameObject.transform.rotation;
        bullet.linearVelocity = gameObject.transform.forward * 40;
        bullet.angularVelocity = Vector3.zero;
    }
}

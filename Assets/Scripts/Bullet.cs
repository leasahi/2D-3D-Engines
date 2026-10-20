using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private int maxFlyingTime = 10;

    [HideInInspector]
    public BulletPool pool;

    public UnityEvent OnBulletCollision;

    private void OnEnable()
    {
        StartCoroutine(BulletTimer());
    }
    
    //Invokes the "OnBulletCollision" event and returns itself to the "pool"
    private void OnTriggerEnter(Collider other)
    {
        OnBulletCollision.Invoke();
        pool.ReturnObject(gameObject);
    }

    //Waits for "maxFlyingTime" seconds and then returns itself to the "pool"
    private IEnumerator BulletTimer()
    {
        yield return new WaitForSeconds(maxFlyingTime);
        pool.ReturnObject(gameObject);
    }
}

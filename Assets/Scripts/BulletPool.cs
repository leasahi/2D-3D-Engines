using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private int poolSize = 10;

    private Queue<GameObject> pool = new Queue<GameObject>();

    //Instantiates up to "poolSize" "bulletPrefab" objects and puts them in a queue.
    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.GetComponent<Bullet>().pool = this;
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
    }

    //Get one "bullet" from the pool and return it.
    public GameObject GetObject()
    {
        GameObject pooledObject = pool.Dequeue();
        pooledObject.SetActive(true);
        return pooledObject;
    }

    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}

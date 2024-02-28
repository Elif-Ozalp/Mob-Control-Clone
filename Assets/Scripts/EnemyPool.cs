using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    private Queue<GameObject> availableObjects = new Queue<GameObject>();
    public static EnemyPool Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        GrowPool(50);
    }

    public GameObject GetFromPool()
    {
        if (availableObjects.Count == 0)
        {
            GrowPool(5);
        }
        var instance = availableObjects.Dequeue();
        return instance;
        
        
    }

    private void GrowPool(int n)
    {
        for (int i = 0; i < n; i++)
        {

            var instantiatedObj = Instantiate(prefab, transform);
            AddToPool(instantiatedObj);
        }
    }

    public void AddToPool(GameObject instance)
    {
        instance.SetActive(false);
        availableObjects.Enqueue(instance);
        instance.transform.SetParent(transform);
    }
    public void PutToPool3()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

    }
}

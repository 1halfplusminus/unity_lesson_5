using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnMouseDown : UnityEvent<GameObject> { }

public class InstanceLifeCycle : MonoBehaviour
{
    public OnSpawnEvent onDestroy;
    public OnMouseDown onMouseDown;
    public OnSpawnEvent onSpawn;
    void OnDestroy()
    {
        onDestroy.Invoke(gameObject);
        Debug.Log("InstanceLifeCycle OnDestroy " + gameObject.name);
    }

    void OnMouseDown()
    {
        onMouseDown.Invoke(gameObject);
        Debug.Log("InstanceLifeCycle OnMouseDown " + gameObject.name);
    }
}
[System.Serializable]
public class SpawnableInstance : MonoBehaviour
{
    public GameObject prefab;
    public OnSpawnEvent onSpawn;
    public OnMouseDown onMouseDown;
    public OnSpawnEvent onDestroy;
    public IEnumerator Spawn(SpawnZone zone)
    {
        Vector3 instancePos = zone.GetRandomPoint();
        return Spawn(zone.GetRandomPoint());
    }
    public IEnumerator Spawn(Vector3 instancePos)
    {
        var instance = Instantiate(prefab, instancePos, prefab.transform.rotation);
        return AfterSpawn(instance);
    }
    public IEnumerator Spawn(GameObject target)
    {
        var instance = Instantiate(prefab, target.transform.position, prefab.transform.rotation, target.transform);
        return AfterSpawn(instance);
    }
    public IEnumerator Spawn(Collision target)
    {
        var instance = Instantiate(prefab, target.transform.position, prefab.transform.rotation, target.transform);
        return AfterSpawn(instance);
    }
    private IEnumerator AfterSpawn(GameObject instance)
    {
        var lifecycle = instance.AddComponent(typeof(InstanceLifeCycle)) as InstanceLifeCycle;
        lifecycle.onDestroy = onDestroy;
        lifecycle.onMouseDown = onMouseDown;
        onSpawn.Invoke(instance);
        var name = instance.name;
        yield return new WaitUntil(() => instance == null);
    }

}

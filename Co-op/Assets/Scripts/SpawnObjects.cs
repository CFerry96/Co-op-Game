using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class SpawnObjects : MonoBehaviour
{
    public Transform objectToSpawn;

    public int spawnNumber;
	float timeToSpawn;
	public float timeBetweenWaves;
    public bool spawnNow;
    public Transform parentT;

    public BoxCollider collider;

	void Start () 
    {
		SpawnNow();
		timeToSpawn = timeBetweenWaves;
	    //collider = GetComponent<BoxCollider>();
	}
	

	void Update () 
    {
		timeToSpawn -= Time.deltaTime;
		if (timeToSpawn <= 0f){
			SpawnNow();
			timeToSpawn = timeBetweenWaves;
		}

	    if(spawnNow)
        {
			SpawnNow();
        }
	}

	public void SpawnNow()
	{
            spawnNow = false;
            for (int i = 0; i < spawnNumber; i++)
                SpawnNew();
	}

    void SpawnNew()
    {
        float _xWidth = (collider.size.x * transform.lossyScale.x);
        float _yWidth = (collider.size.y * transform.lossyScale.y);
        float _zWidth = (collider.size.z * transform.lossyScale.z);

        float x = transform.position.x + collider.center.x - _xWidth / 2.0f;
        float y = transform.position.y + collider.center.y - _yWidth / 2.0f;
        float z = transform.position.z + collider.center.z - _zWidth / 2.0f;

        Vector3 _pos = new Vector3(Random.Range(x, x + _xWidth), Random.Range(y, y + _yWidth), Random.Range(z, z + _zWidth));

        Transform _new = (Transform)Instantiate(objectToSpawn, _pos, objectToSpawn.rotation);

        if (parentT != null)
            _new.parent = parentT;
    }
}

using UnityEngine;

public class SpawnPlayerClick : MonoBehaviour
{
    public GameObject come;

    private GameObject currentSpawn; //use to to keep refernece to currently spawned prefab
   


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentSpawn == null)
        {
            //get the mouse position in screen space
            Vector3 mousePosition = Input.mousePosition;

            //convert the screen position to world space
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            //set the z position to 0 
            worldPosition.z = 0;

            currentSpawn = (Instantiate(come, worldPosition, Quaternion.identity));

        }

        //to destroy once mouse released

        if (Input.GetMouseButtonUp(0) && currentSpawn != null)
        {
            Destroy(currentSpawn);
            currentSpawn = null;
        }

    }
}

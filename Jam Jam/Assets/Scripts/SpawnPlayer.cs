using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
   public GameObject player;
   public float topScreenLimit = 5f;
   public float bottomScreenLimit = 4f;

   //need this to make sure that only one player can be instantiated per scene load
   private bool playerInstantiated = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !playerInstantiated)
        {
           //get the mouse position in screen space
            Vector3 mousePosition = Input.mousePosition;

            //convert the screen position to world space
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            //limit the y position to be within the top portion of the screen
            worldPosition.y = Mathf.Min(worldPosition.y, topScreenLimit);
            worldPosition.y = Mathf.Max(worldPosition.y, bottomScreenLimit);

            //set the z position to 0 
            worldPosition.z = 0;

            //instantiate the player object at the calculated position
            Instantiate(player, worldPosition, Quaternion.identity);

            //set bool/flag to true so that player cannot be instantiated again until scene is reloaded
            playerInstantiated = true;

        }
        
    }
}

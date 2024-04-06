using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollector : MonoBehaviour
{

    [SerializeReference] GameObject regFishPrefab;
    [SerializeReference] GameObject burningFishPrefab;
    [SerializeReference] GameObject explodingFishPrefab;
    public Queue <GameObject> fishList;
    bool thereIsFish;

    public bool isThereFish { get { return thereIsFish;  } }

    System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        fishList = new Queue<GameObject>();
        thereIsFish = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        //Spawn Fish
        if (Input.GetMouseButtonDown(1)) // Right-click to spawn fish
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = -Camera.main.transform.position.z;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            int rnd = random.Next(1, 4);

            if(rnd == 1) {
                GameObject regFish = Instantiate(regFishPrefab, worldPosition, Quaternion.identity);
                fishList.Enqueue(regFish);
                thereIsFish = true;
            }
            else if(rnd == 2)
            {
                GameObject burningFish = Instantiate(burningFishPrefab, worldPosition, Quaternion.identity);
                fishList.Enqueue(burningFish);
                thereIsFish = true;

            }
            else if(rnd == 3)
            {
                GameObject explodingFish = Instantiate(explodingFishPrefab, worldPosition, Quaternion.identity);
                fishList.Enqueue(explodingFish);
                thereIsFish = true;

            }

            
        }

    }

    // Collect fish
    public GameObject getFish()
    {

        if(fishList.Count == 0)
        {
            return null;
        }
        else if(fishList.Count == 1)
        {
            thereIsFish = false;
            return fishList.Dequeue();
        }
        else
        {
            return fishList.Dequeue();
        }

    }

    
}

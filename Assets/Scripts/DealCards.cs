using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealCards : MonoBehaviour
{
    public GameObject defenseCard;
    public GameObject handArea;
    // Start is called before the first frame update
    void Start() {

    }

    public void CreateCard() {
        GameObject DFSCard = Instantiate(defenseCard, new Vector2(0, 0), Quaternion.identity);

        DFSCard.transform.SetParent(handArea.transform, false);
    }
}

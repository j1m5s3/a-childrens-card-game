using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    public GameObject PlayerOneCard;
    public GameObject PlayerTwoCard;
    public GameObject PlayerOneField;
    public GameObject PlayerTwoField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBtnClick()
    {
        var playerCard = Instantiate( this.PlayerOneCard, new Vector3( 0, 0, 0 ), Quaternion.identity );
        playerCard.transform.SetParent( this.PlayerOneField.transform, false );
    }
}

using UnityEngine;
using System.collections.Generic;
using System.collections;


public class CollisionController : MonoBehaviour
{
  private void OncollionEnter2D(collision2D collision)
  {
    if(collision.gameobject.name == "door")
    {
        Debug.Log("enter");
    }
  }
  private void  OnCollisonStay2D(collision2D collision)
  {
   if(collision.gameobject.name == "door")
    {
        Debug.Log("stay");
    }
  }
  private void OncollisionExit2D(Collision2D collision)
  {
   if(collision.gameobject.name == "door")
    {
        Debug.Log("exit");
    }
  }
}

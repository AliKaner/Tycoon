using UnityEngine.UI;

namespace DefaultNamespace
{
    [UnityEngine.CreateAssetMenu(fileName = "ItemData", menuName = "Item", order = 0)]
    public class ItemData : UnityEngine.ScriptableObject
    {
        public string name;
        public string price;
        public Image image;
        public bool isStackable;
        public int maxStack;
        
        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class PostProcessVolume_Script : MonoBehaviour
{
   

    List<Color> color_list = new List<Color>();
    public  PostProcessVolume postProcessVolume_Change;
     // Start is called before the first frame update
  void Start()
    {
        var bloom_color = new ColorParameter();
      
       
        bloom_color.value = new Color(0/255f, 70/ 255f, 191/255f)*2.4f;
        color_list.Add(bloom_color);
      
        Invoke("BloomControl", 7f);
    }

    /*
     * 디폴트는 191,191,191,1.47
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
    private void BloomControl()
    {
        
        Bloom bloom = postProcessVolume_Change.profile.GetSetting<UnityEngine.Rendering.PostProcessing.Bloom>();
        
        bloom.color.Override(color_list[0]);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

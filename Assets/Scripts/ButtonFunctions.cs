using System.IO;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public Transform logTransform;
    public string filepath;
    StreamWriter file;
    private void Start()
    {
        filepath = Application.dataPath + "/Logs/";
        if (!Directory.Exists(filepath))
        {
            Directory.CreateDirectory(filepath);
        }        
        file = new StreamWriter(filepath + "TransformLog.txt", append: true);      
    }
    public void Log()
    {
        if(logTransform != null)
        {
            Vector3 pos = logTransform.position;
            Vector3 rot = logTransform.eulerAngles;

            Debug.Log("Position: " + pos.x + ", " + pos.y + ", " + pos.z + "; Rotation: " + rot.x + ", " + rot.y + ", " + rot.z);


            file.WriteLine(pos.x + "\t" + rot.x);
            file.WriteLine(pos.y + "\t" + rot.y);
            file.WriteLine(pos.z + "\t" + rot.z);
        }    
    }
    public void Exit()
    {
        Application.Quit();
    }
    private void OnDestroy()
    {
        file.Close();
    }
}

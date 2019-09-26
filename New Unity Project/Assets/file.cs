using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.Rendering;
using SFB;

public class file : MonoBehaviour
{
    //   string path;
    string[] path;
    public Material m;

    public void OpenExplorer()
    {
        // path = EditorUtility.OpenFilePanel("", "", "jpg");
         path = StandaloneFileBrowser.OpenFilePanel("", "", "jpg",false);



        WWW ww = new WWW("file:///" + path[0]);

        // string path1 = "Assets/12.jpg";
        //  Debug.Log("here");
        //  renderer.material.mainTexture
        //  Texture t = Resources.Load<Texture>(path1);
        m.SetTexture("_MainTex", ww.texture);
        // m.SetTexture("_MainTex", ww.texture);
        //   RenderSettings.skybox = m;
        //m.SetTexture("_Tex", ww.texture);
        // RenderSettings.skybox.SetTexture("_TTex", ww.texture);
        // getimage();
    }
    void getimage()
    {
        if (path != null)
        {
            updateimg();
        }
    }

    void updateimg()
    {
        //  AssetPostprocessor aa=new AssetPostprocessor();
        // TextureImporter textureImporter = (TextureImporter)  aa.assetImporter;
        // textureImporter.npotScale = TextureImporterNPOTScale.None;
        //TextureImporter textureImporter = (TextureImporter)assetImporter;
        //   textureImporter.npotScale = TextureImporterNPOTScale.None;
        //  textureImporter.textureShape = TextureImporterShape.TextureCube;

        //  string pah = AssetDatabase.GetAssetPath(ww.texture);


        // = ww.texture;
        //  m.SetTexture("_Tex", ww.texture);
        //  ww.texture.dimension = TextureDimension.Cube;

        //  Cubemap tex = Resources.Load("mat1") as Cubemap;
        //ww.texture.dimension = tex.dimension;
        //   Texture textures = Selection.GetFiltered(typeof(Texture), SelectionMode.Assets).Cast<Texture>();
        // foreach (var tex in ww.texture)
        //{
        //    //  Texture path
        //    string path = AssetDatabase.GetAssetPath(ww.texture);


        //    // If the texture dimensions is not "Cube", we convert it
        //    TextureImporter importer = (TextureImporter) TextureImporter.GetAtPath(path);
        //    if (ww.texture.dimension != UnityEngine.Rendering.TextureDimension.Cube)
        //    {
        //        importer.textureShape = TextureImporterShape.TextureCube;
        //        importer.SaveAndReimport();
        //    }
        //}
        //path = @"C:\Users\Root\Documents\Allavsoft\8-Puzzle-Game-master\un1\Assets\mat1.jpg";



        //        Texture t;
        //     t = ww.texture;
        // string pah = AssetDatabase.GetAssetPath(t);


        //   TextureImporter importer = ww.texture as TextureImporter;
        // importer.textureShape = TextureImporterShape.TextureCube;
        // importer.SaveAndReimport();
        //   t.Equals(ww.texture);


        // string path1 = AssetDatabase.GetAssetPath(ww.texture);

        //TextureImporter importer = (TextureImporter)TextureImporter.GetAtPath(path1);
        //  importer.wrapMode = TextureWrapMode.Clamp;
        //importer.textureType = TextureImporterType.Advanced;
        //importer.mipmapEnabled = false;
        //importer.maxTextureSize = 2048;
        //importer.textureFormat = TextureImporterFormat.PVRTC_RGB4;

        //TextureImporterSettings tis = new TextureImporterSettings();
        //importer.ReadTextureSettings(tis);
        //tis.ApplyTextureType(TextureImporterType.Advanced, false);
        //  importer.textureShape = TextureImporterShape.TextureCube;
        // AssetDatabase.ImportAsset(path1, ImportAssetOptions.ForceUpdate);


        // image.texture = ww.texture;
    }
    //void OnPostprocessTexture(Texture2D texture)
    //{
    //    TextureImporter importer = assetImporter as TextureImporter;
    //    importer.anisoLevel = 0;
    //    importer.filterMode = FilterMode.Trilinear;

    //    Object asset = AssetDatabase.LoadAssetAtPath(importer.assetPath, typeof(Texture2D));
    //    if (asset)
    //    {
    //        EditorUtility.SetDirty(asset);
    //    }
    //    else
    //    {
    //        texture.anisoLevel = 0;
    //        texture.filterMode = FilterMode.Trilinear;
    //    }
    //}



}












//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;

//public class change : AssetPostprocessor
//{

//    // Start is called before the first frame update
//    void OnPostprocessTexture(Texture2D texture)
//    {
//        TextureImporter textureImporter = (TextureImporter)assetImporter;
//        textureImporter.npotScale = TextureImporterNPOTScale.None;
//    }

//}






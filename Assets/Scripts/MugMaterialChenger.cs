using UnityEngine;

public class MugMaterialChenger : MonoBehaviour
{
    /// <summary>
    /// "îzóÒ"ÇÕç≈èâÇ…óvëfÇÃêîÇåàÇﬂÇÈ
    /// </summary>
    private Color[] MugColors
        = new Color[3];

    private Color[] MugLiquidColors
       = new Color[3]
       {
           Color.cyan,
           Color.green,
           Color.white
       };
    enum LiquidName
    {
        ButterflyPea=0,
        GreenTea,
        Milk
    }
    enum MugColorsName
    {
        MugColorBlack = 0,
        MugColorWhite,
        MugColorRed,
    }
    enum MugParts
    {
        MugBody= 0,
        MugLiquid=1,
        MugHandle =2,
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MugColors[(int)MugColorsName.MugColorBlack]
            = Color.black;

        MugColors[(int)MugColorsName.MugColorWhite] 
            = Color.white;

        MugColors[(int)MugColorsName.MugColorRed] 
            = Color.red;

       // SetMaterials(MugTyeps.BlackMugWithGreenTea);
    }
   

   public enum MugTypes
    {
        BlackMugWithMilk,
        BlackMugWithGreenTea,
        BlackMugWithButterflyPea,
        WhiteMugWithMilk,
        WhiteMugWithGreenTea,
        WhiteMugWithButterflyPea,
        RedMugWithMilk,
        RedMugWithGreenTea,
        RedMugWithButterflyPea,

       TypeMax
    }
    /// <summary>
    /// åªéûì_Ç≈ÇÃMugTyep
    /// </summary>
    public MugTypes CurrentMugType =
        MugTypes.BlackMugWithMilk;

    public void NextSetMaterials()
    {
        int MugTypeNum =(int)CurrentMugType;
        MugTypeNum++;
        if (MugTypeNum >=(int)MugTypes.TypeMax) {
            MugTypeNum = 0;
            }
        SetMaterials((MugTypes)MugTypeNum);
    }
    public void SetMaterials(MugTypes mugTypes)
    {
        CurrentMugType = mugTypes;
        var renderer =
            this.gameObject.GetComponent<MeshRenderer>();
        switch (mugTypes)
        {
            case MugTypes.BlackMugWithMilk:
                renderer.materials[(int)MugParts.MugBody].color =
           MugColors[(int)MugColorsName.MugColorBlack];

                renderer.materials[(int)MugParts.MugLiquid].color =
                   MugLiquidColors[(int)LiquidName.Milk];

                renderer.materials[(int)MugParts.MugHandle].color =
                    MugColors[(int)MugColorsName.MugColorBlack];
                break;

            case MugTypes.BlackMugWithGreenTea:
                renderer.materials[(int)MugParts.MugBody].color =
         MugColors[(int)MugColorsName.MugColorBlack];

                renderer.materials[(int)MugParts.MugLiquid].color =
                   MugLiquidColors[(int)LiquidName.GreenTea];

                renderer.materials[(int)MugParts.MugHandle].color =
                    MugColors[(int)MugColorsName.MugColorBlack];
                break;

            case MugTypes.BlackMugWithButterflyPea:
                renderer.materials[(int)MugParts.MugBody].color =
         MugColors[(int)MugColorsName.MugColorBlack];

                renderer.materials[(int)MugParts.MugLiquid].color =
                   MugLiquidColors[(int)LiquidName.ButterflyPea];

                renderer.materials[(int)MugParts.MugHandle].color =
                    MugColors[(int)MugColorsName.MugColorBlack];
                break;

            case MugTypes.WhiteMugWithMilk:
                renderer.materials[(int)MugParts.MugBody].color =
           MugColors[(int)MugColorsName.MugColorWhite];

                renderer.materials[(int)MugParts.MugLiquid].color =
                   MugLiquidColors[(int)LiquidName.Milk];

                renderer.materials[(int)MugParts.MugHandle].color =
                    MugColors[(int)MugColorsName.MugColorWhite];
                break;

            case MugTypes.WhiteMugWithGreenTea:
                renderer.materials[(int)MugParts.MugBody].color =
           MugColors[(int)MugColorsName.MugColorWhite];

                renderer.materials[(int)MugParts.MugLiquid].color =
                   MugLiquidColors[(int)LiquidName.GreenTea];

                renderer.materials[(int)MugParts.MugHandle].color =
                    MugColors[(int)MugColorsName.MugColorWhite];
                break;

            case MugTypes.WhiteMugWithButterflyPea:
                renderer.materials[(int)MugParts.MugBody].color =
           MugColors[(int)MugColorsName.MugColorWhite];

                renderer.materials[(int)MugParts.MugLiquid].color =
                   MugLiquidColors[(int)LiquidName.ButterflyPea];

                renderer.materials[(int)MugParts.MugHandle].color =
                    MugColors[(int)MugColorsName.MugColorWhite];
                break;

            case MugTypes.RedMugWithMilk:
                renderer.materials[(int)MugParts.MugBody].color =
           MugColors[(int)MugColorsName.MugColorRed];

                renderer.materials[(int)MugParts.MugLiquid].color =
                   MugLiquidColors[(int)LiquidName.Milk];

                renderer.materials[(int)MugParts.MugHandle].color =
                    MugColors[(int)MugColorsName.MugColorRed];
                break;

            case MugTypes.RedMugWithGreenTea:
                renderer.materials[(int)MugParts.MugBody].color =
           MugColors[(int)MugColorsName.MugColorRed];

                renderer.materials[(int)MugParts.MugLiquid].color =
                   MugLiquidColors[(int)LiquidName.GreenTea];

                renderer.materials[(int)MugParts.MugHandle].color =
                    MugColors[(int)MugColorsName.MugColorRed];
                break;

            case MugTypes.RedMugWithButterflyPea:
                renderer.materials[(int)MugParts.MugBody].color =
           MugColors[(int)MugColorsName.MugColorRed];

                renderer.materials[(int)MugParts.MugLiquid].color =
                   MugLiquidColors[(int)LiquidName.ButterflyPea];

                renderer.materials[(int)MugParts.MugHandle].color =
                    MugColors[(int)MugColorsName.MugColorRed];
                break;
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;

public static class GClass6
{
    public static Image smethod_0(this Image image_0, float float_0, float float_1, float float_2, float float_3)
    {
        Bitmap image = new Bitmap(image_0.Width, image_0.Height);
        ImageAttributes imageAttr = new ImageAttributes();
        float[][] newColorMatrix = new float[5][];
        float[] singleArray1 = new float[5];
        singleArray1[0] = float_0;
        newColorMatrix[0] = singleArray1;
        float[] singleArray2 = new float[5];
        singleArray2[1] = float_1;
        newColorMatrix[1] = singleArray2;
        float[] singleArray3 = new float[5];
        singleArray3[2] = float_2;
        newColorMatrix[2] = singleArray3;
        float[] singleArray4 = new float[5];
        singleArray4[3] = 1f;
        newColorMatrix[3] = singleArray4;
        float[] singleArray5 = new float[5];
        singleArray5[4] = 1f;
        newColorMatrix[4] = singleArray5;
        ColorMatrix matrix = new ColorMatrix(newColorMatrix);
        imageAttr.ClearColorMatrix();
        imageAttr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
        imageAttr.SetGamma(float_3, ColorAdjustType.Bitmap);
        using (Graphics graphics = Graphics.FromImage(image))
        {
            graphics.DrawImage(image_0, new Rectangle(0, 0, image_0.Width, image_0.Height), 0, 0, image_0.Width, image_0.Height, GraphicsUnit.Pixel, imageAttr);
        }
        return image;
    }
}


using System;
using System.IO;
using System.Windows.Media.Media3D;
using WpfControlLibrary4;

namespace WindowsFormsApp1.manager
{
    internal static class Core
    {

        public static byte[] ReadFile(string filePath)
        {
            if (filePath == "")
            {
                return new byte[0];
            }
            return File.ReadAllBytes(filePath);
        }
        public static Model3DGroup Convert3models(Models currentModel)
        {
            Model3DGroup tempModel;
            switch (currentModel.Ext.ToLower())
            {
                case ".obj":
                    tempModel = Visor3D.Byte2obj(currentModel.DataBytes);
                    break;
                case ".stl":
                    tempModel = Visor3D.Byte2stl(currentModel.DataBytes);
                    break;
                case ".3ds":
                    tempModel = Visor3D.Byte2studio3d(currentModel.DataBytes);
                    break;
                default:
                    throw new NotSupportedException("tipo de archivo no soportado.");
            }
            return tempModel;
        }
    }

    public static class ByteConverter
    {
        public static string ConvertBytesToReadableSize(long byteCount)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = byteCount;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }
            return $"{len:0.##} {sizes[order]}";
        }
    }
}

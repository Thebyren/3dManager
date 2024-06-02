using System;
using System.IO;
using System.Windows.Media.Media3D;

namespace WpfControlLibrary4
{
    public class Visor3D
    {
        public static Model3DGroup Byte2obj(byte[] bytesData)
        {
            if (bytesData is null)
            {
                Console.WriteLine("error por bytes vacios", nameof(bytesData));
                throw new ArgumentNullException(nameof(bytesData));
            }
            var importer = new HelixToolkit.Wpf.ObjReader();
            Model3DGroup modelObject;
            using (var stream = new MemoryStream(bytesData))
            {
                modelObject = importer.Read(stream);
            }
            return modelObject;
        }
        public static Model3DGroup Byte2stl(byte[] bytesData)
        {
            if (bytesData is null)
            {
                Console.WriteLine("error por bytes vacios", nameof(bytesData));

                throw new ArgumentNullException(nameof(bytesData));
            }
            var importer = new HelixToolkit.Wpf.StLReader();
            Model3DGroup modelObject;
            using (var stream = new MemoryStream(bytesData))
            {
                modelObject = importer.Read(stream);
            }
            return modelObject;
        }
        public static Model3DGroup Byte2studio3d(byte[] bytesData)
        {
            if (bytesData is null)
            {
                Console.WriteLine("error por bytes vacios", nameof(bytesData));

                throw new ArgumentNullException(nameof(bytesData));
            }
            var importer = new HelixToolkit.Wpf.StudioReader();
            Model3DGroup modelObject;
            using (var stream = new MemoryStream(bytesData))
            {
                modelObject = importer.Read(stream);
            }
            return modelObject;
        }
    }
}

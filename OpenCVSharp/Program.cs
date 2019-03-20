using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;


namespace OpenCVSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmds = Environment.GetCommandLineArgs();

            if (cmds[1] != null)
            {
                string path = cmds[1];
                //元画像のMatオブジェクト作成
                Mat src = GetSrc(path);
                //二値化後画像
                Mat dst = GetClone(src);
                //Canny で二値化処理してグレーと二値化結果をウインドウで表示
                Canny(src, dst);
            }
        }

        static Mat GetSrc(string srcPath)
        {
            Mat src = new Mat(srcPath);
            return src;
        }

        static Mat GetClone(Mat srcImage)
        {
            Mat dst = srcImage.Clone();
            return dst;
        }

        static void Canny(Mat src, Mat dst)
        {
            Cv2.Canny(src, dst, 50, 200);
            Cv2.ImShow("元画像",src);
            Cv2.ImShow("dst", dst);
            Cv2.WaitKey();
            Cv2.DestroyAllWindows();

        }

    }

    

}

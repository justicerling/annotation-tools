using System.Drawing;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1 {
    class Utils {


        private static Dictionary<String, Annotation> annotations = new Dictionary<String, Annotation>();
        public static Boolean Contains(Rectangle rect, Point point) {
            return rect.Contains(point);
        }

        public static void LoadAnnotations() {
            //TODO 加载已有的annotations
        }

        public static Boolean AddAnno( Annotation anno) {
            if (annotations.ContainsKey(anno.Name)) {
                return false;
            } else {
                annotations.Add(anno.Name, anno);
                //保存到文件 TODO
                return true;
            }
        }
    }
}

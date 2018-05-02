using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7.mdPage
{

    public class mdPageMenuItem
    {
        public mdPageMenuItem()
        {
            TargetType = typeof(mdPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public string ImgSrc { get; set; }
    }
}
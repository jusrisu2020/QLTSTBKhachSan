//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaveImageDataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;
    using System.IO;

    public partial class Img
    {
        public int id { get; set; }
        public string Fullname { get; set; }
        public string Paths { get; set; }
        [NotMapped]
        public Image Picture
        {
            get
            {
                if (!string.IsNullOrEmpty(Paths))
                {
                    if (File.Exists(Paths))
                    {
                        return Image.FromFile(Paths);
                    }
                }
                return null;
            }
        }
    }
}

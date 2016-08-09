using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace AI_Solution
{
    public class cl_Data
    {
        public class cl_Color
        {
            public int cl_ColorId { get; set; }
            public String Color { get; set; }
            public virtual List<cl_Emotion> Emotion { get; set; }
        }

        public class cl_Emotion
        {
            public Int32 cl_EmotionId { get; set; }
            public String Emotion { get; set; }
            public Int32 EmotionValue { get; set; }
            public Int32 EmotionPredisposition { get; set; }
        }

        public class cl_ColorContext : DbContext
        {
            public DbSet<cl_Color> db_Colors { get; set; }
            public cl_ColorContext(String name)
                : base(name)
            { }
        }
        public class cl_EmotionContext : DbContext
        {
            public DbSet<cl_Emotion> db_Emotions { get; set; }
              public cl_EmotionContext()
                : base("emotions")
            { }
        }

    }
}

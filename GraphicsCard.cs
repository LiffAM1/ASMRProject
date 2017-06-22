using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraphicsCards
{
    public class GraphicsCard
    {
        public virtual string name { get; set; }
        public virtual string rating { get; set; }
        public virtual string review_date { get; set; }
        public virtual string inter { get; set; }
        public virtual string ram { get; set; }
        public virtual string ram_type { get; set; }
        public virtual string clock_speed { get; set; }
        public virtual string cost_usd { get; set; }
        public virtual string cost_gbp { get; set; }
        public virtual string amazon_link { get; set; }
        public GraphicsCard(string name,string rating,string review_date,string inter,string ram,
            string ram_type,string clock_speed,string cost_usd,string cost_gbp,string amazon_link)
        {
            this.name = name;
            this.rating = rating;
            this.review_date = review_date;
            this.inter = inter;
            this.ram = ram;
            this.ram_type = ram_type;
            this.clock_speed = clock_speed;
            this.cost_usd = cost_usd;
            this.cost_gbp = cost_gbp;
            this.amazon_link = amazon_link;
        }

        public override string ToString()
        {
            return "GraphicsCard[" +
                "name=" + name + "," +
                "rating=" + rating + "," +
                "review_date=" + review_date + "," +
                "interface=" + inter + "," +
                "ram=" + ram + "," +
                "ram_type=" + ram_type + "," +
                "clock_speed=" + clock_speed + "," +
                "cost_usd=" + cost_usd + "," +
                "cost_gbp=" + cost_gbp + "," +
                "amazon_link=" + amazon_link + "]";
        }
    }
}
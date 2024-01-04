namespace THANG_TEST.Models.Weather
{
    public class Weat
    {
        public String name { get; set; }
        public int id { get; set; }
        public int dt { get; set; }
        public clouds clouds { get; set; }
        public Wind wind { get; set; }
        public int visibility { get; set; }
     
        public Main main { get; set; }
        public List<Weathers> weather { get; set; }
        public sys sys { get; set; }
        public coor coor { get; set; }
    }
}

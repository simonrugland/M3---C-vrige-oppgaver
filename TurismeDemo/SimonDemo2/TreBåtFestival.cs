namespace SimonDemo2
{
    public class TreBåtFestival
    {
        public string FestivalNavn { get; set; }
        public string FestivalPlass { get; set; }
        public string FestivalBesøkende { get; set; }

        public string FestivalInfo()
        {
            return FestivalNavn + " " + FestivalPlass + " " + FestivalBesøkende;
        }
    }
}
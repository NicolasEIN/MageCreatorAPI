namespace MageCreatorAPI.Models
{
    public class Magician
    {

        public int id { get ; set; }  
        public string Name { get; set; } = string.Empty;
        public string MagicType { get; set; } = string.Empty;
        public string Specialization {  get; set; } = string.Empty;
    }
}

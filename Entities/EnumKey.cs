namespace RestaurantAPI.Entities
{
    public class EnumKey
    {
        public int Id { get; set; }
        public string Key { get; set; }
    }

    public class EnumValue
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int KeyId { get; set; }
        public EnumKey Key { get; set; }
    }
}

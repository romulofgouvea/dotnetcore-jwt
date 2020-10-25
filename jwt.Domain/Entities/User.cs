namespace jwt.Domain.Entities
{
    public class User : BaseEntity
    {
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}

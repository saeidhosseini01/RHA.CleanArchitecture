namespace RHA.CleanArchitecture.Domain.Entities.BaseEntities
{
    public interface IRootEntity:IBaseEntity
    {
        public long CreateOn { get; set; }
        public long? UpdateOn { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

    }

}

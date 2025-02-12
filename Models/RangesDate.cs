namespace RangeDateApi.Models
{
    public class RangeDate
    {
        public int? Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsValidDate()
        {
            return DateTime.Now > StartDate && DateTime.Now < EndDate;
        }
        public bool IsValidRange()
        {
            if (StartDate == null || EndDate == null)
            {
                return false;
            }

            return StartDate <= EndDate;
        }
    }

}
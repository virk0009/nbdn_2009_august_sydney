using System;
using nothinbutdotnetprep.specifications;

namespace nothinbutdotnetprep.collections
{
    public class LessThanSpecification : ISpecification<Movie>
    {
        readonly DateTime date_time;

        public LessThanSpecification(DateTime date_time)
        {
            this.date_time = date_time;
        }

        public bool is_satisfied_by(Movie item)
        {
            return item.date_published <  date_time;
        }
    }
}
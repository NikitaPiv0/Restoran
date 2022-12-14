namespace Restoran.Mappings
{
    public abstract class MapperBase
    {
        private Dictionary<(Type, Type), object> _mappers;

        protected MapperBase()
        {
            _mappers = new Dictionary<(Type, Type), object>();
        }

        protected void CreateMap<TSource, TDestination>(
            Func<TSource, TDestination> mapper)
                where TSource : class
                where TDestination : class
        {
            if (_mappers.ContainsKey((typeof(TSource), typeof(TDestination))))
            {
                throw new InvalidOperationException(
                    $"Mapper already exists (from <{typeof(TSource)}> to <{typeof(TDestination)}>)");
            }

            _mappers.Add((typeof(TSource), typeof(TDestination)), mapper);
        }

        private Func<TSource, TDestination> GetMapper<TSource, TDestination>()
            where TSource : class
            where TDestination : class
        {
            if (!_mappers.ContainsKey((typeof(TSource), typeof(TDestination))))
            {
                throw new InvalidOperationException(
                    $"Mapper not found (from <{typeof(TSource)}> to <{typeof(TDestination)}>)");
            }

            return (Func<TSource, TDestination>)_mappers[(typeof(TSource), typeof(TDestination))];
        }

        public TDestination Map<TSource, TDestination>(TSource source)
            where TSource : class
            where TDestination : class
        {
            return GetMapper<TSource, TDestination>().Invoke(source);
        }

        public IEnumerable<TDestination> Map<TSource, TDestination>(
            IEnumerable<TSource> source)
                where TSource : class
                where TDestination : class
        {
            return source.Select(GetMapper<TSource, TDestination>());
        }
    }
}

namespace copilot_demo_api
{
    public class EngineeringPartDataAccess
    {
        private readonly List<EngineeringPartDto> _cache = new();

        public EngineeringPartDataAccess()
        {
            _cache.Add(new EngineeringPartDto
            {
                Name = "Part 1".ToUpperInvariant(),
                Description = "A very resilient part",
                MaxToleratedTemperature = 800,
                MinToleratedTemperature = -120
            });
            _cache.Add(new EngineeringPartDto
            {
                Name = "Part 2".ToUpperInvariant(),
                Description = "A very important part",
                MaxToleratedTemperature = 45,
                MinToleratedTemperature = 15
            });
            _cache.Add(new EngineeringPartDto
            {
                Name = "Part 3".ToUpperInvariant(),
                Description = "A very weak part",
                MaxToleratedTemperature = 22,
                MinToleratedTemperature = 18
            });
            _cache.Add(new EngineeringPartDto
            {
                Name = "Part 4".ToUpperInvariant(),
                Description = "A simple part",
                MaxToleratedTemperature = 100,
                MinToleratedTemperature = 0
            });
            _cache.Add(new EngineeringPartDto
            {
                Name = "Part 5".ToUpperInvariant(),
                //a part without description
                MaxToleratedTemperature = 80,
                MinToleratedTemperature = -20
            });
        } 

        public IEnumerable<EngineeringPartDto> Get(string? name)
        {
            if (name != null)
            {
                return _cache.Where(p => p.Name == name);
            }
            return _cache;
        }

        public bool Add(EngineeringPartDto part)
        {
            _cache.Add(part);
            return true;
        }

        public bool Remove(string name)
        {
            var part = _cache.FirstOrDefault(p => p.Name == name);

            if (part != null)
            {
                _cache.Remove(part);
                return true;
            }
            return false;
        }
    }
}

namespace copilot_demo_api
{
    public class EngineeringPartDto
    {
        /// <summary>
        /// Maximum temperature in Celsius the part is designed to withstand
        /// </summary>
        public int MaxToleratedTemperature { get; set; } = 100;
        /// <summary>
        /// Minimum temperature in Celsius the part is designed to withstand
        /// </summary>
        public int MinToleratedTemperature { get; set; } = 0;

        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}

namespace ReportRainfall
{
    public static class MockData
    {
        public static List<RainfallReading> GetMeasured(int count)
        {
            List<RainfallReading> list = new List<RainfallReading>();
            for (int i = 0; i < count; i++)
            {
                RainfallReading rainfallReading = new RainfallReading();
                rainfallReading.DateMeasured = DateTime.Now.AddDays(-count);
                rainfallReading.AmountMeasured = i * 10.5m;
                list.Add(rainfallReading);
            }

            return list;
        }


    }
}

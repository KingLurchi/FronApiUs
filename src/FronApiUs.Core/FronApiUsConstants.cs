namespace FronApiUs.Core;

public class FronApiUsConstants
{
    public static class DataCollection
    {
        public class InverterData
        {
            public const string Cumulation = "CumulationInverterData";
            public const string Common = "CommonInverterData";
            public const string MinMax = "MinMaxInverterData";
            public const string ThreePhase = "3PInverterData";
        }
    }

    public static class Platform
    {
        public const string Hybrid = "Fronius Hybrid";
        public const string NonHybrid = "Fronius Non Hybrid";
    }

    public static class Scope
    {
        public const string Device = "Device";
        public const string System = "System";
    }
}
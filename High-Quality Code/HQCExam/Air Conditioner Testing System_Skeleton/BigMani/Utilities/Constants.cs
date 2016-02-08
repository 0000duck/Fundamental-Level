﻿namespace AirConditionerTestingSystem.Utilities
{
    public static class Constants
    {
        public const string IncorrectPropertyLength = "{0}'s name must be at least {1} symbols long.";

        public const string Noreports = "No reports.";

        public const string Invalidcommand = "Invalid command";

        public const string Status = "Jobs complete: {0:F2}%";

        public const string Incorrectrating = "Energy efficiency rating must be between \"A\" and \"E\".";

        public const string Nonpositive = "{0} must be a positive integer.";

        public const string Duplicate = "An entry for the given model already exists.";

        public const string Nonexist = "The specified entry does not exist.";

        public const string Register = "Air Conditioner model {0} from {1} registered successfully.";

        public const string Test = "Air Conditioner model {0} from {1} tested successfully.";

        public const int ModelMinLength = 1;

        public const int ManufacturerMinLength = 4;

        public const int MinCarVolume = 3;

        public const int MinPlaneElectricity = 150;
    }
}
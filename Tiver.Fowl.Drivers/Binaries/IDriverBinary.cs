﻿namespace Tiver.Fowl.Drivers.Binaries
{
    public interface IDriverBinary
    {
        string DriverBinaryFilename { get; }

        /// <summary>
        /// Checks whether binary exists
        /// </summary>
        /// <returns>Status</returns>
        bool CheckBinaryExists();

        /// <summary>
        /// Get version of binary
        /// </summary>
        /// <returns>Version number or null if binary is not existing</returns>
        string GetExistingBinaryVersion();
    }
}

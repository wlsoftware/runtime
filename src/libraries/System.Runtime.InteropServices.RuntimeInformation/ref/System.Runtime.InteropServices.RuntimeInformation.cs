// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System.Runtime.InteropServices
{
    public enum Architecture
    {
        X86 = 0,
        X64 = 1,
        Arm = 2,
        Arm64 = 3,
        Wasm = 4,
    }
    public readonly partial struct OSPlatform : System.IEquatable<System.Runtime.InteropServices.OSPlatform>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static System.Runtime.InteropServices.OSPlatform Android { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform Browser { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform FreeBSD { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform iOS { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform Linux { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform macOS { get { throw null; } }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Runtime.InteropServices.OSPlatform OSX { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform tvOS { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform watchOS { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform Windows { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform Create(string osPlatform) { throw null; }
        public override bool Equals(object? obj) { throw null; }
        public bool Equals(System.Runtime.InteropServices.OSPlatform other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Runtime.InteropServices.OSPlatform left, System.Runtime.InteropServices.OSPlatform right) { throw null; }
        public static bool operator !=(System.Runtime.InteropServices.OSPlatform left, System.Runtime.InteropServices.OSPlatform right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class RuntimeInformation
    {
        public static string FrameworkDescription { get { throw null; } }
        public static System.Runtime.InteropServices.Architecture OSArchitecture { get { throw null; } }
        public static string OSDescription { get { throw null; } }
        public static System.Runtime.InteropServices.Architecture ProcessArchitecture { get { throw null; } }
        public static string RuntimeIdentifier { get { throw null; } }
        public static bool IsOSPlatform(System.Runtime.InteropServices.OSPlatform osPlatform) { throw null; }
        public static bool IsOSPlatformEarlierThan(System.Runtime.InteropServices.OSPlatform osPlatform, int major) { throw null; }
        public static bool IsOSPlatformEarlierThan(System.Runtime.InteropServices.OSPlatform osPlatform, int major, int minor) { throw null; }
        public static bool IsOSPlatformEarlierThan(System.Runtime.InteropServices.OSPlatform osPlatform, int major, int minor, int build) { throw null; }
        public static bool IsOSPlatformEarlierThan(System.Runtime.InteropServices.OSPlatform osPlatform, int major, int minor, int build, int revision) { throw null; }
        public static bool IsOSPlatformEarlierThan(string platformName) { throw null; }
        public static bool IsOSPlatformOrLater(System.Runtime.InteropServices.OSPlatform osPlatform, int major) { throw null; }
        public static bool IsOSPlatformOrLater(System.Runtime.InteropServices.OSPlatform osPlatform, int major, int minor) { throw null; }
        public static bool IsOSPlatformOrLater(System.Runtime.InteropServices.OSPlatform osPlatform, int major, int minor, int build) { throw null; }
        public static bool IsOSPlatformOrLater(System.Runtime.InteropServices.OSPlatform osPlatform, int major, int minor, int build, int revision) { throw null; }
        public static bool IsOSPlatformOrLater(string platformName) { throw null; }
    }
}

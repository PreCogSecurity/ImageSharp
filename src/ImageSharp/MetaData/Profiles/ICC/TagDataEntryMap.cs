// Copyright (c) Six Labors and contributors. Licensed under the Apache License, Version 2.0.

using System.Collections.Generic;

namespace SixLabors.ImageSharp.MetaData.Profiles.Icc
{
    /// <summary>
    /// Shared mapping of ICC tag data entry type signatures ensuring consistency between IccDataReader and IccDataWriter.
    /// The switch cases in ReadTagDataEntry and WriteTagDataEntry should remain in sync with the supported signatures below.
    /// </summary>
    internal static class TagDataEntryMap
    {
        /// <summary>
        /// All ICC tag data entry signatures that have dedicated read/write handlers.
        /// </summary>
        internal static readonly ISet<IccTypeSignature> SupportedSignatures =
            new HashSet<IccTypeSignature>
            {
                IccTypeSignature.Chromaticity,
                IccTypeSignature.ColorantOrder,
                IccTypeSignature.ColorantTable,
                IccTypeSignature.Curve,
                IccTypeSignature.Data,
                IccTypeSignature.DateTime,
                IccTypeSignature.Lut16,
                IccTypeSignature.Lut8,
                IccTypeSignature.LutAToB,
                IccTypeSignature.LutBToA,
                IccTypeSignature.Measurement,
                IccTypeSignature.MultiLocalizedUnicode,
                IccTypeSignature.MultiProcessElements,
                IccTypeSignature.NamedColor2,
                IccTypeSignature.ParametricCurve,
                IccTypeSignature.ProfileSequenceDesc,
                IccTypeSignature.ProfileSequenceIdentifier,
                IccTypeSignature.ResponseCurveSet16,
                IccTypeSignature.S15Fixed16Array,
                IccTypeSignature.Signature,
                IccTypeSignature.Text,
                IccTypeSignature.U16Fixed16Array,
                IccTypeSignature.UInt16Array,
                IccTypeSignature.UInt32Array,
                IccTypeSignature.UInt64Array,
                IccTypeSignature.UInt8Array,
                IccTypeSignature.ViewingConditions,
                IccTypeSignature.Xyz,

                // V2 Types:
                IccTypeSignature.TextDescription,
                IccTypeSignature.CrdInfo,
                IccTypeSignature.Screening,
                IccTypeSignature.UcrBg
            };
    }
}
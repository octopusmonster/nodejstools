﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System;
using System.Drawing;

namespace Microsoft.NodejsTools.NpmUI {
    /// <summary>
    /// Useful functionality for handling and manipulating colors.
    /// </summary>
    public sealed class ColorUtils {
        private static readonly Random _sRandom = new Random();

        private ColorUtils() {}

        /// <summary>
        /// Creates a color that is a mixture of the two specified colors in the
        /// proportions specified.
        /// </summary>
        /// <param name="color1">First color.</param>
        /// <param name="color2">Second color.</param>
        /// <param name="parts1">Number of parts of first color to be mixed.</param>
        /// <param name="parts2">Number of parts of second color to be mixed.</param>
        /// <returns>Mixed color.</returns>
        public static Color Mix(
            Color color1,
            Color color2,
            int parts1,
            int parts2){
            if (parts1 < 0) {
                throw new ArgumentOutOfRangeException(
                    "parts1",
                    parts1,
                    string.Format(
                        "{0} is not a valid value for parts1.",
                        parts1));
            } else if (parts2 < 0) {
                throw new ArgumentOutOfRangeException(
                    "parts2",
                    parts2,
                    string.Format(
                        "{0} is not a valid value for parts2.",
                        parts2));
            }
            int total = parts1 + parts2;
            if (0 == total) {   //  Should never happen
                total = 2;
            }
            int alpha = (color1.A * parts1 + color2.A * parts2) / total;
            if (alpha < 0) {
                alpha = 0;
            }
            return Color.FromArgb(
                alpha,
                (color1.R * parts1 + color2.R * parts2) / total,
                (color1.G * parts1 + color2.G * parts2) / total,
                (color1.B * parts1 + color2.B * parts2) / total);
        }

        public static Color GetRandomColor() {
            return Color.FromArgb(
                255,
                _sRandom.Next(256),
                _sRandom.Next(256),
                _sRandom.Next(256));
        }

        public static Color GetRandomNormalisedColor() {
            return Normalise(GetRandomColor());
        }

        public static Color GetBrightishRandomNormalizedColor() {
            Color color = GetRandomNormalisedColor();
            while (color.GetBrightness() < 0.90) {
                color = Lighter(color);
            }
            return color;
        }

        public static Color Normalise(Color source) {
            int max = Math.Max(Math.Max(source.R, source.G), source.B);
            float factor = 255F / max;
            return Color.FromArgb(
                source.A,
                (int) (source.R * factor),
                (int) (source.G * factor),
                (int) (source.B * factor));
        }

        /// <summary>
        /// Creates a color that is a mixture of the two specified colors in the
        /// proportions specified.
        /// </summary>
        /// <param name="color1">First color.</param>
        /// <param name="color2">Second color.</param>
        /// <param name="parts1">Number of parts of first color to be mixed.</param>
        /// <param name="parts2">Number of parts of second color to be mixed.</param>
        /// <returns>Mixed color.</returns>
        public static Color MixAndNormalise(
            Color color1,
            Color color2,
            int parts1,
            int parts2) {
            return Normalise(Mix(color1, color2, parts1, parts2));
        }

        /// <summary>
        /// Gets a color that is represents an equal mixture of the A, R, G,
        /// and B components of the supplied color.
        /// </summary>
        /// <param name="color1">First color.</param>
        /// <param name="color2">Second color.</param>
        /// <returns>Color halfway between the two supplied color.</returns>
        public static Color MidPoint(Color color1, Color color2) {
            return Color.FromArgb(
                (color1.A + color2.A) / 2,
                (color1.R + color2.R) / 2,
                (color1.G + color2.G) / 2,
                (color1.B + color2.B) / 2);
        }

        /// <summary>
        /// Gets a color that is halfway between the supplied color and white.
        /// Preserves any alpha value in supplied color.
        /// </summary>
        /// <param name="source">Source color.</param>
        /// <returns>Color halfway between supplied color and white.</returns>
        public static Color Lighter(Color source) {
            return MidPoint(
                source,
                Color.FromArgb(
                    source.A,
                    Color.White.R,
                    Color.White.G,
                    Color.White.B));
        }

        /// <summary>
        /// Gets a color that is halfway between the supplied color and black.
        /// Preserves any alpha value in supplied color.
        /// </summary>
        /// <param name="source">Source color.</param>
        /// <returns>Color halfway between supplied color and white.</returns>
        public static Color Darker(Color source) {
            return MidPoint(
                source,
                Color.FromArgb(
                    source.A,
                    Color.Black.R,
                    Color.Black.G,
                    Color.Black.B));
        }
    }
}
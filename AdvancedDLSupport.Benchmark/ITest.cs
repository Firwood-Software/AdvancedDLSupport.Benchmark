﻿//
//  ITest.cs
//
//  Copyright (c) 2018 Firwood Software
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

namespace AdvancedDLSupport.Benchmark
{
    /// <summary>
    /// Represents an interface to a native library, providing <see cref="Matrix2"/> inversion math.
    /// </summary>
    public interface ITest
    {
        /// <summary>
        /// Inverts a given by-reference <see cref="Matrix2"/>.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        void InvertMatrixByPtr(ref Matrix2 matrix);

        /// <summary>
        /// Inverts a given by-value <see cref="Matrix2"/>.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>The inverted matrix.</returns>
        Matrix2 InvertMatrixByValue(Matrix2 matrix);
    }
}

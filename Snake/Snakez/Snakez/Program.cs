/* Copyright (c) 2009 Extron Productions.
 *  
 * This file is part of Snakez.
 * 
 * Snakez is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * any later version.
 * 
 * Snakez is distributed in the hope that it will be useful,
 * but WITHOUT WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with Snakez.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;

namespace Snakez
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Snakez game = new Snakez())
            {
                game.Run();
            }
        }
    }
}


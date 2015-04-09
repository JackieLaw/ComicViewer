﻿//-------------------------------------------------------------------------------------
//  Copyright 2012 Rutger Spruyt
//
//  This file is part of C# Comicviewer.
//
//  csharp comicviewer is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  csharp comicviewer is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with csharp comicviewer.  If not, see <http://www.gnu.org/licenses/>.
//-------------------------------------------------------------------------------------
namespace CSharpComicLoader.File
{
	/// <summary>
	/// Interface for the required from a file load.
	/// </summary>
	public interface IFileLoader
	{
		/// <summary>
		/// Loads the comic book.
		/// </summary>
		/// <param name="files">The files.</param>
		/// <returns></returns>
		LoadedFilesData LoadComicBook(string[] files);
	}
}

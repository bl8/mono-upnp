// 
// Person.cs
//  
// Author:
//       Scott Peterson <lunchtimemama@gmail.com>
// 
// Copyright (c) 2009 Scott Peterson
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Xml;

namespace Mono.Upnp.ContentDirectory.Av
{
	public class Person : Container
	{
		protected Person ()
		{
		}
		
		public string Language { get; private set; }
		
		public Results<Album> BrowseAlbums ()
		{
			return BrowseAlbums (null);
		}
		
		public Results<Album> BrowseAlbums (ResultsSettings settings)
		{
			return Browse<Album> (settings);
		}
		
		public Results<Item> BrowseItems ()
		{
			return BrowseItems (null);
		}
		
		public Results<Item> BrowseItems (ResultsSettings settings)
		{
			return Browse<Item> (settings);
		}
		
		protected override void DeserializePropertyElement (XmlReader reader)
		{
			if (reader == null) throw new ArgumentNullException ("reader");
			
			if (reader.NamespaceURI == Schemas.DublinCoreSchema && reader.Name == "language") {
				Language = reader.ReadString ();
			} else {
				base.DeserializePropertyElement (reader);
			}
		}
	}
}

<<<<<<< HEAD
﻿using System;
using UnityEngine;

public class Readme : ScriptableObject {
	public Texture2D icon;
	public string title;
	public Section[] sections;
	public bool loadedLayout;
	
	[Serializable]
	public class Section {
		public string heading, text, linkText, url;
	}
}
=======
﻿using System;
using UnityEngine;

public class Readme : ScriptableObject {
	public Texture2D icon;
	public string title;
	public Section[] sections;
	public bool loadedLayout;
	
	[Serializable]
	public class Section {
		public string heading, text, linkText, url;
	}
}
>>>>>>> 70a0f9f16ad177f4b21438af99ef17e541da6143

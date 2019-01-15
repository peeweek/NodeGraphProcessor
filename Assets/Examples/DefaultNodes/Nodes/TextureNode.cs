using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GraphProcessor;
using System.Linq;

[System.Serializable, NodeMenuItem("Prana/Texture")]
public class TextureNode : BaseNode
{
	[Output(name = "Texture"), SerializeField]
	public Texture			output;

	public override string		name => "Texture";
}

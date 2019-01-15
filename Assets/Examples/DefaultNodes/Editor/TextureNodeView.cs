using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.UIElements;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine.Experimental.UIElements;
using GraphProcessor;

[NodeCustomEditor(typeof(TextureNode))]
public class TextureNodeView : BaseNodeView
{
	public override void Enable()
	{
		var textureNode = nodeTarget as TextureNode;

        var objField = new ObjectField
        {
			objectType = typeof(Texture),
			allowSceneObjects = false,
            value = textureNode.output,
        };

		var preview = new Image();

		objField.OnValueChanged(v => {
			textureNode.output = objField.value as Texture;
			UpdatePreviewImage(preview, objField.value);
		});

		UpdatePreviewImage(preview, textureNode.output);

		controlsContainer.Add(objField);
		controlsContainer.Add(preview);
	}

	void UpdatePreviewImage(Image image, Object obj)
	{
        image.image = (Texture)obj;
	}
}
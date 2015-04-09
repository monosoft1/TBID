Shader "Custom/Vertex Coloured" 
{
	Properties 
	{
		_MainTex ("Base (RGB) Alpha (A)", 2D) = "white"{}		
	}
	
	Category
	{
		Lighting on
		ZWrite on
		Cull back
		Blend SrcAlpha OneMinusSrcAlpha

		 BindChannels {
	        Bind "Color", color
	        Bind "Vertex", vertex
	        Bind "TexCoord", texcoord
	    }

		SubShader 
		{
			Pass
			{ 	
				ColorMaterial AmbientAndDiffuse
				
				SetTexture[_MainTex]
				{					
           			Combine texture * primary DOUBLE, texture * primary
				}         
			}			
		}
	} 
}
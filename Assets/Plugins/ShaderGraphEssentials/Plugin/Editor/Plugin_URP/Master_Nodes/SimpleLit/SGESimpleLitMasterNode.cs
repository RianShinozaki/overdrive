﻿//
// ShaderGraphEssentials for Unity
// (c) 2019 PH Graphics
// Source code may be used and modified for personal or commercial projects.
// Source code may NOT be redistributed or sold.
// 
// *** A NOTE ABOUT PIRACY ***
// 
// If you got this asset from a pirate site, please consider buying it from the Unity asset store. This asset is only legally available from the Unity Asset Store.
// 
// I'm a single indie dev supporting my family by spending hundreds and thousands of hours on this and other assets. It's very offensive, rude and just plain evil to steal when I (and many others) put so much hard work into the software.
// 
// Thank you.
//
// *** END NOTE ABOUT PIRACY ***
//

using UnityEditor.ShaderGraph;
using UnityEditor.ShaderGraph.Legacy;
using RenderQueue = UnityEditor.ShaderGraph.RenderQueue;

namespace ShaderGraphEssentials.Legacy
{
    [FormerName("ShaderGraphEssentials.SGESimpleLitMasterNode")]
    class SGESimpleLitMasterNode1 : AbstractMaterialNode, IMasterNode1
    {
        public RenderType m_renderType;
        public RenderQueue m_renderQueue;
        public BlendMode m_blendMode;
        public CullMode m_cullMode;
        public ZWrite m_zwrite;
        public ZTest m_ztest;
        public NormalDropOffSpace m_NormalDropOffSpace;
        public string m_customEditor;
    }
}

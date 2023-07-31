//
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

namespace ShaderGraphEssentials
{
    public static class SGEShaderUtils
    {
        internal enum SGEShaderID
        {
            // ShaderGraph IDs start at 1000, correspond to subtargets
            //SG_Unlit = 1000,        // UniversalUnlitSubTarget
            //SG_Lit,                 // UniversalLitSubTarget

            // we start much higher
            SGE_SimpleLit = 1030,
            SGE_CustomLit,
            SGE_Unlit,
        }
    }
}
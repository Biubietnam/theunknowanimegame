using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E58 RID: 3672
	public static class RogueCommonMiracleReflection
	{
		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x0600A3D4 RID: 41940 RVA: 0x001B88E6 File Offset: 0x001B6AE6
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonMiracleReflection.descriptor;
			}
		}

		// Token: 0x04004307 RID: 17159
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSb2d1ZUNvbW1vbk1pcmFjbGUucHJvdG8aFkdhbWVSb2d1ZU1pcmFjbGUu" + "cHJvdG8iPQoSUm9ndWVDb21tb25NaXJhY2xlEicKDG1pcmFjbGVfaW5mbxgE" + "IAEoCzIRLkdhbWVSb2d1ZU1pcmFjbGVCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			GameRogueMiracleReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonMiracle), RogueCommonMiracle.Parser, new string[]
			{
				"MiracleInfo"
			}, null, null, null, null)
		}));
	}
}

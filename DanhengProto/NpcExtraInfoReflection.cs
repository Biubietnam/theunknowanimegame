using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C2E RID: 3118
	public static class NpcExtraInfoReflection
	{
		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x06008A32 RID: 35378 RVA: 0x0016CE25 File Offset: 0x0016B025
		public static FileDescriptor Descriptor
		{
			get
			{
				return NpcExtraInfoReflection.descriptor;
			}
		}

		// Token: 0x040034FF RID: 13567
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJOcGNFeHRyYUluZm8ucHJvdG8aEVBHSU1GT0ZEUEdGLnByb3RvGhZOcGNS",
			"b2d1ZUdhbWVJbmZvLnByb3RvGhFNRkRISU5OTkVHTC5wcm90byKAAQoMTnBj",
			"RXh0cmFJbmZvEioKD3JvZ3VlX2dhbWVfaW5mbxgPIAEoCzIRLk5wY1JvZ3Vl",
			"R2FtZUluZm8SIQoLUEdKS0dMREFCTUwYAiABKAsyDC5QR0lNRk9GRFBHRhIh",
			"CgtOTkxJR0dIRUJGUBgKIAEoCzIMLk1GREhJTk5ORUdMQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PGIMFOFDPGFReflection.Descriptor,
			NpcRogueGameInfoReflection.Descriptor,
			MFDHINNNEGLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(NpcExtraInfo), NpcExtraInfo.Parser, new string[]
			{
				"RogueGameInfo",
				"PGJKGLDABML",
				"NNLIGGHEBFP"
			}, null, null, null, null)
		}));
	}
}

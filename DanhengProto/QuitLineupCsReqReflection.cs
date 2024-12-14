using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D4A RID: 3402
	public static class QuitLineupCsReqReflection
	{
		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x06009802 RID: 38914 RVA: 0x00194F76 File Offset: 0x00193176
		public static FileDescriptor Descriptor
		{
			get
			{
				return QuitLineupCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003B18 RID: 15128
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVRdWl0TGluZXVwQ3NSZXEucHJvdG8aFUV4dHJhTGluZXVwVHlwZS5wcm90",
			"bxoQQXZhdGFyVHlwZS5wcm90byKtAQoPUXVpdExpbmV1cENzUmVxEiAKC2F2",
			"YXRhcl90eXBlGAsgASgOMgsuQXZhdGFyVHlwZRIWCg5iYXNlX2F2YXRhcl9p",
			"ZBgFIAEoDRISCgppc192aXJ0dWFsGAIgASgIEisKEWV4dHJhX2xpbmV1cF90",
			"eXBlGAEgASgOMhAuRXh0cmFMaW5ldXBUeXBlEhAKCHBsYW5lX2lkGAcgASgN",
			"Eg0KBWluZGV4GAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ExtraLineupTypeReflection.Descriptor,
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(QuitLineupCsReq), QuitLineupCsReq.Parser, new string[]
			{
				"AvatarType",
				"BaseAvatarId",
				"IsVirtual",
				"ExtraLineupType",
				"PlaneId",
				"Index"
			}, null, null, null, null)
		}));
	}
}

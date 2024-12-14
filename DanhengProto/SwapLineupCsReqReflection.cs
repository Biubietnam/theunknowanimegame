using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001210 RID: 4624
	public static class SwapLineupCsReqReflection
	{
		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x0600CEB4 RID: 52916 RVA: 0x0022A53C File Offset: 0x0022873C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SwapLineupCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400533B RID: 21307
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVTd2FwTGluZXVwQ3NSZXEucHJvdG8aFUV4dHJhTGluZXVwVHlwZS5wcm90",
			"byKdAQoPU3dhcExpbmV1cENzUmVxEg0KBWluZGV4GAsgASgNEhAKCHBsYW5l",
			"X2lkGA8gASgNEhMKC0VQTERGRUZBREtEGA4gASgNEisKEWV4dHJhX2xpbmV1",
			"cF90eXBlGAkgASgOMhAuRXh0cmFMaW5ldXBUeXBlEhIKCmlzX3ZpcnR1YWwY",
			"AyABKAgSEwoLTVBDTkFFRkZQS0IYBCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ExtraLineupTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SwapLineupCsReq), SwapLineupCsReq.Parser, new string[]
			{
				"Index",
				"PlaneId",
				"EPLDFEFADKD",
				"ExtraLineupType",
				"IsVirtual",
				"MPCNAEFFPKB"
			}, null, null, null, null)
		}));
	}
}

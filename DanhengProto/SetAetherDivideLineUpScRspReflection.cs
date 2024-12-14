using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010C6 RID: 4294
	public static class SetAetherDivideLineUpScRspReflection
	{
		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x0600BF82 RID: 49026 RVA: 0x002039AD File Offset: 0x00201BAD
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetAetherDivideLineUpScRspReflection.descriptor;
			}
		}

		// Token: 0x04004DBC RID: 19900
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBTZXRBZXRoZXJEaXZpZGVMaW5lVXBTY1JzcC5wcm90bxocQWV0aGVyRGl2",
			"aWRlTGluZXVwSW5mby5wcm90byJWChpTZXRBZXRoZXJEaXZpZGVMaW5lVXBT",
			"Y1JzcBInCgZsaW5ldXAYDiABKAsyFy5BZXRoZXJEaXZpZGVMaW5ldXBJbmZv",
			"Eg8KB3JldGNvZGUYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			AetherDivideLineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetAetherDivideLineUpScRsp), SetAetherDivideLineUpScRsp.Parser, new string[]
			{
				"Lineup",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}

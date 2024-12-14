using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200003C RID: 60
	public static class AddAvatarScNotifyReflection
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00007CA9 File Offset: 0x00005EA9
		public static FileDescriptor Descriptor
		{
			get
			{
				return AddAvatarScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040000DA RID: 218
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdBZGRBdmF0YXJTY05vdGlmeS5wcm90bxoXQWRkQXZhdGFyU3JjU3RhdGUu",
			"cHJvdG8aDkl0ZW1MaXN0LnByb3RvIncKEUFkZEF2YXRhclNjTm90aWZ5Eh8K",
			"A3NyYxgDIAEoDjISLkFkZEF2YXRhclNyY1N0YXRlEhYKDmJhc2VfYXZhdGFy",
			"X2lkGAcgASgNEg4KBmlzX25ldxgBIAEoCBIZCgZyZXdhcmQYCSABKAsyCS5J",
			"dGVtTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			AddAvatarSrcStateReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AddAvatarScNotify), AddAvatarScNotify.Parser, new string[]
			{
				"Src",
				"BaseAvatarId",
				"IsNew",
				"Reward"
			}, null, null, null, null)
		}));
	}
}

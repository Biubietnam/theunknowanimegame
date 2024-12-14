using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013B8 RID: 5048
	public static class UnlockAvatarPathScRspReflection
	{
		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x0600E115 RID: 57621 RVA: 0x00257166 File Offset: 0x00255366
		public static FileDescriptor Descriptor
		{
			get
			{
				return UnlockAvatarPathScRspReflection.descriptor;
			}
		}

		// Token: 0x0400599C RID: 22940
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtVbmxvY2tBdmF0YXJQYXRoU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3Rv",
			"GhlNdWx0aVBhdGhBdmF0YXJUeXBlLnByb3RvIogBChVVbmxvY2tBdmF0YXJQ",
			"YXRoU2NSc3ASGgoSYmFzaWNfdHlwZV9pZF9saXN0GAogAygNEhkKBnJld2Fy",
			"ZBgJIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUYBCABKA0SJwoJYXZhdGFy",
			"X2lkGA0gASgOMhQuTXVsdGlQYXRoQXZhdGFyVHlwZUIeqgIbRWdnTGluay5E",
			"YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor,
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UnlockAvatarPathScRsp), UnlockAvatarPathScRsp.Parser, new string[]
			{
				"BasicTypeIdList",
				"Reward",
				"Retcode",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}

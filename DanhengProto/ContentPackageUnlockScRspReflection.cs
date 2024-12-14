using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000334 RID: 820
	public static class ContentPackageUnlockScRspReflection
	{
		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x00067AA6 File Offset: 0x00065CA6
		public static FileDescriptor Descriptor
		{
			get
			{
				return ContentPackageUnlockScRspReflection.descriptor;
			}
		}

		// Token: 0x04000EF8 RID: 3832
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db250ZW50UGFja2FnZVVubG9ja1NjUnNwLnByb3RvIkAKGUNvbnRlbnRQ" + "YWNrYWdlVW5sb2NrU2NSc3ASEgoKY29udGVudF9pZBgEIAEoDRIPCgdyZXRj" + "b2RlGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageUnlockScRsp), ContentPackageUnlockScRsp.Parser, new string[]
			{
				"ContentId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}

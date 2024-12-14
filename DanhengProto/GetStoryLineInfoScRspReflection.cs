using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200080E RID: 2062
	public static class GetStoryLineInfoScRspReflection
	{
		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06005BF3 RID: 23539 RVA: 0x000F4782 File Offset: 0x000F2982
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetStoryLineInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x0400238E RID: 9102
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtHZXRTdG9yeUxpbmVJbmZvU2NSc3AucHJvdG8iiAEKFUdldFN0b3J5TGlu",
			"ZUluZm9TY1JzcBIZChFjdXJfc3RvcnlfbGluZV9pZBgCIAEoDRIPCgdyZXRj",
			"b2RlGAogASgNEiUKHXVuZmluaXNoZWRfc3RvcnlfbGluZV9pZF9saXN0GAMg",
			"AygNEhwKFHRyaWFsX2F2YXRhcl9pZF9saXN0GA0gAygNQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetStoryLineInfoScRsp), GetStoryLineInfoScRsp.Parser, new string[]
			{
				"CurStoryLineId",
				"Retcode",
				"UnfinishedStoryLineIdList",
				"TrialAvatarIdList"
			}, null, null, null, null)
		}));
	}
}

using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ED2 RID: 3794
	public static class RogueMagicGameItemInfoReflection
	{
		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x0600A998 RID: 43416 RVA: 0x001C8B80 File Offset: 0x001C6D80
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameItemInfoReflection.descriptor;
			}
		}

		// Token: 0x04004536 RID: 17718
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxSb2d1ZU1hZ2ljR2FtZUl0ZW1JbmZvLnByb3RvGhxSb2d1ZU1hZ2ljR2Ft",
			"ZVVuaXRJbmZvLnByb3RvGh9Sb2d1ZU1hZ2ljR2FtZVNjZXB0ZXJJbmZvLnBy",
			"b3RvIsABChZSb2d1ZU1hZ2ljR2FtZUl0ZW1JbmZvEhMKC0VQS0JBQk5DSkRD",
			"GA8gASgIEjsKF21hZ2ljX3NjZXB0ZXJfaW5mb19saXN0GA4gAygLMhouUm9n",
			"dWVNYWdpY0dhbWVTY2VwdGVySW5mbxIXCg9nYW1lX3N0eWxlX3R5cGUYAyAB",
			"KA0SOwoacm9ndWVfbWFnaWNfdW5pdF9pbmZvX2xpc3QYBiADKAsyFy5Sb2d1",
			"ZU1hZ2ljR2FtZVVuaXRJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueMagicGameUnitInfoReflection.Descriptor,
			RogueMagicGameScepterInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicGameItemInfo), RogueMagicGameItemInfo.Parser, new string[]
			{
				"EPKBABNCJDC",
				"MagicScepterInfoList",
				"GameStyleType",
				"RogueMagicUnitInfoList"
			}, null, null, null, null)
		}));
	}
}

using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000464 RID: 1124
	public static class EnterSceneScRspReflection
	{
		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x00089D6F File Offset: 0x00087F6F
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterSceneScRspReflection.descriptor;
			}
		}

		// Token: 0x040013F5 RID: 5109
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVFbnRlclNjZW5lU2NSc3AucHJvdG8ifQoPRW50ZXJTY2VuZVNjUnNwEhIK",
			"CmNvbnRlbnRfaWQYByABKA0SGgoSZ2FtZV9zdG9yeV9saW5lX2lkGAggASgN",
			"EhMKC2lzX292ZXJfbWFwGAogASgIEhQKDGlzX2Nsb3NlX21hcBgMIAEoCBIP",
			"CgdyZXRjb2RlGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterSceneScRsp), EnterSceneScRsp.Parser, new string[]
			{
				"ContentId",
				"GameStoryLineId",
				"IsOverMap",
				"IsCloseMap",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}

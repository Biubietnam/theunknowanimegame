using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004A8 RID: 1192
	public static class EvolveBuildGiveupScRspReflection
	{
		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x00092EC6 File Offset: 0x000910C6
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildGiveupScRspReflection.descriptor;
			}
		}

		// Token: 0x04001548 RID: 5448
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxFdm9sdmVCdWlsZEdpdmV1cFNjUnNwLnByb3RvGhpFdm9sdmVCdWlsZExl",
			"dmVsSW5mby5wcm90byJUChZFdm9sdmVCdWlsZEdpdmV1cFNjUnNwEg8KB3Jl",
			"dGNvZGUYCCABKA0SKQoKbGV2ZWxfaW5mbxgBIAEoCzIVLkV2b2x2ZUJ1aWxk",
			"TGV2ZWxJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			EvolveBuildLevelInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildGiveupScRsp), EvolveBuildGiveupScRsp.Parser, new string[]
			{
				"Retcode",
				"LevelInfo"
			}, null, null, null, null)
		}));
	}
}

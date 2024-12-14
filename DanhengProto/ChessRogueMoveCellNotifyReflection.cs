using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000248 RID: 584
	public static class ChessRogueMoveCellNotifyReflection
	{
		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x0004C625 File Offset: 0x0004A825
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueMoveCellNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000B2F RID: 2863
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5DaGVzc1JvZ3VlTW92ZUNlbGxOb3RpZnkucHJvdG8aDkNlbGxJbmZvLnBy",
			"b3RvIl0KGENoZXNzUm9ndWVNb3ZlQ2VsbE5vdGlmeRITCgtCUEpPTFBMSEVF",
			"UBgLIAEoDRITCgtOSUFIQkhJR0VJTBgNIAEoDRIXCgRjZWxsGAMgASgLMgku",
			"Q2VsbEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			CellInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueMoveCellNotify), ChessRogueMoveCellNotify.Parser, new string[]
			{
				"BPJOLPLHEEP",
				"NIAHBHIGEIL",
				"Cell"
			}, null, null, null, null)
		}));
	}
}

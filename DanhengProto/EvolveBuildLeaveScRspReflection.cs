using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004AC RID: 1196
	public static class EvolveBuildLeaveScRspReflection
	{
		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x0600357C RID: 13692 RVA: 0x0009342A File Offset: 0x0009162A
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildLeaveScRspReflection.descriptor;
			}
		}

		// Token: 0x04001552 RID: 5458
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtFdm9sdmVCdWlsZExlYXZlU2NSc3AucHJvdG8aGkV2b2x2ZUJ1aWxkTGV2",
			"ZWxJbmZvLnByb3RvIlMKFUV2b2x2ZUJ1aWxkTGVhdmVTY1JzcBIpCgpsZXZl",
			"bF9pbmZvGAcgASgLMhUuRXZvbHZlQnVpbGRMZXZlbEluZm8SDwoHcmV0Y29k",
			"ZRgPIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			EvolveBuildLevelInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildLeaveScRsp), EvolveBuildLeaveScRsp.Parser, new string[]
			{
				"LevelInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}

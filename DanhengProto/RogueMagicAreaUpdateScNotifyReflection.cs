using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EAC RID: 3756
	public static class RogueMagicAreaUpdateScNotifyReflection
	{
		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x0600A7E0 RID: 42976 RVA: 0x001C44B7 File Offset: 0x001C26B7
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicAreaUpdateScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040044A8 RID: 17576
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJSb2d1ZU1hZ2ljQXJlYVVwZGF0ZVNjTm90aWZ5LnByb3RvGhhSb2d1ZU1h",
			"Z2ljQXJlYUluZm8ucHJvdG8iUgocUm9ndWVNYWdpY0FyZWFVcGRhdGVTY05v",
			"dGlmeRIyChVyb2d1ZV90b3Vybl9hcmVhX2luZm8YDiADKAsyEy5Sb2d1ZU1h",
			"Z2ljQXJlYUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueMagicAreaInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicAreaUpdateScNotify), RogueMagicAreaUpdateScNotify.Parser, new string[]
			{
				"RogueTournAreaInfo"
			}, null, null, null, null)
		}));
	}
}

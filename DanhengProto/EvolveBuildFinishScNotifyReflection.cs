using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004A2 RID: 1186
	public static class EvolveBuildFinishScNotifyReflection
	{
		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06003501 RID: 13569 RVA: 0x00092042 File Offset: 0x00090242
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildFinishScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04001527 RID: 5415
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9Fdm9sdmVCdWlsZEZpbmlzaFNjTm90aWZ5LnByb3RvGhpFdm9sdmVCdWls",
			"ZExldmVsSW5mby5wcm90bxoRSEJIRElHT1BETVAucHJvdG8i3QEKGUV2b2x2",
			"ZUJ1aWxkRmluaXNoU2NOb3RpZnkSJgoQQmF0dGxlUmVzdWx0VHlwZRgPIAEo",
			"DjIMLkhCSERJR09QRE1QEgwKBENvaW4YBiABKA0SDQoFU2NvcmUYBSABKA0S",
			"DgoGSXNMb3NlGAggASgIEgwKBFdhdmUYCiABKA0SKAoJTGV2ZWxJbmZvGAMg",
			"ASgLMhUuRXZvbHZlQnVpbGRMZXZlbEluZm8SCwoDRXhwGAsgASgNEg8KB0xl",
			"dmVsSWQYASABKA0SFQoNQ3VyUGVyaW9kVHlwZRgEIAEoDUIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			EvolveBuildLevelInfoReflection.Descriptor,
			HBHDIGOPDMPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildFinishScNotify), EvolveBuildFinishScNotify.Parser, new string[]
			{
				"BattleResultType",
				"Coin",
				"Score",
				"IsLose",
				"Wave",
				"LevelInfo",
				"Exp",
				"LevelId",
				"CurPeriodType"
			}, null, null, null, null)
		}));
	}
}

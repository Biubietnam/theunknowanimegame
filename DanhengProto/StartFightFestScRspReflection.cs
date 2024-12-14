using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011AE RID: 4526
	public static class StartFightFestScRspReflection
	{
		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0600CA28 RID: 51752 RVA: 0x0021E633 File Offset: 0x0021C833
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartFightFestScRspReflection.descriptor;
			}
		}

		// Token: 0x0400518F RID: 20879
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlTdGFydEZpZ2h0RmVzdFNjUnNwLnByb3RvGhVTY2VuZUJhdHRsZUluZm8u",
			"cHJvdG8aE0ZpZ2h0RmVzdFR5cGUucHJvdG8iiQEKE1N0YXJ0RmlnaHRGZXN0",
			"U2NSc3ASJQoLYmF0dGxlX2luZm8YAyABKAsyEC5TY2VuZUJhdHRsZUluZm8S",
			"DwoHcmV0Y29kZRgFIAEoDRIKCgJpZBgPIAEoDRIcCgR0eXBlGAwgASgOMg4u",
			"RmlnaHRGZXN0VHlwZRIQCghldmVudF9pZBgEIAEoDUIeqgIbRWdnTGluay5E",
			"YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor,
			FightFestTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartFightFestScRsp), StartFightFestScRsp.Parser, new string[]
			{
				"BattleInfo",
				"Retcode",
				"Id",
				"Type",
				"EventId"
			}, null, null, null, null)
		}));
	}
}

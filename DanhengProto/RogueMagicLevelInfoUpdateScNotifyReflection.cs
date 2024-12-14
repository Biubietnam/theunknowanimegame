using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EEE RID: 3822
	public static class RogueMagicLevelInfoUpdateScNotifyReflection
	{
		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x0600AACE RID: 43726 RVA: 0x001CC190 File Offset: 0x001CA390
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicLevelInfoUpdateScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040045B5 RID: 17845
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidSb2d1ZU1hZ2ljTGV2ZWxJbmZvVXBkYXRlU2NOb3RpZnkucHJvdG8aHFJv",
			"Z3VlTWFnaWNTZXR0bGVSZWFzb24ucHJvdG8aGVJvZ3VlTWFnaWNMYXllcklu",
			"Zm8ucHJvdG8aG1JvZ3VlTWFnaWNMZXZlbFN0YXR1cy5wcm90byLsAQohUm9n",
			"dWVNYWdpY0xldmVsSW5mb1VwZGF0ZVNjTm90aWZ5EicKBnJlYXNvbhgBIAEo",
			"DjIXLlJvZ3VlTWFnaWNTZXR0bGVSZWFzb24SGQoRZXh0cmFfcm91bmRfbGlt",
			"aXQYDSABKA0SJgoGc3RhdHVzGA8gASgOMhYuUm9ndWVNYWdpY0xldmVsU3Rh",
			"dHVzEi0KD2xldmVsX2luZm9fbGlzdBgDIAMoCzIULlJvZ3VlTWFnaWNMYXll",
			"ckluZm8SEwoLTEFCR0tNUE1CRUQYCSABKA0SFwoPY3VyX2xldmVsX2luZGV4",
			"GAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			RogueMagicSettleReasonReflection.Descriptor,
			RogueMagicLayerInfoReflection.Descriptor,
			RogueMagicLevelStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicLevelInfoUpdateScNotify), RogueMagicLevelInfoUpdateScNotify.Parser, new string[]
			{
				"Reason",
				"ExtraRoundLimit",
				"Status",
				"LevelInfoList",
				"LABGKMPMBED",
				"CurLevelIndex"
			}, null, null, null, null)
		}));
	}
}

using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F34 RID: 3892
	public static class RogueMagicUnitSelectInfoReflection
	{
		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x0600ADA3 RID: 44451 RVA: 0x001D2C16 File Offset: 0x001D0E16
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitSelectInfoReflection.descriptor;
			}
		}

		// Token: 0x040046A8 RID: 18088
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5Sb2d1ZU1hZ2ljVW5pdFNlbGVjdEluZm8ucHJvdG8aGFJvZ3VlTWFnaWNH",
			"YW1lVW5pdC5wcm90byK3AQoYUm9ndWVNYWdpY1VuaXRTZWxlY3RJbmZvEi8K",
			"EnNlbGVjdF9tYWdpY191bml0cxgJIAMoCzITLlJvZ3VlTWFnaWNHYW1lVW5p",
			"dBITCgtPTVBBQUtMTExGRBgCIAEoDRIoCgtOQVBHQ0VDRERCTRgBIAEoCzIT",
			"LlJvZ3VlTWFnaWNHYW1lVW5pdBITCgtBQkhQSUdPR0FDSRgDIAEoDRIWCg5z",
			"ZWxlY3RfaGludF9pZBgPIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueMagicGameUnitReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicUnitSelectInfo), RogueMagicUnitSelectInfo.Parser, new string[]
			{
				"SelectMagicUnits",
				"OMPAAKLLLFD",
				"NAPGCECDDBM",
				"ABHPIGOGACI",
				"SelectHintId"
			}, null, null, null, null)
		}));
	}
}

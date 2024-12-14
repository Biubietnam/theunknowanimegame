using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200003A RID: 58
	public static class ActivityScheduleDataReflection
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00007800 File Offset: 0x00005A00
		public static FileDescriptor Descriptor
		{
			get
			{
				return ActivityScheduleDataReflection.descriptor;
			}
		}

		// Token: 0x040000CF RID: 207
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpBY3Rpdml0eVNjaGVkdWxlRGF0YS5wcm90byJjChRBY3Rpdml0eVNjaGVk" + "dWxlRGF0YRITCgthY3Rpdml0eV9pZBgNIAEoDRIQCghwYW5lbF9pZBgBIAEo" + "DRIQCghlbmRfdGltZRgPIAEoAxISCgpiZWdpbl90aW1lGAYgASgDQh6qAhtF" + "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ActivityScheduleData), ActivityScheduleData.Parser, new string[]
			{
				"ActivityId",
				"PanelId",
				"EndTime",
				"BeginTime"
			}, null, null, null, null)
		}));
	}
}

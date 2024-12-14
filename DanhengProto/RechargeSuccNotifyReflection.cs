using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D86 RID: 3462
	public static class RechargeSuccNotifyReflection
	{
		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x06009A9C RID: 39580 RVA: 0x0019B680 File Offset: 0x00199880
		public static FileDescriptor Descriptor
		{
			get
			{
				return RechargeSuccNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003C05 RID: 15365
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSZWNoYXJnZVN1Y2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnByb3RvInoK",
			"ElJlY2hhcmdlU3VjY05vdGlmeRIRCglQcm9kdWN0SWQYDiABKAkSGwoISXRl",
			"bUxpc3QYBSABKAsyCS5JdGVtTGlzdBIWCg5DaGFubmVsT3JkZXJObxgGIAEo",
			"CRIcChRNb250aENhcmRPdXRkYXRlVGltZRgLIAEoBEIeqgIbRWdnTGluay5E",
			"YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RechargeSuccNotify), RechargeSuccNotify.Parser, new string[]
			{
				"ProductId",
				"ItemList",
				"ChannelOrderNo",
				"MonthCardOutdateTime"
			}, null, null, null, null)
		}));
	}
}

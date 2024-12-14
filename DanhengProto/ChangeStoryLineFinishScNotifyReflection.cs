using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001D0 RID: 464
	public static class ChangeStoryLineFinishScNotifyReflection
	{
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0003BADB File Offset: 0x00039CDB
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChangeStoryLineFinishScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040008B9 RID: 2233
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNDaGFuZ2VTdG9yeUxpbmVGaW5pc2hTY05vdGlmeS5wcm90bxobQ2hhbmdl",
			"U3RvcnlMaW5lQWN0aW9uLnByb3RvIowBCh1DaGFuZ2VTdG9yeUxpbmVGaW5p",
			"c2hTY05vdGlmeRITCgtPTEJPRFBDTkVDRxgHIAEoDRIZChFjdXJfc3Rvcnlf",
			"bGluZV9pZBgDIAEoDRImCgZhY3Rpb24YDiABKA4yFi5DaGFuZ2VTdG9yeUxp",
			"bmVBY3Rpb24SEwoLSE5GTkFFSkRET00YCyABKAhCHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChangeStoryLineActionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChangeStoryLineFinishScNotify), ChangeStoryLineFinishScNotify.Parser, new string[]
			{
				"OLBODPCNECG",
				"CurStoryLineId",
				"Action",
				"HNFNAEJDDOM"
			}, null, null, null, null)
		}));
	}
}

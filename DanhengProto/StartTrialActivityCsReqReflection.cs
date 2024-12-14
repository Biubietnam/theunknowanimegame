using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011D8 RID: 4568
	public static class StartTrialActivityCsReqReflection
	{
		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0600CC3B RID: 52283 RVA: 0x00224311 File Offset: 0x00222511
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartTrialActivityCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400525E RID: 21086
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TdGFydFRyaWFsQWN0aXZpdHlDc1JlcS5wcm90byIrChdTdGFydFRyaWFs" + "QWN0aXZpdHlDc1JlcRIQCghzdGFnZV9pZBgEIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartTrialActivityCsReq), StartTrialActivityCsReq.Parser, new string[]
			{
				"StageId"
			}, null, null, null, null)
		}));
	}
}

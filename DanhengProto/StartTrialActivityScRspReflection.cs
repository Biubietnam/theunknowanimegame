using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011DA RID: 4570
	public static class StartTrialActivityScRspReflection
	{
		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0600CC50 RID: 52304 RVA: 0x0022457E File Offset: 0x0022277E
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartTrialActivityScRspReflection.descriptor;
			}
		}

		// Token: 0x04005263 RID: 21091
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TdGFydFRyaWFsQWN0aXZpdHlTY1JzcC5wcm90byI8ChdTdGFydFRyaWFs" + "QWN0aXZpdHlTY1JzcBIQCghzdGFnZV9pZBgFIAEoDRIPCgdyZXRjb2RlGAog" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartTrialActivityScRsp), StartTrialActivityScRsp.Parser, new string[]
			{
				"StageId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}

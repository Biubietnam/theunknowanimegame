using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000384 RID: 900
	public static class DelSaveRaidScNotifyReflection
	{
		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x0006F737 File Offset: 0x0006D937
		public static FileDescriptor Descriptor
		{
			get
			{
				return DelSaveRaidScNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400101C RID: 4124
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlEZWxTYXZlUmFpZFNjTm90aWZ5LnByb3RvIjsKE0RlbFNhdmVSYWlkU2NO" + "b3RpZnkSDwoHcmFpZF9pZBgPIAEoDRITCgt3b3JsZF9sZXZlbBgCIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DelSaveRaidScNotify), DelSaveRaidScNotify.Parser, new string[]
			{
				"RaidId",
				"WorldLevel"
			}, null, null, null, null)
		}));
	}
}

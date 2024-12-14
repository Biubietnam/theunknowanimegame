using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011CC RID: 4556
	public static class StartTimedCocoonStageCsReqReflection
	{
		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0600CBA7 RID: 52135 RVA: 0x00222B70 File Offset: 0x00220D70
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartTimedCocoonStageCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400522A RID: 21034
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTdGFydFRpbWVkQ29jb29uU3RhZ2VDc1JlcS5wcm90byJSChpTdGFydFRp" + "bWVkQ29jb29uU3RhZ2VDc1JlcRIRCgljb2Nvb25faWQYCiABKA0SDAoEd2F2" + "ZRgJIAEoDRITCgt3b3JsZF9sZXZlbBgEIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartTimedCocoonStageCsReq), StartTimedCocoonStageCsReq.Parser, new string[]
			{
				"CocoonId",
				"Wave",
				"WorldLevel"
			}, null, null, null, null)
		}));
	}
}

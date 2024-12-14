using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200103A RID: 4154
	public static class RogueWorkbenchSelectFuncCsReqReflection
	{
		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0600B8CB RID: 47307 RVA: 0x001F01F7 File Offset: 0x001EE3F7
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchSelectFuncCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004ADF RID: 19167
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSb2d1ZVdvcmtiZW5jaFNlbGVjdEZ1bmNDc1JlcS5wcm90byJSCh1Sb2d1" + "ZVdvcmtiZW5jaFNlbGVjdEZ1bmNDc1JlcRIWCg5wcm9wX2VudGl0eV9pZBgC" + "IAEoDRIZChF3b3JrYmVuY2hfZnVuY19pZBgJIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueWorkbenchSelectFuncCsReq), RogueWorkbenchSelectFuncCsReq.Parser, new string[]
			{
				"PropEntityId",
				"WorkbenchFuncId"
			}, null, null, null, null)
		}));
	}
}

using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001CC RID: 460
	public static class ChangeScriptEmotionScRspReflection
	{
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0003B644 File Offset: 0x00039844
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChangeScriptEmotionScRspReflection.descriptor;
			}
		}

		// Token: 0x040008AA RID: 2218
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5DaGFuZ2VTY3JpcHRFbW90aW9uU2NSc3AucHJvdG8aGkhlYXJ0RGlhbEVt",
			"b3Rpb25UeXBlLnByb3RvImsKGENoYW5nZVNjcmlwdEVtb3Rpb25TY1JzcBIr",
			"CgxlbW90aW9uX3R5cGUYDiABKA4yFS5IZWFydERpYWxFbW90aW9uVHlwZRIR",
			"CglzY3JpcHRfaWQYByABKA0SDwoHcmV0Y29kZRgGIAEoDUIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			HeartDialEmotionTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChangeScriptEmotionScRsp), ChangeScriptEmotionScRsp.Parser, new string[]
			{
				"EmotionType",
				"ScriptId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}

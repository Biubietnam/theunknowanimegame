using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200045E RID: 1118
	public static class EnterSceneByServerScNotifyReflection
	{
		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x000892D1 File Offset: 0x000874D1
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterSceneByServerScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040013D8 RID: 5080
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBFbnRlclNjZW5lQnlTZXJ2ZXJTY05vdGlmeS5wcm90bxoQTGluZXVwSW5m",
			"by5wcm90bxoWRW50ZXJTY2VuZVJlYXNvbi5wcm90bxoPU2NlbmVJbmZvLnBy",
			"b3RvIncKGkVudGVyU2NlbmVCeVNlcnZlclNjTm90aWZ5EhkKBXNjZW5lGA0g",
			"ASgLMgouU2NlbmVJbmZvEhsKBmxpbmV1cBgJIAEoCzILLkxpbmV1cEluZm8S",
			"IQoGcmVhc29uGAwgASgOMhEuRW50ZXJTY2VuZVJlYXNvbkIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			LineupInfoReflection.Descriptor,
			EnterSceneReasonReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterSceneByServerScNotify), EnterSceneByServerScNotify.Parser, new string[]
			{
				"Scene",
				"Lineup",
				"Reason"
			}, null, null, null, null)
		}));
	}
}

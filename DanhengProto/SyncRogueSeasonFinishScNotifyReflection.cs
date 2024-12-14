using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200129C RID: 4764
	public static class SyncRogueSeasonFinishScNotifyReflection
	{
		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x0600D48C RID: 54412 RVA: 0x00237779 File Offset: 0x00235979
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueSeasonFinishScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005509 RID: 21769
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNTeW5jUm9ndWVTZWFzb25GaW5pc2hTY05vdGlmeS5wcm90bxoVUm9ndWVG",
			"aW5pc2hJbmZvLnByb3RvGhBMaW5ldXBJbmZvLnByb3RvGg9TY2VuZUluZm8u",
			"cHJvdG8aGlJvZ3VlU2NvcmVSZXdhcmRJbmZvLnByb3RvItEBCh1TeW5jUm9n",
			"dWVTZWFzb25GaW5pc2hTY05vdGlmeRIrChFyb2d1ZV9maW5pc2hfaW5mbxgG",
			"IAEoCzIQLlJvZ3VlRmluaXNoSW5mbxI2Chdyb2d1ZV9zY29yZV9yZXdhcmRf",
			"aW5mbxgIIAEoCzIVLlJvZ3VlU2NvcmVSZXdhcmRJbmZvEhkKBXNjZW5lGAog",
			"ASgLMgouU2NlbmVJbmZvEhMKC0pJQkJJT0lHSElDGAcgASgIEhsKBmxpbmV1",
			"cBgBIAEoCzILLkxpbmV1cEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueFinishInfoReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor,
			RogueScoreRewardInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueSeasonFinishScNotify), SyncRogueSeasonFinishScNotify.Parser, new string[]
			{
				"RogueFinishInfo",
				"RogueScoreRewardInfo",
				"Scene",
				"JIBBIOIGHIC",
				"Lineup"
			}, null, null, null, null)
		}));
	}
}

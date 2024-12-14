using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001062 RID: 4194
	public static class SceneEntityInfoReflection
	{
		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0600BAB8 RID: 47800 RVA: 0x001F5E3A File Offset: 0x001F403A
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneEntityInfoReflection.descriptor;
			}
		}

		// Token: 0x04004BBB RID: 19387
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVTY2VuZUVudGl0eUluZm8ucHJvdG8aGVNjZW5lU3VtbW9uVW5pdEluZm8u",
			"cHJvdG8aFFNjZW5lQWN0b3JJbmZvLnByb3RvGhJTY2VuZU5wY0luZm8ucHJv",
			"dG8aGVNjZW5lTnBjTW9uc3RlckluZm8ucHJvdG8aEE1vdGlvbkluZm8ucHJv",
			"dG8aE1NjZW5lUHJvcEluZm8ucHJvdG8irAIKD1NjZW5lRW50aXR5SW5mbxIP",
			"CgdHcm91cElkGA4gASgNEhsKBk1vdGlvbhgFIAEoCzILLk1vdGlvbkluZm8S",
			"EAoIRW50aXR5SWQYDCABKA0SDgoGSW5zdElkGAogASgNEiAKBUFjdG9yGAIg",
			"ASgLMg8uU2NlbmVBY3RvckluZm9IABIqCgpOcGNNb25zdGVyGAEgASgLMhQu",
			"U2NlbmVOcGNNb25zdGVySW5mb0gAEhwKA05wYxgDIAEoCzINLlNjZW5lTnBj",
			"SW5mb0gAEh4KBFByb3AYDyABKAsyDi5TY2VuZVByb3BJbmZvSAASKgoKU3Vt",
			"bW9uVW5pdBgIIAEoCzIULlNjZW5lU3VtbW9uVW5pdEluZm9IAEIRCg9FbnRp",
			"dHlPbmVvZkNhc2VCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneSummonUnitInfoReflection.Descriptor,
			SceneActorInfoReflection.Descriptor,
			SceneNpcInfoReflection.Descriptor,
			SceneNpcMonsterInfoReflection.Descriptor,
			MotionInfoReflection.Descriptor,
			ScenePropInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityInfo), SceneEntityInfo.Parser, new string[]
			{
				"GroupId",
				"Motion",
				"EntityId",
				"InstId",
				"Actor",
				"NpcMonster",
				"Npc",
				"Prop",
				"SummonUnit"
			}, new string[]
			{
				"EntityOneofCase"
			}, null, null, null)
		}));
	}
}

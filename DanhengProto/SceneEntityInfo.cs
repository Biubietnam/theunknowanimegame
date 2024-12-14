using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001063 RID: 4195
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneEntityInfo : IMessage<SceneEntityInfo>, IMessage, IEquatable<SceneEntityInfo>, IDeepCloneable<SceneEntityInfo>, IBufferMessage
	{
		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0600BABA RID: 47802 RVA: 0x001F5F89 File Offset: 0x001F4189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneEntityInfo> Parser
		{
			get
			{
				return SceneEntityInfo._parser;
			}
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0600BABB RID: 47803 RVA: 0x001F5F90 File Offset: 0x001F4190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneEntityInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0600BABC RID: 47804 RVA: 0x001F5FA2 File Offset: 0x001F41A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneEntityInfo.Descriptor;
			}
		}

		// Token: 0x0600BABD RID: 47805 RVA: 0x001F5FA9 File Offset: 0x001F41A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityInfo()
		{
		}

		// Token: 0x0600BABE RID: 47806 RVA: 0x001F5FB4 File Offset: 0x001F41B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityInfo(SceneEntityInfo other) : this()
		{
			this.groupId_ = other.groupId_;
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.entityId_ = other.entityId_;
			this.instId_ = other.instId_;
			SceneEntityInfo.EntityOneofCaseOneofCase entityOneofCaseCase = other.EntityOneofCaseCase;
			switch (entityOneofCaseCase)
			{
			case SceneEntityInfo.EntityOneofCaseOneofCase.NpcMonster:
				this.NpcMonster = other.NpcMonster.Clone();
				break;
			case SceneEntityInfo.EntityOneofCaseOneofCase.Actor:
				this.Actor = other.Actor.Clone();
				break;
			case SceneEntityInfo.EntityOneofCaseOneofCase.Npc:
				this.Npc = other.Npc.Clone();
				break;
			default:
				if (entityOneofCaseCase != SceneEntityInfo.EntityOneofCaseOneofCase.SummonUnit)
				{
					if (entityOneofCaseCase == SceneEntityInfo.EntityOneofCaseOneofCase.Prop)
					{
						this.Prop = other.Prop.Clone();
					}
				}
				else
				{
					this.SummonUnit = other.SummonUnit.Clone();
				}
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BABF RID: 47807 RVA: 0x001F609B File Offset: 0x001F429B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityInfo Clone()
		{
			return new SceneEntityInfo(this);
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600BAC0 RID: 47808 RVA: 0x001F60A3 File Offset: 0x001F42A3
		// (set) Token: 0x0600BAC1 RID: 47809 RVA: 0x001F60AB File Offset: 0x001F42AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x0600BAC2 RID: 47810 RVA: 0x001F60B4 File Offset: 0x001F42B4
		// (set) Token: 0x0600BAC3 RID: 47811 RVA: 0x001F60BC File Offset: 0x001F42BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x0600BAC4 RID: 47812 RVA: 0x001F60C5 File Offset: 0x001F42C5
		// (set) Token: 0x0600BAC5 RID: 47813 RVA: 0x001F60CD File Offset: 0x001F42CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x0600BAC6 RID: 47814 RVA: 0x001F60D6 File Offset: 0x001F42D6
		// (set) Token: 0x0600BAC7 RID: 47815 RVA: 0x001F60DE File Offset: 0x001F42DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x0600BAC8 RID: 47816 RVA: 0x001F60E7 File Offset: 0x001F42E7
		// (set) Token: 0x0600BAC9 RID: 47817 RVA: 0x001F60FF File Offset: 0x001F42FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneActorInfo Actor
		{
			get
			{
				if (this.entityOneofCaseCase_ != SceneEntityInfo.EntityOneofCaseOneofCase.Actor)
				{
					return null;
				}
				return (SceneActorInfo)this.entityOneofCase_;
			}
			set
			{
				this.entityOneofCase_ = value;
				this.entityOneofCaseCase_ = ((value == null) ? SceneEntityInfo.EntityOneofCaseOneofCase.None : SceneEntityInfo.EntityOneofCaseOneofCase.Actor);
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0600BACA RID: 47818 RVA: 0x001F6115 File Offset: 0x001F4315
		// (set) Token: 0x0600BACB RID: 47819 RVA: 0x001F612D File Offset: 0x001F432D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneNpcMonsterInfo NpcMonster
		{
			get
			{
				if (this.entityOneofCaseCase_ != SceneEntityInfo.EntityOneofCaseOneofCase.NpcMonster)
				{
					return null;
				}
				return (SceneNpcMonsterInfo)this.entityOneofCase_;
			}
			set
			{
				this.entityOneofCase_ = value;
				this.entityOneofCaseCase_ = ((value == null) ? SceneEntityInfo.EntityOneofCaseOneofCase.None : SceneEntityInfo.EntityOneofCaseOneofCase.NpcMonster);
			}
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0600BACC RID: 47820 RVA: 0x001F6143 File Offset: 0x001F4343
		// (set) Token: 0x0600BACD RID: 47821 RVA: 0x001F615B File Offset: 0x001F435B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneNpcInfo Npc
		{
			get
			{
				if (this.entityOneofCaseCase_ != SceneEntityInfo.EntityOneofCaseOneofCase.Npc)
				{
					return null;
				}
				return (SceneNpcInfo)this.entityOneofCase_;
			}
			set
			{
				this.entityOneofCase_ = value;
				this.entityOneofCaseCase_ = ((value == null) ? SceneEntityInfo.EntityOneofCaseOneofCase.None : SceneEntityInfo.EntityOneofCaseOneofCase.Npc);
			}
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600BACE RID: 47822 RVA: 0x001F6171 File Offset: 0x001F4371
		// (set) Token: 0x0600BACF RID: 47823 RVA: 0x001F618A File Offset: 0x001F438A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePropInfo Prop
		{
			get
			{
				if (this.entityOneofCaseCase_ != SceneEntityInfo.EntityOneofCaseOneofCase.Prop)
				{
					return null;
				}
				return (ScenePropInfo)this.entityOneofCase_;
			}
			set
			{
				this.entityOneofCase_ = value;
				this.entityOneofCaseCase_ = ((value == null) ? SceneEntityInfo.EntityOneofCaseOneofCase.None : SceneEntityInfo.EntityOneofCaseOneofCase.Prop);
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600BAD0 RID: 47824 RVA: 0x001F61A1 File Offset: 0x001F43A1
		// (set) Token: 0x0600BAD1 RID: 47825 RVA: 0x001F61B9 File Offset: 0x001F43B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSummonUnitInfo SummonUnit
		{
			get
			{
				if (this.entityOneofCaseCase_ != SceneEntityInfo.EntityOneofCaseOneofCase.SummonUnit)
				{
					return null;
				}
				return (SceneSummonUnitInfo)this.entityOneofCase_;
			}
			set
			{
				this.entityOneofCase_ = value;
				this.entityOneofCaseCase_ = ((value == null) ? SceneEntityInfo.EntityOneofCaseOneofCase.None : SceneEntityInfo.EntityOneofCaseOneofCase.SummonUnit);
			}
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600BAD2 RID: 47826 RVA: 0x001F61CF File Offset: 0x001F43CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityInfo.EntityOneofCaseOneofCase EntityOneofCaseCase
		{
			get
			{
				return this.entityOneofCaseCase_;
			}
		}

		// Token: 0x0600BAD3 RID: 47827 RVA: 0x001F61D7 File Offset: 0x001F43D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEntityOneofCase()
		{
			this.entityOneofCaseCase_ = SceneEntityInfo.EntityOneofCaseOneofCase.None;
			this.entityOneofCase_ = null;
		}

		// Token: 0x0600BAD4 RID: 47828 RVA: 0x001F61E7 File Offset: 0x001F43E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneEntityInfo);
		}

		// Token: 0x0600BAD5 RID: 47829 RVA: 0x001F61F8 File Offset: 0x001F43F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneEntityInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this.Motion, other.Motion) && this.EntityId == other.EntityId && this.InstId == other.InstId && object.Equals(this.Actor, other.Actor) && object.Equals(this.NpcMonster, other.NpcMonster) && object.Equals(this.Npc, other.Npc) && object.Equals(this.Prop, other.Prop) && object.Equals(this.SummonUnit, other.SummonUnit) && this.EntityOneofCaseCase == other.EntityOneofCaseCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BAD6 RID: 47830 RVA: 0x001F62E0 File Offset: 0x001F44E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.InstId != 0U)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Actor)
			{
				num ^= this.Actor.GetHashCode();
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.NpcMonster)
			{
				num ^= this.NpcMonster.GetHashCode();
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Npc)
			{
				num ^= this.Npc.GetHashCode();
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Prop)
			{
				num ^= this.Prop.GetHashCode();
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.SummonUnit)
			{
				num ^= this.SummonUnit.GetHashCode();
			}
			num ^= (int)this.entityOneofCaseCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BAD7 RID: 47831 RVA: 0x001F63E4 File Offset: 0x001F45E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BAD8 RID: 47832 RVA: 0x001F63EC File Offset: 0x001F45EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x001F63F8 File Offset: 0x001F45F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.NpcMonster)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NpcMonster);
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Actor)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Actor);
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Npc)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Npc);
			}
			if (this.motion_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Motion);
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.SummonUnit)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SummonUnit);
			}
			if (this.InstId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.InstId);
			}
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EntityId);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GroupId);
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Prop)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Prop);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x001F651C File Offset: 0x001F471C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			if (this.InstId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InstId);
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Actor)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Actor);
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.NpcMonster)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcMonster);
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Npc)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Npc);
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Prop)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Prop);
			}
			if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.SummonUnit)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SummonUnit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BADB RID: 47835 RVA: 0x001F6620 File Offset: 0x001F4820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneEntityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			if (other.InstId != 0U)
			{
				this.InstId = other.InstId;
			}
			SceneEntityInfo.EntityOneofCaseOneofCase entityOneofCaseCase = other.EntityOneofCaseCase;
			switch (entityOneofCaseCase)
			{
			case SceneEntityInfo.EntityOneofCaseOneofCase.NpcMonster:
				if (this.NpcMonster == null)
				{
					this.NpcMonster = new SceneNpcMonsterInfo();
				}
				this.NpcMonster.MergeFrom(other.NpcMonster);
				break;
			case SceneEntityInfo.EntityOneofCaseOneofCase.Actor:
				if (this.Actor == null)
				{
					this.Actor = new SceneActorInfo();
				}
				this.Actor.MergeFrom(other.Actor);
				break;
			case SceneEntityInfo.EntityOneofCaseOneofCase.Npc:
				if (this.Npc == null)
				{
					this.Npc = new SceneNpcInfo();
				}
				this.Npc.MergeFrom(other.Npc);
				break;
			default:
				if (entityOneofCaseCase != SceneEntityInfo.EntityOneofCaseOneofCase.SummonUnit)
				{
					if (entityOneofCaseCase == SceneEntityInfo.EntityOneofCaseOneofCase.Prop)
					{
						if (this.Prop == null)
						{
							this.Prop = new ScenePropInfo();
						}
						this.Prop.MergeFrom(other.Prop);
					}
				}
				else
				{
					if (this.SummonUnit == null)
					{
						this.SummonUnit = new SceneSummonUnitInfo();
					}
					this.SummonUnit.MergeFrom(other.SummonUnit);
				}
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BADC RID: 47836 RVA: 0x001F679B File Offset: 0x001F499B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BADD RID: 47837 RVA: 0x001F67A4 File Offset: 0x001F49A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							SceneNpcMonsterInfo sceneNpcMonsterInfo = new SceneNpcMonsterInfo();
							if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.NpcMonster)
							{
								sceneNpcMonsterInfo.MergeFrom(this.NpcMonster);
							}
							input.ReadMessage(sceneNpcMonsterInfo);
							this.NpcMonster = sceneNpcMonsterInfo;
							continue;
						}
						if (num == 18U)
						{
							SceneActorInfo sceneActorInfo = new SceneActorInfo();
							if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Actor)
							{
								sceneActorInfo.MergeFrom(this.Actor);
							}
							input.ReadMessage(sceneActorInfo);
							this.Actor = sceneActorInfo;
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							SceneNpcInfo sceneNpcInfo = new SceneNpcInfo();
							if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Npc)
							{
								sceneNpcInfo.MergeFrom(this.Npc);
							}
							input.ReadMessage(sceneNpcInfo);
							this.Npc = sceneNpcInfo;
							continue;
						}
						if (num == 42U)
						{
							if (this.motion_ == null)
							{
								this.Motion = new MotionInfo();
							}
							input.ReadMessage(this.Motion);
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 66U)
					{
						SceneSummonUnitInfo sceneSummonUnitInfo = new SceneSummonUnitInfo();
						if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.SummonUnit)
						{
							sceneSummonUnitInfo.MergeFrom(this.SummonUnit);
						}
						input.ReadMessage(sceneSummonUnitInfo);
						this.SummonUnit = sceneSummonUnitInfo;
						continue;
					}
					if (num == 80U)
					{
						this.InstId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.EntityId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						ScenePropInfo scenePropInfo = new ScenePropInfo();
						if (this.entityOneofCaseCase_ == SceneEntityInfo.EntityOneofCaseOneofCase.Prop)
						{
							scenePropInfo.MergeFrom(this.Prop);
						}
						input.ReadMessage(scenePropInfo);
						this.Prop = scenePropInfo;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004BBC RID: 19388
		private static readonly MessageParser<SceneEntityInfo> _parser = new MessageParser<SceneEntityInfo>(() => new SceneEntityInfo());

		// Token: 0x04004BBD RID: 19389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BBE RID: 19390
		public const int GroupIdFieldNumber = 14;

		// Token: 0x04004BBF RID: 19391
		private uint groupId_;

		// Token: 0x04004BC0 RID: 19392
		public const int MotionFieldNumber = 5;

		// Token: 0x04004BC1 RID: 19393
		private MotionInfo motion_;

		// Token: 0x04004BC2 RID: 19394
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04004BC3 RID: 19395
		private uint entityId_;

		// Token: 0x04004BC4 RID: 19396
		public const int InstIdFieldNumber = 10;

		// Token: 0x04004BC5 RID: 19397
		private uint instId_;

		// Token: 0x04004BC6 RID: 19398
		public const int ActorFieldNumber = 2;

		// Token: 0x04004BC7 RID: 19399
		public const int NpcMonsterFieldNumber = 1;

		// Token: 0x04004BC8 RID: 19400
		public const int NpcFieldNumber = 3;

		// Token: 0x04004BC9 RID: 19401
		public const int PropFieldNumber = 15;

		// Token: 0x04004BCA RID: 19402
		public const int SummonUnitFieldNumber = 8;

		// Token: 0x04004BCB RID: 19403
		private object entityOneofCase_;

		// Token: 0x04004BCC RID: 19404
		private SceneEntityInfo.EntityOneofCaseOneofCase entityOneofCaseCase_;

		// Token: 0x02001C06 RID: 7174
		public enum EntityOneofCaseOneofCase
		{
			// Token: 0x0400642D RID: 25645
			None,
			// Token: 0x0400642E RID: 25646
			Actor = 2,
			// Token: 0x0400642F RID: 25647
			NpcMonster = 1,
			// Token: 0x04006430 RID: 25648
			Npc = 3,
			// Token: 0x04006431 RID: 25649
			Prop = 15,
			// Token: 0x04006432 RID: 25650
			SummonUnit = 8
		}
	}
}

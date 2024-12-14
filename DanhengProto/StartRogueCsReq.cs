using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011C5 RID: 4549
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartRogueCsReq : IMessage<StartRogueCsReq>, IMessage, IEquatable<StartRogueCsReq>, IDeepCloneable<StartRogueCsReq>, IBufferMessage
	{
		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0600CB3D RID: 52029 RVA: 0x00221633 File Offset: 0x0021F833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartRogueCsReq> Parser
		{
			get
			{
				return StartRogueCsReq._parser;
			}
		}

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0600CB3E RID: 52030 RVA: 0x0022163A File Offset: 0x0021F83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartRogueCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0600CB3F RID: 52031 RVA: 0x0022164C File Offset: 0x0021F84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartRogueCsReq.Descriptor;
			}
		}

		// Token: 0x0600CB40 RID: 52032 RVA: 0x00221653 File Offset: 0x0021F853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRogueCsReq()
		{
		}

		// Token: 0x0600CB41 RID: 52033 RVA: 0x0022167C File Offset: 0x0021F87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRogueCsReq(StartRogueCsReq other) : this()
		{
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.areaId_ = other.areaId_;
			this.aeonId_ = other.aeonId_;
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this.disableAeonIdList_ = other.disableAeonIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB42 RID: 52034 RVA: 0x002216F7 File Offset: 0x0021F8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRogueCsReq Clone()
		{
			return new StartRogueCsReq(this);
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0600CB43 RID: 52035 RVA: 0x002216FF File Offset: 0x0021F8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0600CB44 RID: 52036 RVA: 0x00221707 File Offset: 0x0021F907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0600CB45 RID: 52037 RVA: 0x0022170F File Offset: 0x0021F90F
		// (set) Token: 0x0600CB46 RID: 52038 RVA: 0x00221717 File Offset: 0x0021F917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0600CB47 RID: 52039 RVA: 0x00221720 File Offset: 0x0021F920
		// (set) Token: 0x0600CB48 RID: 52040 RVA: 0x00221728 File Offset: 0x0021F928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0600CB49 RID: 52041 RVA: 0x00221731 File Offset: 0x0021F931
		// (set) Token: 0x0600CB4A RID: 52042 RVA: 0x00221739 File Offset: 0x0021F939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0600CB4B RID: 52043 RVA: 0x00221742 File Offset: 0x0021F942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DisableAeonIdList
		{
			get
			{
				return this.disableAeonIdList_;
			}
		}

		// Token: 0x0600CB4C RID: 52044 RVA: 0x0022174A File Offset: 0x0021F94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartRogueCsReq);
		}

		// Token: 0x0600CB4D RID: 52045 RVA: 0x00221758 File Offset: 0x0021F958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartRogueCsReq other)
		{
			return other != null && (other == this || (this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.AreaId == other.AreaId && this.AeonId == other.AeonId && this.InteractedPropEntityId == other.InteractedPropEntityId && this.disableAeonIdList_.Equals(other.disableAeonIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB4E RID: 52046 RVA: 0x002217F0 File Offset: 0x0021F9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trialAvatarIdList_.GetHashCode();
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			num ^= this.disableAeonIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB4F RID: 52047 RVA: 0x0022188B File Offset: 0x0021FA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CB50 RID: 52048 RVA: 0x00221893 File Offset: 0x0021FA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB51 RID: 52049 RVA: 0x0022189C File Offset: 0x0021FA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			this.disableAeonIdList_.WriteTo(ref output, StartRogueCsReq._repeated_disableAeonIdList_codec);
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.AreaId);
			}
			this.trialAvatarIdList_.WriteTo(ref output, StartRogueCsReq._repeated_trialAvatarIdList_codec);
			this.baseAvatarIdList_.WriteTo(ref output, StartRogueCsReq._repeated_baseAvatarIdList_codec);
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB52 RID: 52050 RVA: 0x00221944 File Offset: 0x0021FB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trialAvatarIdList_.CalculateSize(StartRogueCsReq._repeated_trialAvatarIdList_codec);
			num += this.baseAvatarIdList_.CalculateSize(StartRogueCsReq._repeated_baseAvatarIdList_codec);
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			num += this.disableAeonIdList_.CalculateSize(StartRogueCsReq._repeated_disableAeonIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB53 RID: 52051 RVA: 0x002219EC File Offset: 0x0021FBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartRogueCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this.disableAeonIdList_.Add(other.disableAeonIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB54 RID: 52052 RVA: 0x00221A83 File Offset: 0x0021FC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB55 RID: 52053 RVA: 0x00221A8C File Offset: 0x0021FC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num <= 64U)
					{
						if (num == 8U)
						{
							this.InteractedPropEntityId = input.ReadUInt32();
							continue;
						}
						if (num != 64U)
						{
							goto IL_46;
						}
					}
					else if (num != 66U)
					{
						if (num != 72U)
						{
							goto IL_46;
						}
						this.AreaId = input.ReadUInt32();
						continue;
					}
					this.disableAeonIdList_.AddEntriesFrom(ref input, StartRogueCsReq._repeated_disableAeonIdList_codec);
					continue;
				}
				if (num <= 90U)
				{
					if (num == 88U || num == 90U)
					{
						this.trialAvatarIdList_.AddEntriesFrom(ref input, StartRogueCsReq._repeated_trialAvatarIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U || num == 106U)
					{
						this.baseAvatarIdList_.AddEntriesFrom(ref input, StartRogueCsReq._repeated_baseAvatarIdList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.AeonId = input.ReadUInt32();
						continue;
					}
				}
				IL_46:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051F7 RID: 20983
		private static readonly MessageParser<StartRogueCsReq> _parser = new MessageParser<StartRogueCsReq>(() => new StartRogueCsReq());

		// Token: 0x040051F8 RID: 20984
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051F9 RID: 20985
		public const int TrialAvatarIdListFieldNumber = 11;

		// Token: 0x040051FA RID: 20986
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x040051FB RID: 20987
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x040051FC RID: 20988
		public const int BaseAvatarIdListFieldNumber = 13;

		// Token: 0x040051FD RID: 20989
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x040051FE RID: 20990
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x040051FF RID: 20991
		public const int AreaIdFieldNumber = 9;

		// Token: 0x04005200 RID: 20992
		private uint areaId_;

		// Token: 0x04005201 RID: 20993
		public const int AeonIdFieldNumber = 15;

		// Token: 0x04005202 RID: 20994
		private uint aeonId_;

		// Token: 0x04005203 RID: 20995
		public const int InteractedPropEntityIdFieldNumber = 1;

		// Token: 0x04005204 RID: 20996
		private uint interactedPropEntityId_;

		// Token: 0x04005205 RID: 20997
		public const int DisableAeonIdListFieldNumber = 8;

		// Token: 0x04005206 RID: 20998
		private static readonly FieldCodec<uint> _repeated_disableAeonIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04005207 RID: 20999
		private readonly RepeatedField<uint> disableAeonIdList_ = new RepeatedField<uint>();
	}
}

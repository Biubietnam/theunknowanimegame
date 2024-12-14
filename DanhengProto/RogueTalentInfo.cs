using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F79 RID: 3961
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTalentInfo : IMessage<RogueTalentInfo>, IMessage, IEquatable<RogueTalentInfo>, IDeepCloneable<RogueTalentInfo>, IBufferMessage
	{
		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600B075 RID: 45173 RVA: 0x001DA12B File Offset: 0x001D832B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTalentInfo> Parser
		{
			get
			{
				return RogueTalentInfo._parser;
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600B076 RID: 45174 RVA: 0x001DA132 File Offset: 0x001D8332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTalentInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600B077 RID: 45175 RVA: 0x001DA144 File Offset: 0x001D8344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTalentInfo.Descriptor;
			}
		}

		// Token: 0x0600B078 RID: 45176 RVA: 0x001DA14B File Offset: 0x001D834B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentInfo()
		{
		}

		// Token: 0x0600B079 RID: 45177 RVA: 0x001DA160 File Offset: 0x001D8360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentInfo(RogueTalentInfo other) : this()
		{
			this.talentId_ = other.talentId_;
			this.rogueUnlockProgressList_ = other.rogueUnlockProgressList_.Clone();
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B07A RID: 45178 RVA: 0x001DA1AD File Offset: 0x001D83AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentInfo Clone()
		{
			return new RogueTalentInfo(this);
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600B07B RID: 45179 RVA: 0x001DA1B5 File Offset: 0x001D83B5
		// (set) Token: 0x0600B07C RID: 45180 RVA: 0x001DA1BD File Offset: 0x001D83BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600B07D RID: 45181 RVA: 0x001DA1C6 File Offset: 0x001D83C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueUnlockProgress> RogueUnlockProgressList
		{
			get
			{
				return this.rogueUnlockProgressList_;
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600B07E RID: 45182 RVA: 0x001DA1CE File Offset: 0x001D83CE
		// (set) Token: 0x0600B07F RID: 45183 RVA: 0x001DA1D6 File Offset: 0x001D83D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600B080 RID: 45184 RVA: 0x001DA1DF File Offset: 0x001D83DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTalentInfo);
		}

		// Token: 0x0600B081 RID: 45185 RVA: 0x001DA1F0 File Offset: 0x001D83F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTalentInfo other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && this.rogueUnlockProgressList_.Equals(other.rogueUnlockProgressList_) && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B082 RID: 45186 RVA: 0x001DA250 File Offset: 0x001D8450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalentId != 0U)
			{
				num ^= this.TalentId.GetHashCode();
			}
			num ^= this.rogueUnlockProgressList_.GetHashCode();
			if (this.Status != RogueTalentStatus.Lock)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B083 RID: 45187 RVA: 0x001DA2BC File Offset: 0x001D84BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B084 RID: 45188 RVA: 0x001DA2C4 File Offset: 0x001D84C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B085 RID: 45189 RVA: 0x001DA2D0 File Offset: 0x001D84D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != RogueTalentStatus.Lock)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Status);
			}
			this.rogueUnlockProgressList_.WriteTo(ref output, RogueTalentInfo._repeated_rogueUnlockProgressList_codec);
			if (this.TalentId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B086 RID: 45190 RVA: 0x001DA33C File Offset: 0x001D853C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalentId);
			}
			num += this.rogueUnlockProgressList_.CalculateSize(RogueTalentInfo._repeated_rogueUnlockProgressList_codec);
			if (this.Status != RogueTalentStatus.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B087 RID: 45191 RVA: 0x001DA3A8 File Offset: 0x001D85A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTalentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0U)
			{
				this.TalentId = other.TalentId;
			}
			this.rogueUnlockProgressList_.Add(other.rogueUnlockProgressList_);
			if (other.Status != RogueTalentStatus.Lock)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B088 RID: 45192 RVA: 0x001DA409 File Offset: 0x001D8609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B089 RID: 45193 RVA: 0x001DA414 File Offset: 0x001D8614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 66U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TalentId = input.ReadUInt32();
						}
					}
					else
					{
						this.rogueUnlockProgressList_.AddEntriesFrom(ref input, RogueTalentInfo._repeated_rogueUnlockProgressList_codec);
					}
				}
				else
				{
					this.Status = (RogueTalentStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x040047CB RID: 18379
		private static readonly MessageParser<RogueTalentInfo> _parser = new MessageParser<RogueTalentInfo>(() => new RogueTalentInfo());

		// Token: 0x040047CC RID: 18380
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047CD RID: 18381
		public const int TalentIdFieldNumber = 10;

		// Token: 0x040047CE RID: 18382
		private uint talentId_;

		// Token: 0x040047CF RID: 18383
		public const int RogueUnlockProgressListFieldNumber = 8;

		// Token: 0x040047D0 RID: 18384
		private static readonly FieldCodec<RogueUnlockProgress> _repeated_rogueUnlockProgressList_codec = FieldCodec.ForMessage<RogueUnlockProgress>(66U, RogueUnlockProgress.Parser);

		// Token: 0x040047D1 RID: 18385
		private readonly RepeatedField<RogueUnlockProgress> rogueUnlockProgressList_ = new RepeatedField<RogueUnlockProgress>();

		// Token: 0x040047D2 RID: 18386
		public const int StatusFieldNumber = 1;

		// Token: 0x040047D3 RID: 18387
		private RogueTalentStatus status_;
	}
}

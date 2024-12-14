using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200097D RID: 2429
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JoinLineupCsReq : IMessage<JoinLineupCsReq>, IMessage, IEquatable<JoinLineupCsReq>, IDeepCloneable<JoinLineupCsReq>, IBufferMessage
	{
		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x06006C9D RID: 27805 RVA: 0x001220BF File Offset: 0x001202BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JoinLineupCsReq> Parser
		{
			get
			{
				return JoinLineupCsReq._parser;
			}
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x06006C9E RID: 27806 RVA: 0x001220C6 File Offset: 0x001202C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JoinLineupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06006C9F RID: 27807 RVA: 0x001220D8 File Offset: 0x001202D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinLineupCsReq.Descriptor;
			}
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x001220DF File Offset: 0x001202DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinLineupCsReq()
		{
		}

		// Token: 0x06006CA1 RID: 27809 RVA: 0x001220E8 File Offset: 0x001202E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinLineupCsReq(JoinLineupCsReq other) : this()
		{
			this.extraLineupType_ = other.extraLineupType_;
			this.isVirtual_ = other.isVirtual_;
			this.baseAvatarId_ = other.baseAvatarId_;
			this.index_ = other.index_;
			this.avatarType_ = other.avatarType_;
			this.slot_ = other.slot_;
			this.planeId_ = other.planeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x00122160 File Offset: 0x00120360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinLineupCsReq Clone()
		{
			return new JoinLineupCsReq(this);
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06006CA3 RID: 27811 RVA: 0x00122168 File Offset: 0x00120368
		// (set) Token: 0x06006CA4 RID: 27812 RVA: 0x00122170 File Offset: 0x00120370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraLineupType ExtraLineupType
		{
			get
			{
				return this.extraLineupType_;
			}
			set
			{
				this.extraLineupType_ = value;
			}
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06006CA5 RID: 27813 RVA: 0x00122179 File Offset: 0x00120379
		// (set) Token: 0x06006CA6 RID: 27814 RVA: 0x00122181 File Offset: 0x00120381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVirtual
		{
			get
			{
				return this.isVirtual_;
			}
			set
			{
				this.isVirtual_ = value;
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06006CA7 RID: 27815 RVA: 0x0012218A File Offset: 0x0012038A
		// (set) Token: 0x06006CA8 RID: 27816 RVA: 0x00122192 File Offset: 0x00120392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x06006CA9 RID: 27817 RVA: 0x0012219B File Offset: 0x0012039B
		// (set) Token: 0x06006CAA RID: 27818 RVA: 0x001221A3 File Offset: 0x001203A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x06006CAB RID: 27819 RVA: 0x001221AC File Offset: 0x001203AC
		// (set) Token: 0x06006CAC RID: 27820 RVA: 0x001221B4 File Offset: 0x001203B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x06006CAD RID: 27821 RVA: 0x001221BD File Offset: 0x001203BD
		// (set) Token: 0x06006CAE RID: 27822 RVA: 0x001221C5 File Offset: 0x001203C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x06006CAF RID: 27823 RVA: 0x001221CE File Offset: 0x001203CE
		// (set) Token: 0x06006CB0 RID: 27824 RVA: 0x001221D6 File Offset: 0x001203D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlaneId
		{
			get
			{
				return this.planeId_;
			}
			set
			{
				this.planeId_ = value;
			}
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x001221DF File Offset: 0x001203DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinLineupCsReq);
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x001221F0 File Offset: 0x001203F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinLineupCsReq other)
		{
			return other != null && (other == this || (this.ExtraLineupType == other.ExtraLineupType && this.IsVirtual == other.IsVirtual && this.BaseAvatarId == other.BaseAvatarId && this.Index == other.Index && this.AvatarType == other.AvatarType && this.Slot == other.Slot && this.PlaneId == other.PlaneId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x0012228C File Offset: 0x0012048C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num ^= this.ExtraLineupType.GetHashCode();
			}
			if (this.IsVirtual)
			{
				num ^= this.IsVirtual.GetHashCode();
			}
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.Slot != 0U)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x0012236E File Offset: 0x0012056E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00122376 File Offset: 0x00120576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x00122380 File Offset: 0x00120580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Slot != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Slot);
			}
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PlaneId);
			}
			if (this.Index != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Index);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this.IsVirtual)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsVirtual);
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ExtraLineupType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x00122468 File Offset: 0x00120668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ExtraLineupType);
			}
			if (this.IsVirtual)
			{
				num += 2;
			}
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.Slot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Slot);
			}
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x0012252C File Offset: 0x0012072C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JoinLineupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				this.ExtraLineupType = other.ExtraLineupType;
			}
			if (other.IsVirtual)
			{
				this.IsVirtual = other.IsVirtual;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x001225E0 File Offset: 0x001207E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x001225EC File Offset: 0x001207EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.Slot = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.PlaneId = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Index = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 96U)
				{
					if (num == 64U)
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.BaseAvatarId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.IsVirtual = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.ExtraLineupType = (ExtraLineupType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040029A1 RID: 10657
		private static readonly MessageParser<JoinLineupCsReq> _parser = new MessageParser<JoinLineupCsReq>(() => new JoinLineupCsReq());

		// Token: 0x040029A2 RID: 10658
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029A3 RID: 10659
		public const int ExtraLineupTypeFieldNumber = 15;

		// Token: 0x040029A4 RID: 10660
		private ExtraLineupType extraLineupType_;

		// Token: 0x040029A5 RID: 10661
		public const int IsVirtualFieldNumber = 13;

		// Token: 0x040029A6 RID: 10662
		private bool isVirtual_;

		// Token: 0x040029A7 RID: 10663
		public const int BaseAvatarIdFieldNumber = 12;

		// Token: 0x040029A8 RID: 10664
		private uint baseAvatarId_;

		// Token: 0x040029A9 RID: 10665
		public const int IndexFieldNumber = 7;

		// Token: 0x040029AA RID: 10666
		private uint index_;

		// Token: 0x040029AB RID: 10667
		public const int AvatarTypeFieldNumber = 8;

		// Token: 0x040029AC RID: 10668
		private AvatarType avatarType_;

		// Token: 0x040029AD RID: 10669
		public const int SlotFieldNumber = 4;

		// Token: 0x040029AE RID: 10670
		private uint slot_;

		// Token: 0x040029AF RID: 10671
		public const int PlaneIdFieldNumber = 5;

		// Token: 0x040029B0 RID: 10672
		private uint planeId_;
	}
}

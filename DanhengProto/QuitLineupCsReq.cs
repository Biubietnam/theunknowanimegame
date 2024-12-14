using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D4B RID: 3403
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitLineupCsReq : IMessage<QuitLineupCsReq>, IMessage, IEquatable<QuitLineupCsReq>, IDeepCloneable<QuitLineupCsReq>, IBufferMessage
	{
		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x06009804 RID: 38916 RVA: 0x00195053 File Offset: 0x00193253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitLineupCsReq> Parser
		{
			get
			{
				return QuitLineupCsReq._parser;
			}
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x06009805 RID: 38917 RVA: 0x0019505A File Offset: 0x0019325A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitLineupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x06009806 RID: 38918 RVA: 0x0019506C File Offset: 0x0019326C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitLineupCsReq.Descriptor;
			}
		}

		// Token: 0x06009807 RID: 38919 RVA: 0x00195073 File Offset: 0x00193273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitLineupCsReq()
		{
		}

		// Token: 0x06009808 RID: 38920 RVA: 0x0019507C File Offset: 0x0019327C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitLineupCsReq(QuitLineupCsReq other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.baseAvatarId_ = other.baseAvatarId_;
			this.isVirtual_ = other.isVirtual_;
			this.extraLineupType_ = other.extraLineupType_;
			this.planeId_ = other.planeId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009809 RID: 38921 RVA: 0x001950E8 File Offset: 0x001932E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitLineupCsReq Clone()
		{
			return new QuitLineupCsReq(this);
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x0600980A RID: 38922 RVA: 0x001950F0 File Offset: 0x001932F0
		// (set) Token: 0x0600980B RID: 38923 RVA: 0x001950F8 File Offset: 0x001932F8
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

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x0600980C RID: 38924 RVA: 0x00195101 File Offset: 0x00193301
		// (set) Token: 0x0600980D RID: 38925 RVA: 0x00195109 File Offset: 0x00193309
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

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x0600980E RID: 38926 RVA: 0x00195112 File Offset: 0x00193312
		// (set) Token: 0x0600980F RID: 38927 RVA: 0x0019511A File Offset: 0x0019331A
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

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x06009810 RID: 38928 RVA: 0x00195123 File Offset: 0x00193323
		// (set) Token: 0x06009811 RID: 38929 RVA: 0x0019512B File Offset: 0x0019332B
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

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x06009812 RID: 38930 RVA: 0x00195134 File Offset: 0x00193334
		// (set) Token: 0x06009813 RID: 38931 RVA: 0x0019513C File Offset: 0x0019333C
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

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x06009814 RID: 38932 RVA: 0x00195145 File Offset: 0x00193345
		// (set) Token: 0x06009815 RID: 38933 RVA: 0x0019514D File Offset: 0x0019334D
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

		// Token: 0x06009816 RID: 38934 RVA: 0x00195156 File Offset: 0x00193356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitLineupCsReq);
		}

		// Token: 0x06009817 RID: 38935 RVA: 0x00195164 File Offset: 0x00193364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitLineupCsReq other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.BaseAvatarId == other.BaseAvatarId && this.IsVirtual == other.IsVirtual && this.ExtraLineupType == other.ExtraLineupType && this.PlaneId == other.PlaneId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x001951F0 File Offset: 0x001933F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this.IsVirtual)
			{
				num ^= this.IsVirtual.GetHashCode();
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num ^= this.ExtraLineupType.GetHashCode();
			}
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x001952B9 File Offset: 0x001934B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600981A RID: 38938 RVA: 0x001952C1 File Offset: 0x001934C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x001952CC File Offset: 0x001934CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ExtraLineupType);
			}
			if (this.IsVirtual)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsVirtual);
			}
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.PlaneId);
			}
			if (this.Index != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Index);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600981C RID: 38940 RVA: 0x00195394 File Offset: 0x00193594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this.IsVirtual)
			{
				num += 2;
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ExtraLineupType);
			}
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600981D RID: 38941 RVA: 0x00195440 File Offset: 0x00193640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitLineupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			if (other.IsVirtual)
			{
				this.IsVirtual = other.IsVirtual;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				this.ExtraLineupType = other.ExtraLineupType;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600981E RID: 38942 RVA: 0x001954E0 File Offset: 0x001936E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600981F RID: 38943 RVA: 0x001954EC File Offset: 0x001936EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.ExtraLineupType = (ExtraLineupType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.IsVirtual = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.BaseAvatarId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.PlaneId = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Index = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B19 RID: 15129
		private static readonly MessageParser<QuitLineupCsReq> _parser = new MessageParser<QuitLineupCsReq>(() => new QuitLineupCsReq());

		// Token: 0x04003B1A RID: 15130
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B1B RID: 15131
		public const int AvatarTypeFieldNumber = 11;

		// Token: 0x04003B1C RID: 15132
		private AvatarType avatarType_;

		// Token: 0x04003B1D RID: 15133
		public const int BaseAvatarIdFieldNumber = 5;

		// Token: 0x04003B1E RID: 15134
		private uint baseAvatarId_;

		// Token: 0x04003B1F RID: 15135
		public const int IsVirtualFieldNumber = 2;

		// Token: 0x04003B20 RID: 15136
		private bool isVirtual_;

		// Token: 0x04003B21 RID: 15137
		public const int ExtraLineupTypeFieldNumber = 1;

		// Token: 0x04003B22 RID: 15138
		private ExtraLineupType extraLineupType_;

		// Token: 0x04003B23 RID: 15139
		public const int PlaneIdFieldNumber = 7;

		// Token: 0x04003B24 RID: 15140
		private uint planeId_;

		// Token: 0x04003B25 RID: 15141
		public const int IndexFieldNumber = 10;

		// Token: 0x04003B26 RID: 15142
		private uint index_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012DF RID: 4831
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeLoginActivityRewardCsReq : IMessage<TakeLoginActivityRewardCsReq>, IMessage, IEquatable<TakeLoginActivityRewardCsReq>, IDeepCloneable<TakeLoginActivityRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x0600D78C RID: 55180 RVA: 0x0023EDE1 File Offset: 0x0023CFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeLoginActivityRewardCsReq> Parser
		{
			get
			{
				return TakeLoginActivityRewardCsReq._parser;
			}
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x0600D78D RID: 55181 RVA: 0x0023EDE8 File Offset: 0x0023CFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeLoginActivityRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x0600D78E RID: 55182 RVA: 0x0023EDFA File Offset: 0x0023CFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeLoginActivityRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D78F RID: 55183 RVA: 0x0023EE01 File Offset: 0x0023D001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeLoginActivityRewardCsReq()
		{
		}

		// Token: 0x0600D790 RID: 55184 RVA: 0x0023EE09 File Offset: 0x0023D009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeLoginActivityRewardCsReq(TakeLoginActivityRewardCsReq other) : this()
		{
			this.takeDays_ = other.takeDays_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D791 RID: 55185 RVA: 0x0023EE3A File Offset: 0x0023D03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeLoginActivityRewardCsReq Clone()
		{
			return new TakeLoginActivityRewardCsReq(this);
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x0600D792 RID: 55186 RVA: 0x0023EE42 File Offset: 0x0023D042
		// (set) Token: 0x0600D793 RID: 55187 RVA: 0x0023EE4A File Offset: 0x0023D04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TakeDays
		{
			get
			{
				return this.takeDays_;
			}
			set
			{
				this.takeDays_ = value;
			}
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x0600D794 RID: 55188 RVA: 0x0023EE53 File Offset: 0x0023D053
		// (set) Token: 0x0600D795 RID: 55189 RVA: 0x0023EE5B File Offset: 0x0023D05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600D796 RID: 55190 RVA: 0x0023EE64 File Offset: 0x0023D064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeLoginActivityRewardCsReq);
		}

		// Token: 0x0600D797 RID: 55191 RVA: 0x0023EE72 File Offset: 0x0023D072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeLoginActivityRewardCsReq other)
		{
			return other != null && (other == this || (this.TakeDays == other.TakeDays && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D798 RID: 55192 RVA: 0x0023EEB0 File Offset: 0x0023D0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TakeDays != 0U)
			{
				num ^= this.TakeDays.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D799 RID: 55193 RVA: 0x0023EF08 File Offset: 0x0023D108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D79A RID: 55194 RVA: 0x0023EF10 File Offset: 0x0023D110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D79B RID: 55195 RVA: 0x0023EF1C File Offset: 0x0023D11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TakeDays != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TakeDays);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D79C RID: 55196 RVA: 0x0023EF78 File Offset: 0x0023D178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TakeDays != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TakeDays);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D79D RID: 55197 RVA: 0x0023EFD0 File Offset: 0x0023D1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeLoginActivityRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TakeDays != 0U)
			{
				this.TakeDays = other.TakeDays;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D79E RID: 55198 RVA: 0x0023F020 File Offset: 0x0023D220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D79F RID: 55199 RVA: 0x0023F02C File Offset: 0x0023D22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.TakeDays = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005606 RID: 22022
		private static readonly MessageParser<TakeLoginActivityRewardCsReq> _parser = new MessageParser<TakeLoginActivityRewardCsReq>(() => new TakeLoginActivityRewardCsReq());

		// Token: 0x04005607 RID: 22023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005608 RID: 22024
		public const int TakeDaysFieldNumber = 6;

		// Token: 0x04005609 RID: 22025
		private uint takeDays_;

		// Token: 0x0400560A RID: 22026
		public const int IdFieldNumber = 11;

		// Token: 0x0400560B RID: 22027
		private uint id_;
	}
}

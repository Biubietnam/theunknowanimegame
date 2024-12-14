using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010F1 RID: 4337
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetFriendMarkCsReq : IMessage<SetFriendMarkCsReq>, IMessage, IEquatable<SetFriendMarkCsReq>, IDeepCloneable<SetFriendMarkCsReq>, IBufferMessage
	{
		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x0600C15A RID: 49498 RVA: 0x00207BCD File Offset: 0x00205DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetFriendMarkCsReq> Parser
		{
			get
			{
				return SetFriendMarkCsReq._parser;
			}
		}

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x0600C15B RID: 49499 RVA: 0x00207BD4 File Offset: 0x00205DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetFriendMarkCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x0600C15C RID: 49500 RVA: 0x00207BE6 File Offset: 0x00205DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFriendMarkCsReq.Descriptor;
			}
		}

		// Token: 0x0600C15D RID: 49501 RVA: 0x00207BED File Offset: 0x00205DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendMarkCsReq()
		{
		}

		// Token: 0x0600C15E RID: 49502 RVA: 0x00207BF5 File Offset: 0x00205DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendMarkCsReq(SetFriendMarkCsReq other) : this()
		{
			this.lBIOKLPIACM_ = other.lBIOKLPIACM_;
			this.reason_ = other.reason_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C15F RID: 49503 RVA: 0x00207C32 File Offset: 0x00205E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendMarkCsReq Clone()
		{
			return new SetFriendMarkCsReq(this);
		}

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x0600C160 RID: 49504 RVA: 0x00207C3A File Offset: 0x00205E3A
		// (set) Token: 0x0600C161 RID: 49505 RVA: 0x00207C42 File Offset: 0x00205E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LBIOKLPIACM
		{
			get
			{
				return this.lBIOKLPIACM_;
			}
			set
			{
				this.lBIOKLPIACM_ = value;
			}
		}

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0600C162 RID: 49506 RVA: 0x00207C4B File Offset: 0x00205E4B
		// (set) Token: 0x0600C163 RID: 49507 RVA: 0x00207C53 File Offset: 0x00205E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0600C164 RID: 49508 RVA: 0x00207C5C File Offset: 0x00205E5C
		// (set) Token: 0x0600C165 RID: 49509 RVA: 0x00207C64 File Offset: 0x00205E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x0600C166 RID: 49510 RVA: 0x00207C6D File Offset: 0x00205E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFriendMarkCsReq);
		}

		// Token: 0x0600C167 RID: 49511 RVA: 0x00207C7C File Offset: 0x00205E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFriendMarkCsReq other)
		{
			return other != null && (other == this || (this.LBIOKLPIACM == other.LBIOKLPIACM && this.Reason == other.Reason && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C168 RID: 49512 RVA: 0x00207CD8 File Offset: 0x00205ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LBIOKLPIACM)
			{
				num ^= this.LBIOKLPIACM.GetHashCode();
			}
			if (this.Reason != 0U)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C169 RID: 49513 RVA: 0x00207D49 File Offset: 0x00205F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C16A RID: 49514 RVA: 0x00207D51 File Offset: 0x00205F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C16B RID: 49515 RVA: 0x00207D5C File Offset: 0x00205F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Reason);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Uid);
			}
			if (this.LBIOKLPIACM)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.LBIOKLPIACM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C16C RID: 49516 RVA: 0x00207DD4 File Offset: 0x00205FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LBIOKLPIACM)
			{
				num += 2;
			}
			if (this.Reason != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C16D RID: 49517 RVA: 0x00207E38 File Offset: 0x00206038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFriendMarkCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LBIOKLPIACM)
			{
				this.LBIOKLPIACM = other.LBIOKLPIACM;
			}
			if (other.Reason != 0U)
			{
				this.Reason = other.Reason;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C16E RID: 49518 RVA: 0x00207E9C File Offset: 0x0020609C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C16F RID: 49519 RVA: 0x00207EA8 File Offset: 0x002060A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 72U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LBIOKLPIACM = input.ReadBool();
						}
					}
					else
					{
						this.Uid = input.ReadUInt32();
					}
				}
				else
				{
					this.Reason = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E4D RID: 20045
		private static readonly MessageParser<SetFriendMarkCsReq> _parser = new MessageParser<SetFriendMarkCsReq>(() => new SetFriendMarkCsReq());

		// Token: 0x04004E4E RID: 20046
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E4F RID: 20047
		public const int LBIOKLPIACMFieldNumber = 12;

		// Token: 0x04004E50 RID: 20048
		private bool lBIOKLPIACM_;

		// Token: 0x04004E51 RID: 20049
		public const int ReasonFieldNumber = 5;

		// Token: 0x04004E52 RID: 20050
		private uint reason_;

		// Token: 0x04004E53 RID: 20051
		public const int UidFieldNumber = 9;

		// Token: 0x04004E54 RID: 20052
		private uint uid_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012C7 RID: 4807
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeChallengeRewardCsReq : IMessage<TakeChallengeRewardCsReq>, IMessage, IEquatable<TakeChallengeRewardCsReq>, IDeepCloneable<TakeChallengeRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x0600D66A RID: 54890 RVA: 0x0023BF6C File Offset: 0x0023A16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeChallengeRewardCsReq> Parser
		{
			get
			{
				return TakeChallengeRewardCsReq._parser;
			}
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x0600D66B RID: 54891 RVA: 0x0023BF73 File Offset: 0x0023A173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeChallengeRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x0600D66C RID: 54892 RVA: 0x0023BF85 File Offset: 0x0023A185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeChallengeRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D66D RID: 54893 RVA: 0x0023BF8C File Offset: 0x0023A18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRewardCsReq()
		{
		}

		// Token: 0x0600D66E RID: 54894 RVA: 0x0023BF94 File Offset: 0x0023A194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRewardCsReq(TakeChallengeRewardCsReq other) : this()
		{
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D66F RID: 54895 RVA: 0x0023BFB9 File Offset: 0x0023A1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRewardCsReq Clone()
		{
			return new TakeChallengeRewardCsReq(this);
		}

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x0600D670 RID: 54896 RVA: 0x0023BFC1 File Offset: 0x0023A1C1
		// (set) Token: 0x0600D671 RID: 54897 RVA: 0x0023BFC9 File Offset: 0x0023A1C9
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

		// Token: 0x0600D672 RID: 54898 RVA: 0x0023BFD2 File Offset: 0x0023A1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeChallengeRewardCsReq);
		}

		// Token: 0x0600D673 RID: 54899 RVA: 0x0023BFE0 File Offset: 0x0023A1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeChallengeRewardCsReq other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D674 RID: 54900 RVA: 0x0023C010 File Offset: 0x0023A210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D675 RID: 54901 RVA: 0x0023C04F File Offset: 0x0023A24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D676 RID: 54902 RVA: 0x0023C057 File Offset: 0x0023A257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D677 RID: 54903 RVA: 0x0023C060 File Offset: 0x0023A260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D678 RID: 54904 RVA: 0x0023C094 File Offset: 0x0023A294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D679 RID: 54905 RVA: 0x0023C0D2 File Offset: 0x0023A2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeChallengeRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D67A RID: 54906 RVA: 0x0023C103 File Offset: 0x0023A303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D67B RID: 54907 RVA: 0x0023C10C File Offset: 0x0023A30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040055A0 RID: 21920
		private static readonly MessageParser<TakeChallengeRewardCsReq> _parser = new MessageParser<TakeChallengeRewardCsReq>(() => new TakeChallengeRewardCsReq());

		// Token: 0x040055A1 RID: 21921
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055A2 RID: 21922
		public const int GroupIdFieldNumber = 2;

		// Token: 0x040055A3 RID: 21923
		private uint groupId_;
	}
}

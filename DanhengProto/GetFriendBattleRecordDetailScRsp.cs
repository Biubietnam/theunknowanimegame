using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006BB RID: 1723
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendBattleRecordDetailScRsp : IMessage<GetFriendBattleRecordDetailScRsp>, IMessage, IEquatable<GetFriendBattleRecordDetailScRsp>, IDeepCloneable<GetFriendBattleRecordDetailScRsp>, IBufferMessage
	{
		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06004D19 RID: 19737 RVA: 0x000D101B File Offset: 0x000CF21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendBattleRecordDetailScRsp> Parser
		{
			get
			{
				return GetFriendBattleRecordDetailScRsp._parser;
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06004D1A RID: 19738 RVA: 0x000D1022 File Offset: 0x000CF222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendBattleRecordDetailScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06004D1B RID: 19739 RVA: 0x000D1034 File Offset: 0x000CF234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendBattleRecordDetailScRsp.Descriptor;
			}
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x000D103B File Offset: 0x000CF23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendBattleRecordDetailScRsp()
		{
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x000D1050 File Offset: 0x000CF250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendBattleRecordDetailScRsp(GetFriendBattleRecordDetailScRsp other) : this()
		{
			this.uid_ = other.uid_;
			this.retcode_ = other.retcode_;
			this.jKKGKOBJMJN_ = other.jKKGKOBJMJN_.Clone();
			this.fBEFBJHDCHL_ = ((other.fBEFBJHDCHL_ != null) ? other.fBEFBJHDCHL_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x000D10B9 File Offset: 0x000CF2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendBattleRecordDetailScRsp Clone()
		{
			return new GetFriendBattleRecordDetailScRsp(this);
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x06004D1F RID: 19743 RVA: 0x000D10C1 File Offset: 0x000CF2C1
		// (set) Token: 0x06004D20 RID: 19744 RVA: 0x000D10C9 File Offset: 0x000CF2C9
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

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x000D10D2 File Offset: 0x000CF2D2
		// (set) Token: 0x06004D22 RID: 19746 RVA: 0x000D10DA File Offset: 0x000CF2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06004D23 RID: 19747 RVA: 0x000D10E3 File Offset: 0x000CF2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BCCJGMONBKG> JKKGKOBJMJN
		{
			get
			{
				return this.jKKGKOBJMJN_;
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06004D24 RID: 19748 RVA: 0x000D10EB File Offset: 0x000CF2EB
		// (set) Token: 0x06004D25 RID: 19749 RVA: 0x000D10F3 File Offset: 0x000CF2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EHEACEHNEGA FBEFBJHDCHL
		{
			get
			{
				return this.fBEFBJHDCHL_;
			}
			set
			{
				this.fBEFBJHDCHL_ = value;
			}
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x000D10FC File Offset: 0x000CF2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendBattleRecordDetailScRsp);
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x000D110C File Offset: 0x000CF30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendBattleRecordDetailScRsp other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.Retcode == other.Retcode && this.jKKGKOBJMJN_.Equals(other.jKKGKOBJMJN_) && object.Equals(this.FBEFBJHDCHL, other.FBEFBJHDCHL) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x000D1180 File Offset: 0x000CF380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.jKKGKOBJMJN_.GetHashCode();
			if (this.fBEFBJHDCHL_ != null)
			{
				num ^= this.FBEFBJHDCHL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x000D11FC File Offset: 0x000CF3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x000D1204 File Offset: 0x000CF404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x000D1210 File Offset: 0x000CF410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			this.jKKGKOBJMJN_.WriteTo(ref output, GetFriendBattleRecordDetailScRsp._repeated_jKKGKOBJMJN_codec);
			if (this.fBEFBJHDCHL_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.FBEFBJHDCHL);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x000D1298 File Offset: 0x000CF498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.jKKGKOBJMJN_.CalculateSize(GetFriendBattleRecordDetailScRsp._repeated_jKKGKOBJMJN_codec);
			if (this.fBEFBJHDCHL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FBEFBJHDCHL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x000D131C File Offset: 0x000CF51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendBattleRecordDetailScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.jKKGKOBJMJN_.Add(other.jKKGKOBJMJN_);
			if (other.fBEFBJHDCHL_ != null)
			{
				if (this.fBEFBJHDCHL_ == null)
				{
					this.FBEFBJHDCHL = new EHEACEHNEGA();
				}
				this.FBEFBJHDCHL.MergeFrom(other.FBEFBJHDCHL);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x000D13A9 File Offset: 0x000CF5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x000D13B4 File Offset: 0x000CF5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						this.jKKGKOBJMJN_.AddEntriesFrom(ref input, GetFriendBattleRecordDetailScRsp._repeated_jKKGKOBJMJN_codec);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.fBEFBJHDCHL_ == null)
						{
							this.FBEFBJHDCHL = new EHEACEHNEGA();
						}
						input.ReadMessage(this.FBEFBJHDCHL);
						continue;
					}
					if (num == 112U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E7F RID: 7807
		private static readonly MessageParser<GetFriendBattleRecordDetailScRsp> _parser = new MessageParser<GetFriendBattleRecordDetailScRsp>(() => new GetFriendBattleRecordDetailScRsp());

		// Token: 0x04001E80 RID: 7808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E81 RID: 7809
		public const int UidFieldNumber = 14;

		// Token: 0x04001E82 RID: 7810
		private uint uid_;

		// Token: 0x04001E83 RID: 7811
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001E84 RID: 7812
		private uint retcode_;

		// Token: 0x04001E85 RID: 7813
		public const int JKKGKOBJMJNFieldNumber = 7;

		// Token: 0x04001E86 RID: 7814
		private static readonly FieldCodec<BCCJGMONBKG> _repeated_jKKGKOBJMJN_codec = FieldCodec.ForMessage<BCCJGMONBKG>(58U, BCCJGMONBKG.Parser);

		// Token: 0x04001E87 RID: 7815
		private readonly RepeatedField<BCCJGMONBKG> jKKGKOBJMJN_ = new RepeatedField<BCCJGMONBKG>();

		// Token: 0x04001E88 RID: 7816
		public const int FBEFBJHDCHLFieldNumber = 12;

		// Token: 0x04001E89 RID: 7817
		private EHEACEHNEGA fBEFBJHDCHL_;
	}
}
